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
    public partial class Rooms : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        public Rooms()
        {
            InitializeComponent();
        }
        string[] Roomtitles = new string[9];
        string[] Gamenames = new string[9];
        string[] RoomAdmins = new string[9];
        string[] Times = new string[9];
        string[] Roomids = new string[9];


        int i = 0;

        private void EnterRoom_Click(object sender, EventArgs e)
        {

        }


        public string Onlineusername;

        public void refreshrooms(int roomnumber)
        {

          //////////////ROOM1///////////////////
            
                Title1.Text = Roomtitles[roomnumber];
                Gamename1.Text = Gamenames[roomnumber];
                Time1.Text = Times[roomnumber];
                User1.Text = RoomAdmins[roomnumber];
            
             //////////////ROOM2///////////////////
           
               Title2.Text = Roomtitles[roomnumber+1];
               Gamename2.Text = Gamenames[roomnumber+1];
               Time2.Text = Times[roomnumber+1];
                User2.Text = RoomAdmins[roomnumber+1];


            //////////////ROOM3///////////////////

                Title3.Text = Roomtitles[roomnumber+2];
               Gamename3.Text = Gamenames[roomnumber + 2];
               Time3.Text = Times[roomnumber + 2];
                User3.Text = RoomAdmins[roomnumber+2];


            //////////////ROOM4///////////////////
                Title4.Text = Roomtitles[roomnumber + 3];
               Gamename4.Text = Gamenames[roomnumber + 3];
               Time4.Text = Times[roomnumber + 3];
            User4.Text = RoomAdmins[roomnumber+3];

            //////////////ROOM5///////////////////

            Title5.Text = Roomtitles[roomnumber + 4];
               Gamename5.Text = Gamenames[roomnumber + 4];
               Time5.Text = Times[roomnumber + 4];

           //////////////ROOM6///////////////////
           
               Title6.Text = Roomtitles[roomnumber + 5];
               Gamename6.Text = Gamenames[roomnumber + 5];
               Time6.Text = Times[roomnumber + 5];

            //////////////ROOM7///////////////////

               Title7.Text = Roomtitles[roomnumber + 6];
               Gamename7.Text = Gamenames[roomnumber + 6];
               Time7.Text = Times[roomnumber + 6];

            //////////////ROOM8///////////////////

               Title8.Text = Roomtitles[roomnumber + 7];
               Gamename8.Text = Gamenames[roomnumber + 7];
               Time8.Text = Times[roomnumber + 7];

            //////////////ROOM9///////////////////

               Title9.Text = Roomtitles[roomnumber + 8];
               Gamename9.Text = Gamenames[roomnumber + 8];
               Time9.Text = Times[roomnumber + 8];


            //////////////ROOMEND///////////////////

        }
        private void Rooms_Load(object sender, EventArgs e)
        {
            
            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Database/GamingApp.s3db;Version=3;");
            con.Open();
            cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Rooms ";
            SQLiteDataReader roomread = cmd.ExecuteReader();
            while (roomread.Read())
            {
                Roomids[i] = roomread[0].ToString();
                RoomAdmins[i] = roomread[1].ToString();
                Roomtitles[i] = roomread[7].ToString();
                Gamenames[i] = roomread[8].ToString();

                i++;
            }

            con.Close();

            refreshrooms(0);
        }
        private void Create_Click(object sender, EventArgs e)
        {
            CreateRoom CreateRoom = new CreateRoom();
            CreateRoom.Onlineusername = Onlineusername;
            
            this.Close();
            CreateRoom.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form Mainpage = new Mainpage();
            Mainpage.Show();
        }


        private void insertplayer( int id)
        {
            string emptyplace="" ;
            con.Open();
            cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Player1,Player2,Player3,Player4 from Rooms where Roomid=" + Roomids[id];
            SQLiteDataReader readit = cmd.ExecuteReader();
            while (readit.Read())
            {

                if (Onlineusername == readit[0].ToString() || Onlineusername == readit[1].ToString() || Onlineusername == readit[2].ToString() || Onlineusername == readit[3].ToString())
                {
                    inroom inroom = new inroom();
                    inroom.roomid = Roomids[id].ToString();
                    inroom.Roomsid.Text = Roomids[id].ToString();
                    inroom.Show();
                    break;
                }
                else
                {
                    if (readit[0].ToString() == "")
                    {
                        emptyplace = "Player1";

                        break;
                    }
                    else if (readit[1].ToString() == "")
                    {
                        emptyplace = "Player2";

                        break;

                    }
                    else if (readit[2].ToString() == "")
                    {
                        emptyplace = "Player3";

                        break;

                    }
                    else if (readit[3].ToString() == "")
                    {
                        emptyplace = "Player4";

                        break;

                    }
                    else { emptyplace = ""; }


                }
            }
            
            if (emptyplace != "")
            {
                cmd = new SQLiteCommand("update Rooms set " + emptyplace + "=@name where Roomid=" + Roomids[id] ,con);
                cmd.Parameters.AddWithValue("@name", Onlineusername);
                cmd.ExecuteNonQuery();
                con.Close();
                inroom inroom = new inroom();
                inroom.roomid = id.ToString();
                inroom.Show();
            }
            else
            {
                MessageBox.Show("ODA DOLU");
                con.Close();
            }
            label6.Text = emptyplace;
        }

        private void Joinroom1_Click(object sender, EventArgs e)
        {
            insertplayer(0);
        }
        private void Joinroom2_Click(object sender, EventArgs e)
        {
            insertplayer(1);
        }
        private void Joinroom3_Click(object sender, EventArgs e)
        {
            insertplayer(2);
        }
        private void Joinroom4_Click(object sender, EventArgs e)
        {
            insertplayer(3);
        }
        private void Joinroom5_Click(object sender, EventArgs e)
        {
            insertplayer(4);
        }
        private void Joinroom6_Click(object sender, EventArgs e)
        {
            insertplayer(5);
        }
        private void Joinroom7_Click(object sender, EventArgs e)
        {
            insertplayer(6);
        }
        private void Joinroom8_Click(object sender, EventArgs e)
        {
            insertplayer(7);
        }
        private void Joinroom9_Click(object sender, EventArgs e)
        {
            insertplayer(8);
        }
    }
}
