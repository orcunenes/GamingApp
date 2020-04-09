using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace GamingApp
{
    public partial class Giris : Form
    {
      
        SQLiteConnection con;


        SQLiteCommand cmd;
        SQLiteCommand cmd2, posts;
        
        public Giris()
        {
            InitializeComponent();
        }
       
        private void Giris_Load(object sender, EventArgs e)
        {

            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Database/GamingApp.s3db;Version=3;");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Random random = new Random();
            int sayi = random.Next(1, 3);
            if (sayi == 1)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Loginregister/gamingimg1.jfif");

            }
            if (sayi == 2)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Loginregister/gamingimg2.jpg");

            }
            if (sayi == 3)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Loginregister/gamingimg2.jpg");

            }
        }
        private void Kayıtol_Click(object sender, EventArgs e)
        {
            Form kayitol = new Kayitol();
            kayitol.Show();
        }

        

        private void Login_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Username,Password From Users";
            SQLiteDataReader Kayitoku = cmd.ExecuteReader();
            while (Kayitoku.Read())
            {
                if (Username.Text == Kayitoku[0].ToString() && Password.Text == Kayitoku[1].ToString())
                {
                    Mainpage Mainpage = new Mainpage();
                    Mainpage.OnlineUsername = Username.Text;

                    Mainpage.Show();                    

                    MessageBox.Show("Giriş Başarılı Partiye Hoşgeldiniz!! :)");
                        
                        
                       
                        
                }  


    }
            
            con.Close();
            
        }


    }
}
