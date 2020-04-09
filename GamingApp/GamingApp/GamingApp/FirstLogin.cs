using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingApp
{
    public partial class FirstLogin : Form
    {
        public FirstLogin()
        {
            InitializeComponent();
        }

        private void FirstLogin_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            Random random = new Random();
            int sayi = random.Next(1, 3);
            if (sayi == 1)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Firstlogin/coop.jfif");
                pictureBox2.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Firstlogin/Multiplayer.jpg");
            }
            if (sayi == 2)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Firstlogin/borderlandscoop.jpg");
                pictureBox2.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Firstlogin/Multiplayercsgo.jpg");
            }
            pictureBox3.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Firstlogin/fps.jpg");
            pictureBox4.Image = Image.FromFile("C:/Users/orcun/Desktop/GamingApp/GamingApp/GamingApp/Images/Firstlogin/tps.jpg");

        }
    }
}
