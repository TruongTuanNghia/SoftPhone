using Ozeki.VoIP;
using SupportSoftPhone.Helpers;
using SupportSoftPhone.Models;
using SupportSoftPhone.PM.Data;
using SupportSoftPhone.SoftPhone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportSoftPhone.GUI
{
    public partial class frmMain : Form
    {
        //SoftPhoneEngine mySoftPhone = new SoftPhoneEngine();
        #region propeties
        private SoftPhoneEngine mySoftPhone;
        string phoneNumber;
        protected IEnumerable<Button> NumKeys;
        ThreadHelperClass threadHelper = new ThreadHelperClass();
        bool transfer = false;
        bool holdCall = false;
        System.Timers.Timer timer;
        int timeCountSecond = 0;
        int timeCountMinute = 0;
        int timeCountHours = 0;
        private Agents UserAgent { get; set; }
        #endregion
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(SoftPhoneEngine softPhoneEngine)
        {
            try
            {
                InitializeComponent();
                this.mySoftPhone = softPhoneEngine;
                softPhoneEngine.IncomingCall += Softphone_IncomingCall;
                softPhoneEngine.CallStateChanged += Softphone_CallStateChanged;
                Utils.CheckChangeMicrophone();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowRegister();
            //ShowCall();
            //ShowInComingCall();
            //ShowHistories();
            var numKeys = new List<Button>();
            numKeys.Add(btnKeypad1);
            numKeys.Add(btnKeypad2);
            numKeys.Add(btnKeypad3);
            numKeys.Add(btnKeypad4);
            numKeys.Add(btnKeypad5);
            numKeys.Add(btnKeypad6);
            numKeys.Add(btnKeypad7);
            numKeys.Add(btnKeypad8);
            numKeys.Add(btnKeypad9);
            numKeys.Add(btnKeypad0);
            numKeys.Add(btnKeypadSharp);
            numKeys.Add(btnKeypadAsterisk);
            NumKeys = numKeys;
            btnDeleteNumPhone.Visible = false;
            btnNext.Visible = false;
            timer = new System.Timers.Timer();
            timer.Interval = 1200;
            timer.Enabled = true;
            CreateToolTip();
            GetMicroPhone();
        }
        private void Keypad_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn!=null)
            {
                cbPhoneNumber.Text += btn.Tag.ToString().Trim();
            }
            cbPhoneNumber.Focus();
            cbPhoneNumber.SelectionStart = cbPhoneNumber.Text.Length;
        }
        private void ShowRegister()
        {
            threadHelper.UpdateTextControl(txtEmailLogin, "Click vào Register");
            threadHelper.UpdateVisibleControl(grpSetupAndInCall,false);
            threadHelper.UpdateVisibleControl(gbCall,false);
            threadHelper.UpdateVisibleControl(gbAllHistories,false);
            threadHelper.UpdateVisibleControl(gbRegister,true);           
        }
        private void ShowCall()
        {
            threadHelper.UpdateVisibleControl(gbCall, true);
            threadHelper.UpdateVisibleControl(gbRegister, false);
            threadHelper.UpdateVisibleControl(grpSetupAndInCall, false);
            threadHelper.UpdateVisibleControl(gbAllHistories, false);
           // BindCallHistories();
            threadHelper.FocusControl(cbPhoneNumber);
        }
        private void ShowInComingCall()
        {
            threadHelper.UpdateVisibleControl(grpSetupAndInCall, true);
            threadHelper.UpdateVisibleControl(gbCall, false);
            threadHelper.UpdateVisibleControl(gbRegister, false);
            threadHelper.UpdateVisibleControl(gbAllHistories, false);
        }
        private void ShowHistories()
        {
            //BindLoadGroupHistories();
            threadHelper.UpdateVisibleControl(grpSetupAndInCall, false);
            threadHelper.UpdateVisibleControl(gbCall, false);
            threadHelper.UpdateVisibleControl(gbRegister, false);
            threadHelper.UpdateVisibleControl(gbAllHistories, true);
        }
        private void Softphone_IncomingCall(object sender, EventArgs e)// status cuộc gọi đến
        {
            threadHelper.UpdateTextControl(lblDialNumber, mySoftPhone.userIncomingCall);
            threadHelper.UpdateTextControl(lblCallStatus, "Đang gọi vào...");            
            Utils.ShowMessageApp(ntfMessage,10000,"CUỘC GỌI ĐẾN", mySoftPhone.userIncomingCall);
            ShowInComingCall();
        }
        private void Softphone_CallStateChanged(object sender, EventArgs e)//status cuộc gọi
        {
            //if (mySoftPhone.callStatesMessage.Equals("ok"))
            if(mySoftPhone.callStateCode==1)
            {
                threadHelper.UpdateVisibleControl(lblCallStatus, false);
                threadHelper.UpdateVisibleControl(lbTimeCall, true);
                timer.Elapsed += timer_Tick;
            }
            else
            {
                if(mySoftPhone.callStateCode==2||mySoftPhone.callStateCode==4 || mySoftPhone.callStateCode==5||mySoftPhone.callStateCode==6)
                {
                    threadHelper.UpdateVisibleControl(lbTimeCall, false);
                    timer.Elapsed -= timer_Tick;
                    threadHelper.UpdateTextControl(lblCallStatus, mySoftPhone.callStatesMessage);
                    threadHelper.UpdateVisibleControl(lblCallStatus, true);
                    Thread.Sleep(1000);
                    ShowCall();
                    mySoftPhone.callStateCode = 0;
                }
                else
                {
                    threadHelper.UpdateVisibleControl(lbTimeCall, false);
                    threadHelper.UpdateTextControl(lblCallStatus, mySoftPhone.callStatesMessage);
                    threadHelper.UpdateVisibleControl(lblCallStatus, true);
                }
            }
        }
        private void btnCall_Click(object sender, EventArgs e)
        {
            SetTimeStartCall();
            CallOrTransfer();
        }       
        private void btnRegister_Click(object sender, EventArgs e)
        {
                //PhoneLogin();
                Login();
                ShowCall();
        }
        private void Login()
        {
            var displayName = "Trương Tuấn Nghĩa";
            var userName = "2230229769";
            var authenticationId = "2230229769";
            var registerPassword = "2571621234";
            var domainHost = "sip.tel4vn.com";
            int domainPort = 50061;
            lbNameUser.Text = $"{displayName} - {userName}";
            mySoftPhone.Register(true, displayName, userName, authenticationId, registerPassword, domainHost, domainPort);
        }
        private void PhoneLogin()
        {
            if(string.IsNullOrEmpty(txtEmailLogin.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập email đăng nhập","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                this.UserAgent = AgentHelper.GetAgentAccountByEmail(txtEmailLogin.Text.Trim());
                if (this.UserAgent != null)
                {
                    lbNameUser.Text = $"{UserAgent.u_alias} - {UserAgent.u_phone_agent}";
                    mySoftPhone.RegisterMatBao(PhoneLineInfoRegister());
                    ShowCall();
                }
                else
                {
                    ShowRegister();
                    MessageBox.Show("Tài khoản của bạn không hợp lệ\nHoặc chưa được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private PhoneLineInfo PhoneLineInfoRegister()
        {
            PhoneLineInfo SIPAccount = new PhoneLineInfo(true, this.UserAgent.u_alias,this.UserAgent.u_phone_agent,
                this.UserAgent.u_phone_agent,this.UserAgent.u_phone_agent_password, this.UserAgent.u_phone_server, this.UserAgent.u_phone_server_port);
            return SIPAccount;
        }
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnTranfer_Click(object sender, EventArgs e)
        {
            if(mySoftPhone.callStateCode==1||mySoftPhone.callStateCode==3)
            {
                ShowCall();
                transfer = true;
                btnNext.Visible = true;
            }
            else
            {
                MessageBox.Show("Hiện tại không có cuộc gọi nào để chuyển cuộc gọi.", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void btnDeleteNumPhone_Click(object sender, EventArgs e)
        {
            if(cbPhoneNumber.Text.Length>0)
            {
               char[] charNum= cbPhoneNumber.Text.ToCharArray();
                cbPhoneNumber.Text = null;
                for(int i=0;i<charNum.Length-1;i++)
                {
                    cbPhoneNumber.Text += charNum[i].ToString();
                }
            }    
        }
        private void btnMiniApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void timer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (timeCountHours == 0)
            {
                if (timeCountSecond <= 59)
                {
                    threadHelper.UpdateTextControl(lbTimeCall, $"{ShowTime(timeCountMinute)}:{ShowTime(timeCountSecond)}");
                }
                else
                {
                    timeCountSecond = 0;
                    timeCountMinute++;
                    if (timeCountMinute <= 59)
                    {
                        threadHelper.UpdateTextControl(lbTimeCall, $"{ShowTime(timeCountMinute)}:{ShowTime(timeCountSecond)}");
                    }
                    else
                    {
                        timeCountMinute = 0;
                        timeCountHours++;
                        threadHelper.UpdateTextControl(lbTimeCall, $"{ShowTime(timeCountHours)}:{ShowTime(timeCountMinute)}:{ShowTime(timeCountSecond)}");
                    }
                }
            }
            else
            {
                if (timeCountSecond <= 59)
                {
                    threadHelper.UpdateTextControl(lbTimeCall, $"{ShowTime(timeCountHours)}:{ShowTime(timeCountMinute)}:{ShowTime(timeCountSecond)}");
                }
                else
                {
                    timeCountSecond = 0;
                    timeCountMinute++;
                    if (timeCountMinute <= 59)
                    {
                        threadHelper.UpdateTextControl(lbTimeCall, $"{ShowTime(timeCountHours)}:{ShowTime(timeCountMinute)}:{ShowTime(timeCountSecond)}");
                    }
                    else
                    {
                        timeCountMinute = 0;
                        timeCountHours++;
                        threadHelper.UpdateTextControl(lbTimeCall, $"{ShowTime(timeCountHours)}:{ShowTime(timeCountMinute)}:{ShowTime(timeCountSecond)}");
                    }
                }
            }
            timeCountSecond++;
        }
        public string ShowTime(int time)
        {
            string respon = string.Empty;           
                if (time < 10)
                {
                    respon = $"0{time}";
                }
                else
                {
                    respon = $"{time}";
                }           
            return respon;
        }
 #region Mouse Hover
        private void btnKeyboard_MouseHover(object sender, EventArgs e)
        {
            btnKeyboard.BackgroundImage = Utils.GetResource("keyboard_hover");
        }
        private void btnKeyboard_MouseLeave(object sender,EventArgs e)
        {
            btnKeyboard.BackgroundImage = Utils.GetResource("keyboard");
        }
        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            btnRegister.BackgroundImage = Utils.GetResource("bt_register_hover");
        }
        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackgroundImage = Utils.GetResource("bt_register");
        }
        private void btnKeypad1_MouseHover(object sender, EventArgs e)
        {
            btnKeypad1.BackgroundImage = Utils.GetResource("p_1_hover");
        }
        private void btnKeypad1_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad1.BackgroundImage = Utils.GetResource("p_1");
        }
        private void btnKeypad2_MouseHover(object sender, EventArgs e)
        {
            btnKeypad2.BackgroundImage = Utils.GetResource("p_2_hover");
        }
        private void btnKeypad2_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad2.BackgroundImage = Utils.GetResource("p_2");
        }
        private void btnKeypad3_MouseHover(object sender, EventArgs e)
        {
            btnKeypad3.BackgroundImage = Utils.GetResource("p_3_hover");
        }
        private void btnKeypad3_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad3.BackgroundImage = Utils.GetResource("p_3");
        }
        private void btnKeypad4_MouseHover(object sender, EventArgs e)
        {
            btnKeypad4.BackgroundImage = Utils.GetResource("p_4_hover");
        }
        private void btnKeypad4_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad4.BackgroundImage = Utils.GetResource("p_4");
        }
        private void btnKeypad5_MouseHover(object sender, EventArgs e)
        {
            btnKeypad5.BackgroundImage = Utils.GetResource("p_5_hover");
        }
        private void btnKeypad5_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad5.BackgroundImage = Utils.GetResource("p_5");
        }
        private void btnKeypad6_MouseHover(object sender, EventArgs e)
        {
            btnKeypad6.BackgroundImage = Utils.GetResource("p_6_hover");
        }
        private void btnKeypad6_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad6.BackgroundImage = Utils.GetResource("p_6");
        }
        private void btnKeypad7_MouseHover(object sender, EventArgs e)
        {
            btnKeypad7.BackgroundImage = Utils.GetResource("p_7_hover");
        }
        private void btnKeypad7_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad7.BackgroundImage = Utils.GetResource("p_7");
        }
        private void btnKeypad8_MouseHover(object sender, EventArgs e)
        {
            btnKeypad8.BackgroundImage = Utils.GetResource("p_8_hover");
        }
        private void btnKeypad8_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad8.BackgroundImage = Utils.GetResource("p_8");
        }
        private void btnKeypad9_MouseHover(object sender, EventArgs e)
        {
            btnKeypad9.BackgroundImage = Utils.GetResource("p_9_hover");
        }
        private void btnKeypad9_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad9.BackgroundImage = Utils.GetResource("p_9");
        }
        private void btnKeypad0_MouseHover(object sender, EventArgs e)
        {
            btnKeypad0.BackgroundImage = Utils.GetResource("p_0_hover");
        }
        private void btnKeypad0_MouseLeave(object sender, EventArgs e)
        {
            btnKeypad0.BackgroundImage = Utils.GetResource("p_0");
        }
        private void btnKeypadAsterisk_MouseHover(object sender, EventArgs e)
        {
            btnKeypadAsterisk.BackgroundImage = Utils.GetResource("p_sao_hover");
        }
        private void btnKeypadAsterisk_MouseLeave(object sender, EventArgs e)
        {
            btnKeypadAsterisk.BackgroundImage = Utils.GetResource("p_sao");
        }
        private void btnKeypadSharp_MouseHover(object sender, EventArgs e)
        {
            btnKeypadSharp.BackgroundImage = Utils.GetResource("p_sharp_hover");
        }
        private void btnKeypadSharp_MouseLeave(object sender, EventArgs e)
        {
            btnKeypadSharp.BackgroundImage = Utils.GetResource("p_sharp");
        }
        private void btnHold_MouseHover(object sender,EventArgs e)
        {
            if(!holdCall)
            {
                btnHold.BackgroundImage = Utils.GetResource("bt_hold_hover");
            }
            else
            {
                btnHold.BackgroundImage = Utils.GetResource("bt_unhold_hover");
            }
        }
        private void btnHold_MouseLeave(object sender,EventArgs e)
        {
            if(!holdCall)
            {
                btnHold.BackgroundImage = Utils.GetResource("bt_hold");
            }
            else
            {
                btnHold.BackgroundImage = Utils.GetResource("bt_unhold");
            }
        }
        private void btnTranfer_MouseHover(object sender,EventArgs e)
        {
            btnTranfer.BackgroundImage = Utils.GetResource("bt_transfer_hover");
        }
        private void btnTranfer_MouseLeave(object sender,EventArgs e)
        {
            btnTranfer.BackgroundImage = Utils.GetResource("bt_transfer");
        }
        private void btnDeleteNumPhone_MouseHover(object sender,EventArgs e)
        {
            btnDeleteNumPhone.BackgroundImage = Utils.GetResource("clear_pad_hover");
        }
        private void btnDeleteNumPhone_MouseLeave(object sender,EventArgs e)
        {
            btnDeleteNumPhone.BackgroundImage = Utils.GetResource("clear_pad");
        }
        private void btnHistories_MouseHover(object sender,EventArgs e)
        {
            btnHistories.BackgroundImage = Utils.GetResource("history_hover");
        }
        private void btnHistories_MouseLeaver(object sender,EventArgs e)
        {
            btnHistories.BackgroundImage = Utils.GetResource("history");
        }
        private void btnSoftPhone_MouseHover(object sender,EventArgs e)
        {
            btnSoftPhone.BackgroundImage = Utils.GetResource("softphone_hover");
        }
        private void btnSoftPhone_MouseLeaver(object sender,EventArgs e)
        {
            btnSoftPhone.BackgroundImage = Utils.GetResource("softphone");
        }
    #endregion

        private void ntfMessage_BalloonTipClicked(object sender, EventArgs e)//lịch sử của sđt gọi đến
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = $"https://sa.matbao.com/Support/CallNotes?uniqueid=IN&phone={mySoftPhone.userIncomingCall}",
                UseShellExecute = true
            };
            Process.Start(startInfo);
        }
        private void btnHangUp_Click(object sender, EventArgs e)
        {
            SetTimeStartCall();
            transfer = false;
            Utils.StopRing();
            if (mySoftPhone.incomingCall)
            {
                mySoftPhone.Reject();
            }
            else
                mySoftPhone.HangUp();
        }
        private void btnPickup_Click(object sender, EventArgs e)
        {
            SetTimeStartCall();
            transfer = false;
            Utils.StopRing();
            mySoftPhone.AcceptCall();
            timer.Elapsed += timer_Tick;
        }
        private void btnHold_Click(object sender, EventArgs e)
        {
            if(mySoftPhone.callStateCode==1||mySoftPhone.callStateCode==3)
            {
                if(holdCall==false)
                {
                    btnHold.BackgroundImage = Utils.GetResource("bt_unhold");
                    holdCall = !holdCall;
                }
                else
                {
                    btnHold.BackgroundImage = Utils.GetResource("bt_hold");
                    holdCall = !holdCall;
                }
                mySoftPhone.HoldCall();
            }
            else
            {
                MessageBox.Show("Hiện tại không có cuộc gọi nào để thực hiện giữ cuộc gọi","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            ShowCall();
            btnNext.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowInComingCall();
        }
        private void CreateToolTip()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Active = true;
            toolTip.ShowAlways = true;
            toolTip.IsBalloon = true;
            toolTip.SetToolTip(cbPhoneNumber, "Nhập số điện thoại.");
            toolTip.SetToolTip(txtEmailLogin, "Nhập email để đăng nhập.");
            toolTip.SetToolTip(btnNext, "Chuyển sang màng hình cuộc gọi.");
            toolTip.SetToolTip(btnRegister, "Click chuột hoặc nhấn phím Enter để đăng nhập.");
            toolTip.SetToolTip(btnHistories, "Xem lịch sử cuộc gọi");
            toolTip.SetToolTip(btnSoftPhone,"Bàn phím");
            toolTip.SetToolTip(btnDeleteNumPhone, "Xóa");
            toolTip.SetToolTip(btnCloseApp, "Thoát");
            toolTip.SetToolTip(btnMiniApp, "Thu nhỏ");
        }
        private void txtEmailLogin_KeyDown(object sender, KeyEventArgs e)// Đăng nhập khi nhấn phím enter
        {
            if(e.KeyCode==Keys.Enter)
            {
                //PhoneLogin();
                Login();
                ShowCall();
                //ShowInComingCall();
            }
        }
        private void CallOrTransfer()
        {
            try
            {
                phoneNumber = cbPhoneNumber.Text.Trim();
                if (string.IsNullOrEmpty(phoneNumber))
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!Utils.CheckConnectMicrophone())
                    {
                        Utils.ShowMessageApp(ntfMessageMicro, 5000, "Thông báo", "Bạn chưa kết nối với Microphone.\nHãy kết nối với Microphone để tiếp tục cuộc gọi.");
                    }
                    else
                    {
                        if (transfer)
                        {
                            mySoftPhone.TransferTo(phoneNumber);
                            transfer = false;
                            ShowInComingCall();
                            lblDialNumber.Text = phoneNumber;
                        }
                        else
                        {
                            mySoftPhone.StartCall(phoneNumber);
                            ShowInComingCall();
                            lblDialNumber.Text = phoneNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể thực hiện cuộc gọi.\n{ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SetTimeStartCall()
        {
            timeCountSecond = 0;
            timeCountMinute = 0;
            timeCountHours = 0;
        }
        private void GetMicroPhone()
        {
            if(Utils.GetMicrophone().Count!=0)
            {
                foreach(var item in Utils.GetMicrophone())
                {
                    cbMicrophone.Items.Add(item);
                }
                cbMicrophone.Text = Utils.GetMicrophone().FirstOrDefault();
            }    
        }
        private void BindCallHistories()//Hiển thị lịch sử các cuộc gọi vào cbPhoneNumber
        {
            //var listHistories = AgentHelper.GetCallRecentlyHistories(this.UserAgent);
            var listHistories = AgentHelper.GetCallRecentlyHistoriesString(/*this.UserAgent.u_phone_agent*/"");
            cbPhoneNumber.DataSource = listHistories.Select(x => x.u_phone_number).ToList();
            threadHelper.UpdateTextControl(cbPhoneNumber, null);
        }
        #region event cbPhoneNumber
        private void cbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void cbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (cbPhoneNumber.Text.Length > 0)
            {
                btnDeleteNumPhone.Visible = true;
            }
            else
                btnDeleteNumPhone.Visible = false;
        }
        private void cbPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CallOrTransfer();
            }
        }

        #endregion
        #region get histories
        private void BindLoadGroupHistories()
        {
            var lastWeek = DateTime.Today;
            var listHistories = AgentHelper.GetCallRecentlyHistoriesString("")
                .Select(x => new { x.u_phone_type, x.u_phone_date, x.u_phone_number }).ToList();
            dgvHistories.DataSource = listHistories;
        }
        private void btnCallOut_Click(object sender, EventArgs e)//lịch sử các cuộc gọi đi
        {
            //var listHistoriesCallOut = AgentHelper.GetCallRecentlyHistoriesString("")
            //    .Where(s=>s.u_phone_type=="OUT")
            //    .Select(x=>new {x.u_phone_type,x.u_phone_date,x.u_phone_number }).ToList();
            //dgvHistories.DataSource = listHistoriesCallOut;
        }
        private void btnCallIn_Click(object sender, EventArgs e)//lịch sử các cuộc gọi đến
        {
            //var listHistoriesCallIn = AgentHelper.GetCallRecentlyHistoriesString("")
            //    .Where(s => s.u_phone_type == "IN")
            //    .Select(x => new { x.u_phone_type, x.u_phone_date, x.u_phone_number }).ToList();
            //dgvHistories.DataSource = listHistoriesCallIn;
        }
        private void btnAllCall_Click(object sender, EventArgs e)//Lịch sử tất cả cuộc gọi
        {
            //var listHistoriesAll = AgentHelper.GetCallRecentlyHistoriesString("").
            //    Select(x=>new { x.u_phone_type, x.u_phone_date,x.u_phone_number }).ToList();
            //dgvHistories.DataSource = listHistoriesAll;
        }
        private void btnHistories_Click(object sender, EventArgs e)
        {
            ShowHistories();
        }
        #endregion
        private void btnSoftPhone_Click(object sender, EventArgs e)
        {
            ShowCall();
        }
    }
}
