using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ozeki.Media;
using Ozeki.VoIP;
using SupportSoftPhone.Helpers;
using SupportSoftPhone.PM.Data;

namespace SupportSoftPhone.SoftPhone
{
    public class SoftPhoneEngine
    {
        #region propeties
        private ISoftPhone softPhone;
        private IPhoneLine phoneLine;
        private ICall call;
        Microphone microphone;
        Speaker speaker;
        MediaConnector connector;               
        PhoneCallAudioSender mediaSender;  
        PhoneCallAudioReceiver mediaReceiver;
        WaveStreamRecorder recorder;
        public bool incomingCall;
        public string callStatesMessage;
        public int callStateCode;
        private static SoftPhoneEngine Singleton;
        public string userIncomingCall;
        string pathRecord = @"C:\Soft Phone\Call";
        #endregion
        #region callStatesCode note
        /*
         1.InCall (Đang trong cuộc gọi)
         2.Completed (Cuộc gọi kết thúc)
         3.LocalHeld (Giữ cuộc gọi)
         4.Transferring (Chuyển hướng cuộc gọi)
         5.Cancelled (Hủy cuộc gọi)
         6.Busy (Máy bận)
        */
        #endregion
        public static SoftPhoneEngine Instance
        {
            get
            {
                if (Singleton == null)
                {
                    Singleton = new SoftPhoneEngine();
                }                          
                return Singleton;
            }
        }
        public SoftPhoneEngine()
        {
            try
            {
                softPhone = SoftPhoneFactory.CreateSoftPhone(SoftPhoneFactory.GetLocalIP(),5000, 10000);
                softPhone.IncomingCall += SoftPhoneIncomingCall;
                microphone = Microphone.GetDefaultDevice();
                speaker = Speaker.GetDefaultDevice();
                connector = new MediaConnector();
                mediaSender = new PhoneCallAudioSender();
                mediaReceiver = new PhoneCallAudioReceiver();
                incomingCall = false;
                userIncomingCall = string.Empty;
                callStateCode = 0;
                callStatesMessage = string.Empty;
            }
            catch(Exception ex)
            {
            }
        }
        #region Even
        public event EventHandler IncomingCall; // cuộc gọi đến
        public event EventHandler<CallStateChangedArgs> CallStateChanged;// Khi trạng thái cuộc thay đổi
        public event EventHandler<RegistrationStateChangedArgs> PhoneLineStateChanged; //Khi trạng thái PhoneLine thay đổi
        #endregion
        
        public void Register(bool registrationRequired, string displayName, string userName, string authenticationId, string registerPassword, string domainHost, int domainPort)
        {
            try
            {
                softPhone.IncomingCall += SoftPhoneIncomingCall;
                var acount = new SIPAccount(registrationRequired, displayName, userName, authenticationId, registerPassword, domainHost,domainPort);
                phoneLine = softPhone.CreatePhoneLine(acount); 
                phoneLine.RegistrationStateChanged += PhoneLine_PhoneLineStateChanged;
                softPhone.RegisterPhoneLine(phoneLine);
                ConnectMedia();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Đăng ký Sip Acount thất bại!!!\n{ex.Message}","Thông báo");
            }
        }
        public void RegisterMatBao(PhoneLineInfo pli)
        {
            try
            {
                softPhone.IncomingCall += SoftPhoneIncomingCall;
                var sipAccount = new SIPAccount(pli.RegRequired, pli.DisplayName, pli.UserName,
                    pli.RegisterName, pli.Password, pli.DomainHost);
                phoneLine = softPhone.CreatePhoneLine(sipAccount);
                phoneLine.RegistrationStateChanged += PhoneLine_PhoneLineStateChanged;
                softPhone.RegisterPhoneLine(phoneLine);
                ConnectMedia();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Không thể xác thực Sip Acount!!!\n{ ex.Message}","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void SoftPhoneIncomingCall(object sender, VoIPEventArgs<IPhoneCall> e)// cuộc gọi đến
        {            
            Utils.PlayRing("ring_incoming");
            call = e.Item;
            userIncomingCall = call.OtherParty.UserName;// sđt user gọi đến
            WireUpCallEvents();
            incomingCall = true;
            DispatchAsync(() =>
            {
                var handler = IncomingCall;
                if (handler != null)
                    handler(this, EventArgs.Empty);
            });
        }        
        private void WireUpCallEvents()// Nhận trạng thái cuộc gọi
        {
            call.CallStateChanged += (Call_CallStateChanged);
        }
        private void WireDownCallEvents()// hủy trạng thái 
        {
            call.CallStateChanged -= (Call_CallStateChanged);
        }
        private void Call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            if(e.State==CallState.Ringing|| e.State == CallState.RingingWithEarlyMedia)
            {
                callStatesMessage = "Đang rung chuông...";
            }  
            if(e.State==CallState.Cancelled)
            {
                callStateCode = 5;
                Utils.StopRing();
                if(incomingCall)
                    callStatesMessage = "Cuộc gọi nhỡ...";
                else
                    callStatesMessage = "Đã huỷ cuộc gọi...";
            }    
            if(e.State==CallState.Busy)
            {
                Utils.StopRing();
                Utils.PlayRing("phone_busy");
                Thread.Sleep(3000);
                Utils.StopRing();
                callStatesMessage = "Đang bận máy...";
                StopDevices();
                callStateCode = 6;
            }
            if(e.State==CallState.Rejected)
            {
                Utils.StopRing();
                Utils.PlayRing("phone_disconnect");
                Thread.Sleep(2000);
                Utils.StopRing();
                callStatesMessage = "Cuộc gọi đã bị từ chối...";
            }    
            if (e.State == CallState.Answered)
            {
                Utils.StopRing();
                StartDevices();
                mediaReceiver.AttachToCall(call);
                mediaSender.AttachToCall(call);
                RecordCall("7109");
            }
            if (e.State == CallState.InCall)
            {
                callStateCode = 1;
                callStatesMessage = "Đang nhận cuộc gọi...";
                //callStatesMessage = "ok";
            }
            if(e.State==CallState.Completed)
            {
                Utils.StopRing();
                Utils.PlayRing("phone_disconnect");
                callStateCode = 2;
                callStatesMessage = "Cuộc gọi kết thúc...";
            }    
            if(e.State==CallState.Error)
            {
                Utils.StopRing();
                callStatesMessage = "Cuộc gọi phát sinh lỗi...";
            }    
            if(e.State==CallState.Transferring)
            {
                callStateCode = 4;
                callStatesMessage = "Đã chuyển hướng cuộc gọi";
            }    
            if(e.State==CallState.LocalHeld)
            {
                callStateCode = 3;
                callStatesMessage = "Đang giữ cuộc gọi";
            }
            if (e.State.IsCallEnded())
            {
                if (call != null)
                {
                    CallFinished();
                }
            }            
            DispatchAsync(() =>
            {
                var handler = CallStateChanged;
                if (handler != null)
                    handler(this, e);
            });
        }
        private void PhoneLine_PhoneLineStateChanged(object sender, RegistrationStateChangedArgs e)
        {
            DispatchAsync(() =>
            {
                var handler = PhoneLineStateChanged;
                if (handler != null)
                    handler(this, e);
            });
        }
        private void ConnectMedia()// Kết nối micro, loa 
        {
            if (microphone != null)
            {
                connector.Connect(microphone, mediaSender);
            }
            if (speaker != null)
            {
                connector.Connect(mediaReceiver, speaker);
            }
        }
        
        private void StartDevices()
        {
            if (microphone != null)
            {
                microphone.Start();
            }

            if (speaker != null)
            {
                speaker.Start();
            }
        }
        private void StopDevices()
        {
            if (microphone != null)
            {
                microphone.Stop();
            }

            if (speaker != null)
            {
                speaker.Stop();
            }
        }
        public void CallFinished()
        {
            StopDevices();
            mediaReceiver.Detach();
            mediaSender.Detach();
            WireDownCallEvents();
            if(recorder!=null)
            {
                recorder.Dispose();
            }
            call = null;
            recorder = null;
        }
        public void StartCall(string numberToDial)// gọi điện
        {
            try
            {
                if (call == null)
                {
                    Utils.PlayRing("phone_calling");
                    call = softPhone.CreateCallObject(phoneLine, numberToDial);                  
                    WireUpCallEvents();
                    call.Start();
                }
            }
            catch(Exception ex)
            {
                Utils.StopRing();
                MessageBox.Show($"Không thể thực hiện cuộc gọi!!!\n{ex.Message}","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void AcceptCall()// bắt máy khi có cuộc gọi đến
        {
            if (incomingCall & call !=null)
            {
                incomingCall = false;
                call.Answer();
            }
        }
        public void HangUp()// Cúp máy
        {
            if (call != null)
            {
                call.HangUp();
                call = null; 
            }
        }
        public void Reject()// Từ chối cuộc gọi
        {
            if(call!=null)
            {
                call.Reject();             
                call = null;
            }    
        }
        public void HoldCall()// Giữ cuộc gọi
        {
            if (call != null)
            {
                call.ToggleHold();
            }
        }
        public void TransferTo(string target)// Chuyển cuộc gọi
        {
            if (call != null && !string.IsNullOrEmpty(target))
            {
                call.BlindTransfer(target);
            }
        }
        private void RecordCall(string line)//ghi âm cuộc gọi
        {
            try
            {
                string dateTime = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-");
                if(!Directory.Exists(pathRecord))
                {
                    Directory.CreateDirectory(pathRecord);
                    recorder = new WaveStreamRecorder($"{pathRecord}\\{line} {dateTime}.wav");
                    connector.Connect(microphone, recorder);
                    connector.Connect(mediaReceiver, recorder);
                    recorder.Start();
                }
                else
                {
                    recorder = new WaveStreamRecorder($"{pathRecord}\\{line} {dateTime}.wav");
                    connector.Connect(microphone, recorder);
                    connector.Connect(mediaReceiver, recorder);
                    recorder.Start();
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Không thể ghi âm cuộc gọi.\n{ex}","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }      
        private void DispatchAsync(Action action)
        {
            var task = new WaitCallback(o => action.Invoke());
            ThreadPool.QueueUserWorkItem(task);
        }       
    }
}
