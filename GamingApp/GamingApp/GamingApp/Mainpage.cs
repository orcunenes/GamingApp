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
    public partial class Mainpage : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteCommand cmd2,posts;
        string[] Username = new string[888];
        string[] Message = new string[888];
        string[] Date = new string[888];
        int postcount;
        string user;
        public string OnlineUsername;

        public Mainpage()
        {
            InitializeComponent();
            
        }

        
        private void getposts(string gamename)
        {
            
             postcount = 0;
            con.Open();
            //////////////////POST COUNT/////////////////////////
            posts = new SQLiteCommand();
            posts.Connection = con;
            posts.CommandText = "SELECT User FROM '"+gamename+"'";
            SQLiteDataReader postread = posts.ExecuteReader();
            while (postread.Read())
            {
                postcount++;

            }
            //////////////////////////////
            cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = "select User,Message,Time from '"+gamename+"'";
            cmd.ExecuteNonQuery();
            SQLiteDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {

                Username[i] = reader[0].ToString();
                Message[i] = reader[1].ToString();
                Date[i] = reader[2].ToString();


                i++;
            }
            con.Close();
            User1.Text = Username[postcount - 1];
            Message1.Text = Message[postcount - 1];
            Date1.Text = Date[postcount - 1];



            User2.Text = Username[postcount - 2];
            Message2.Text = Message[postcount - 2];
            Date2.Text = Date[postcount - 2];



            User3.Text = Username[postcount - 3];
            Message3.Text = Message[postcount - 3];
            Date3.Text = Date[postcount - 3];
        }

        
        private void Mainpage_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Database/GamingApp.s3db;Version=3;");
            con.Open();

           
            con.Close();
            getposts("CSGO");


            label2.Text = postcount.ToString() ;


            user = geldi.Text;




            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Firstlogin/Multiplayercsgo.jpg");


        }









        private void send_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand();
            cmd2 = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd2.Connection = con;
            cmd.CommandText = "insert into "+Gamename.SelectedItem+"(User,Message,Time) values ('" + OnlineUsername + "','" + UserMessage.Text + "','" + DateTime.Now.ToString("HH;mm")+ "')";
            cmd.ExecuteNonQuery();
            con.Close();
            postcount++;

            getposts(Gamename.SelectedItem.ToString());
        }

        

        private void CSGO_Click(object sender, EventArgs e)
        {
            getposts("CSGO");
            pictureBox1.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Firstlogin/Multiplayercsgo.jpg");

        }



        private void LoL_Click(object sender, EventArgs e)
        {
            getposts("LoL");
            pictureBox1.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Firstlogin/LeagueofLegends.jpg");

        }
        private void Rooms_Click(object sender, EventArgs e)
        {
            Rooms Rooms = new Rooms();
            Rooms.Onlineusername = OnlineUsername;

            this.Close();

            Rooms.Show();
        }
    }
}
