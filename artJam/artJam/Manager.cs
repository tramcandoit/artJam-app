using System;
using System.Drawing;
using System.Windows.Forms;

namespace artJam
{
    internal class Manager
    {
        ListView List;
        TextBox RoomID;

        public Manager(ListView list, TextBox roomID)
        {
            this.List = list;
            this.RoomID = roomID;
        }

        public void AddToUserListView(string line)
        {
            if (List.InvokeRequired)
            {
                List.Invoke(new Action(() =>
                {
                    List.Items.Add(line);
                }));
            }
            else
            {
                List.Items.Add(line);
            }
        }

        public void RemoveFromUserListView(string line)
        {
            Action action = () =>
            {
                foreach(ListViewItem item in List.Items)
                {
                    if (item.Text == line)
                    {
                        List.Items.Remove(item);
                        break;
                    }
                }
            };
            if (List.InvokeRequired)
            {
                List.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public void ClearUserListView()
        {
            Action action = () =>
            {
                ListViewItem firstLine = List.Items[0];
                List.Clear();
                List.Items.Add(firstLine);
            };
            if (List.InvokeRequired)
            {
                List.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public void UpdateRoomID(string roomID)
        {
            if (RoomID.InvokeRequired)
            {
                RoomID.Invoke(new Action(() =>
                {
                    RoomID.Text = "Room: " + roomID;
                }));
            }
            else
            {
                RoomID.Text = "Room: " + roomID;
            }
        }
        public string BitmapToString(Bitmap bitmap)
        {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageBytes = stream.ToArray();
            string base64String = Convert.ToBase64String(imageBytes);

            return base64String;
        }

        public Bitmap StringToBitmap(string base64string)
        {
            byte[] imageBytes = Convert.FromBase64String(base64string);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(imageBytes, 0, imageBytes.Length);
            stream.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(stream, true);
            Bitmap bitmap = new Bitmap(image);

            return bitmap;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
