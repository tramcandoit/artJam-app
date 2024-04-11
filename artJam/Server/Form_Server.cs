using System;
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

namespace Server
{
    public partial class Server : Form
    {
        List<Room> roomList = new List<Room>();        
        private TcpListener listener;

        public Server()
        {
            InitializeComponent();
        }

        private void button_start_server_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(new IPEndPoint(IPAddress.Any, 51888));
            listener.Start();
            Thread clientListener = new Thread(Listen);
            clientListener.IsBackground = true;
            clientListener.Start();
        }

        private void button_stop_server_Click(object sender, EventArgs e)
        {
            // close client socket

            listener.Stop();
        }

        private void Listen()
        {
            while (true)
            {
                TcpClient client = null;
                try
                {
                    client = listener.AcceptTcpClient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Thread receiver = new Thread(Receive);
                receiver.IsBackground = true;
                receiver.Start(client);
            }
        }

        private void Receive(object obj)
        {
            TcpClient client = (TcpClient)obj;
            User user = new User(client);

            bool stop = false;
            while(!stop)
            {
                string requestInJson = null;
                try
                {
                    requestInJson = user.Reader.ReadLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (requestInJson == null && client.Connected == true)
                {
                    stop = true;
                    // remove client
                }

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
                        send_graphics_handler(user, request, requestInJson);
                        break;
                }
                //textBox_room_count.Text = roomList.Count.ToString();
                //client.Close();
            }
        }

        private void generate_room_handler(User user, Packet request)
        {
            Random r = new Random();
            int roomID = r.Next(1000, 9999);

            MessageBox.Show("Room code: " + roomID);

            Room room = new Room();
            room.roomID = roomID;

            user.Username = request.Username;
            room.userList.Add(user);

            roomList.Add(room);

            Packet message = new Packet
            {
                Code = 0,
                Username = request.Username,
                RoomID = roomID.ToString()
            };
            
            sendSpecific(user, message);
            //client.Close();
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
        }

        private void send_graphics_handler(User user, Packet request, string messageInJson)
        {
            int id = int.Parse(request.RoomID.ToString());
            Room requestingRoom = new Room();
            foreach (Room room in roomList)
            {
                if (room.roomID == id)
                {
                    requestingRoom = room;
                }
            }

            foreach (User _user in requestingRoom.userList)
            {
                if (_user != user)
                {
                    sendSpecific(_user, messageInJson);
                }
            }
        }

        private void sendSpecific(User user, Object message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            try
            {
                user.Writer.WriteLine(messageInJson);
                user.Writer.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}