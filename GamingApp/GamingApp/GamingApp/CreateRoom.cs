using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace GamingApp
{
    public partial class CreateRoom : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        public CreateRoom()
        {
            InitializeComponent();
        }
        public string Onlineusername;
        private void CreateRoom_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Database/GamingApp.s3db;Version=3;");

        }
        private void Create_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = new SQLiteCommand();
                Random rastgele = new Random();
                int Roomid = rastgele.Next(100000, 999999);
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into Rooms (Roomid,RoomAdmin,RoomTitle,RoomGame,PlayerCount) values ('" + Roomid.ToString() + "','" + Onlineusername + "','" + Roomtitle.Text + "','" + Gamename.Text + "','" + PlayerCount.SelectedItem + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                inroom inroom = new inroom();
                inroom.OnlineUser = Onlineusername;
                inroom.roomid = Roomid.ToString();
                inroom.roomtitle = Roomtitle.Text;
                inroom.gamename = Gamename.Text;
                inroom.laterornow = now.Checked;
                this.Close();
                inroom.Show();
            }
            catch { MessageBox.Show("Zaten bir odanız var");
                Rooms rooms = new Rooms();
                rooms.Onlineusername = Onlineusername;
                rooms.Show(); }
        }

        private void later_CheckedChanged(object sender, EventArgs e)
        {
            now.Checked = false;
            Day.Enabled = true;
            Hour.Enabled = true;
            Minute.Enabled = true;
        }

        private void now_CheckedChanged(object sender, EventArgs e)
        {
            later.Checked = false;
            Day.Enabled = false;
            Hour.Enabled = false;
            Minute.Enabled = false;
        }
    }
}
