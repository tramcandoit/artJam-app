using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    RoomID.Text = "Phòng: " + roomID;
                }));
            }
            else
            {
                RoomID.Text = "Phòng: " + roomID;
            }
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
