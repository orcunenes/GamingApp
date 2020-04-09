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
    public partial class Kayitol : Form
    {
        SQLiteConnection con;

        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        SQLiteCommand cmd2, posts;
        DataSet ds;
        public Kayitol()
        {
            InitializeComponent();
        }

        private void Kayitol_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Random random = new Random();
            int sayi=random.Next(1, 3);
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





            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Database/GamingApp.s3db;Version=3;");

        }

        private void Kayitol_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Kayitol_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Users (Username,Password,Email) values ('" + Username.Text + "','" + Password.Text + "','" + Mail.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();



            Form firstlogin = new FirstLogin();
            firstlogin.Show();





        }
    }
}
