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
    public partial class inroom : Form
    {
        public inroom()
        {
            InitializeComponent();
        }
        SQLiteConnection con;
        SQLiteCommand cmd;
        public string OnlineUser,roomid,roomtitle,gamename;

        private void inroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (laterornow == true)
            {
                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from Rooms where Roomid=490569";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public bool laterornow;
          

      
        private void inroom_Load(object sender, EventArgs e)
        {            
            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Database/GamingApp.s3db;Version=3;");

            con.Open();
            cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Rooms where Roomid=" + Roomsid.Text;

            SQLiteDataReader roomdata = cmd.ExecuteReader();
            while (roomdata.Read())
                while (roomdata.Read()) {
                User1.Text = roomdata[0].ToString();
                User2.Text = roomdata[1].ToString();
                User3.Text = roomdata[2].ToString();
                User4.Text = roomdata[3].ToString();
                
               /* RoomTitle.Text = roomdata[7].ToString();
                Gamename.Text = roomdata[8].ToString();
                roomid = roomdata[0].ToString();*/

            }
            con.Close();
        }

        private void BacktoRooms_Click(object sender, EventArgs e)
        {
            
            Form Rooms = new Rooms();
            if (laterornow == true)
            {
                cmd =new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from Rooms where Roomid=" + roomid;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            this.Close();
            Rooms.Show();
        }
    }
}
