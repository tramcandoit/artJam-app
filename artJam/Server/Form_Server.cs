﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Server
{
    public partial class Server : Form
    {
        private List<Room> roomList = new List<Room>(); 
        private List<User> userList = new List<User>();
        private TcpListener listener;
        Manager Manager;
        public Server()
        {
            InitializeComponent();

            Manager = new Manager(listView_log, textBox_room_count, textBox_user_count);
        }

        private void button_start_server_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 9999);
            listener.Start();

            Thread clientListener = new Thread(Listen);
            clientListener.IsBackground = true;
            clientListener.Start();

            Manager.WriteToLog("Server bắt đầu lắng nghe...");

            this.button_start_server.Enabled = false;
        }

        private void button_stop_server_Click(object sender, EventArgs e)
        {
            Manager.WriteToLog("Đóng kết nối server...");
            foreach (User user in userList)
            {
                user.Client.Close();
            }
            listener.Stop();
        }

        private void button_get_server_IP_Click(object sender, EventArgs e)
        {
            textBox_server_local_IP.Text = Manager.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
        }

        private void Listen()
        {
            try
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();

                    Thread receiver = new Thread(Receive);
                    receiver.IsBackground = true;
                    receiver.Start(client);
                }
            }
            catch
            {
                listener = new TcpListener(IPAddress.Any, 9999);
                listener.Start();
            }
        }

        private void Receive(object obj)
        {
            TcpClient client = obj as TcpClient;
            User user = new User(client);
            userList.Add(user);

            try
            {
                string requestInJson = string.Empty;
                while (true)
                {
                    requestInJson = user.Reader.ReadLine();

                    Packet request = JsonConvert.DeserializeObject<Packet>(requestInJson);

                    switch (request.Code)
                    {
                        case 0:
                            generate_room_handler(user, request);
                            break;
                        case 1:
                            join_room_handler(user, request);
                            break;
                        case 2:
                            send_graphics_handler(user, request);
                            break;
                    }
                }
            }

            catch
            {
                close_client(user);
            }
        }

        private void generate_room_handler(User user, Packet request)
        {
            user.Username = request.Username;

            Random r = new Random();
            int roomID = r.Next(1000, 9999);
            Room newRoom = new Room();
            newRoom.roomID = roomID;

            newRoom.userList.Add(user);
            roomList.Add(newRoom);

            Manager.WriteToLog(user.Username + " tạo phòng mới. Mã phòng: " + newRoom.roomID);
            Manager.UpdateRoomCount(roomList.Count);
            Manager.UpdateUserCount(userList.Count);

            Packet message = new Packet
            {
                Code = 0,
                Username = request.Username,
                RoomID = roomID.ToString()
            };
            
            sendSpecific(user, message);
        }

        private void join_room_handler(User user, Packet request)
        {
            int id = int.Parse(request.RoomID.ToString());
            foreach (Room room in roomList)
            {
                if (room.roomID == id)
                {
                    user.Username = request.Username;
                    room.userList.Add(user);
                }
            }
            Manager.WriteToLog(request.RoomID + ": " + user.Username + " tham gia");
            Manager.UpdateUserCount(userList.Count);
        }

        private void send_graphics_handler(User user, Packet request)
        {
            int id = int.Parse(request.RoomID.ToString());
            Room requestingRoom = new Room();
            foreach (Room room in roomList)
            {
                if (room.roomID == id)
                {
                    requestingRoom = room;
                    break;
                }
            }

            foreach (User _user in requestingRoom.userList)
            {
                if (_user != user)
                {
                    sendSpecific(_user, request);
                }
            }
        }

        private void close_client(User user)
        {
            foreach (Room room in roomList)
            {
                if (room.userList.Contains(user))
                {
                    room.userList.Remove(user);
                }
            }
            userList.Remove(user);
            user.Client.Close();

            Manager.WriteToLog(user.Username + " đã ngắt kết nối.");
            Manager.UpdateRoomCount(roomList.Count);
            Manager.UpdateUserCount(userList.Count);
        }

        private void sendSpecific(User user, Object message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            try
            {
                user.Writer.WriteLine(messageInJson);
                user.Writer.Flush();
            }
            catch
            {
                Manager.ShowError("Không gửi được nét vẽ đến user: " + user.Username);
            }
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (User user in userList)
            {
                user.Client.Close();
            }
            listener.Stop();
        }
    }
}