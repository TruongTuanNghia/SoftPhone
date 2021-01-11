﻿using NAudio.CoreAudioApi;
using NAudio.CoreAudioApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportSoftPhone.Helpers
{
    public class Utils
    {
       static SoundPlayer playAudio;
        public static string GetClientIPAddress
        {
            get
            {
                IPHostEntry host;
                string localAddress = string.Empty;
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress address in host.AddressList)
                {
                    if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        localAddress = address.ToString();
                        break;
                    }
                }
                return localAddress;
            }
        }
        public static Image GetResource(string resourceName)//lấy image
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
        }
        public static Icon GetResourceIcon(string resourceName)//lấy icon
        {
            return (Icon)Properties.Resources.ResourceManager.GetObject(resourceName);
        }
        public static void PlayRing(string audio)
        {
            Stream str = (Stream)Properties.Resources.ResourceManager.GetObject(audio);
            playAudio = new SoundPlayer(str);
            playAudio.Play();
        }
        public static void StopRing()
        {
            if (playAudio != null)
            {
                playAudio.Stop();
            }
        }
        //Hiển thị thông báo
        public static void ShowMessageApp(NotifyIcon control, int timeShow, string title, string conten)
        {
            control.Visible = true;
            control.ShowBalloonTip(timeShow, title, conten, ToolTipIcon.Info);
        }
        public static bool CheckConnectMicrophone()//kiêm tra micro
        {
            var enumerator = new MMDeviceEnumerator();
            var endpoints = enumerator.EnumerateAudioEndPoints(
               DataFlow.Render,DeviceState.Active);
            if (endpoints.Count == 0)
                return false;
            return true;
        }
        public static List<string> GetMicrophone()// Hiển thị micro
        {
            List<string> listMicro = new List<string>();
            var enumerator = new MMDeviceEnumerator();
            var endpoints = enumerator.EnumerateAudioEndPoints(
               DataFlow.Render, DeviceState.Active);
            foreach(var endpoint in endpoints)
            {
                listMicro.Add(endpoint.DeviceFriendlyName);
            }
            return listMicro;
        }
        public static void CheckChangeMicrophone()// microphone cắm vào/rút ra 
        {
            var enumerator = new MMDeviceEnumerator();
            enumerator.RegisterEndpointNotificationCallback(new NotificationClient());
        }
    }
    class NotificationClient : IMMNotificationClient
    {
        NotifyIcon notify = new NotifyIcon();
        void IMMNotificationClient.OnDeviceStateChanged(string deviceId, DeviceState newState)
        {
            notify.Icon = Utils.GetResourceIcon("app_icon_ico");
            if (newState.ToString().Contains("NotPresent"))
            {
                Utils.ShowMessageApp(notify, 5000, "Thông báo", "Đã ngắt kết nối Microphone");
            }
            else
            {
                Utils.ShowMessageApp(notify, 5000, "Thông báo", "Kết nối Microphone thành công");
            }
        }
        void IMMNotificationClient.OnDeviceAdded(string pwstrDeviceId) { }
        void IMMNotificationClient.OnDeviceRemoved(string deviceId) { }
        void IMMNotificationClient.OnDefaultDeviceChanged(DataFlow flow, Role role, string defaultDeviceId) { }
        void IMMNotificationClient.OnPropertyValueChanged(string pwstrDeviceId, PropertyKey key) { }
    }
}
