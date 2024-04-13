using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    internal class Manager
    {
        ListView Log;
        TextBox RoomCnt;
        TextBox UserCnt;

        public Manager(ListView log, TextBox room_count, TextBox user_count)
        {
            this.Log = log;
            this.RoomCnt = room_count;
            this.UserCnt = user_count;
        }

        public void WriteToLog(string line)
        {
            if (Log.InvokeRequired)
            {
                Log.Invoke(new Action(() =>
                {
                    Log.Items.Add(line);
                }));
            }
            else
            {
                Log.Items.Add(line);
            }
        }

        public void UpdateRoomCount(int num)
        {
            if (RoomCnt.InvokeRequired)
            {
                RoomCnt.Invoke(new Action(() =>
                {
                    RoomCnt.Text = num.ToString();
                }));
            }
            else
            {
                RoomCnt.Text = num.ToString();
            }
        }

        public void UpdateUserCount(int num)
        {
            if (UserCnt.InvokeRequired)
            {
                UserCnt.Invoke(new Action(() =>
                {
                    UserCnt.Text = num.ToString();
                }));
            }
            else
            {
                UserCnt.Text = num.ToString();
            }
        }

        public string GetLocalIPv4(NetworkInterfaceType type)
        {
            string localIPv4 = string.Empty;
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            localIPv4 = ip.Address.ToString();
                        }
                    }
                }
            }
            return localIPv4;
        }
    }
}
