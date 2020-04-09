namespace GamingApp
{
    partial class Mainpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpage));
            this.label1 = new System.Windows.Forms.Label();
            this.UserMessage = new System.Windows.Forms.RichTextBox();
            this.CSGO = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.Gamename = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date1 = new System.Windows.Forms.Label();
            this.Message1 = new System.Windows.Forms.Label();
            this.User1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date2 = new System.Windows.Forms.Label();
            this.Message2 = new System.Windows.Forms.Label();
            this.User2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Date3 = new System.Windows.Forms.Label();
            this.Message3 = new System.Windows.Forms.Label();
            this.User3 = new System.Windows.Forms.Label();
            this.LoL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rooms = new System.Windows.Forms.Button();
            this.geldi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANASAYFA";
            // 
            // UserMessage
            // 
            this.UserMessage.Location = new System.Drawing.Point(176, 72);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(391, 85);
            this.UserMessage.TabIndex = 1;
            this.UserMessage.Text = "Share Something";
            // 
            // CSGO
            // 
            this.CSGO.Location = new System.Drawing.Point(20, 201);
            this.CSGO.Name = "CSGO";
            this.CSGO.Size = new System.Drawing.Size(117, 23);
            this.CSGO.TabIndex = 3;
            this.CSGO.Text = "CSGO";
            this.CSGO.UseVisualStyleBackColor = true;
            this.CSGO.Click += new System.EventHandler(this.CSGO_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(601, 134);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 4;
            this.send.Text = "Gönder";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Gamename
            // 
            this.Gamename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gamename.FormattingEnabled = true;
            this.Gamename.Items.AddRange(new object[] {
            "CSGO",
            "LoL"});
            this.Gamename.Location = new System.Drawing.Point(573, 101);
            this.Gamename.Name = "Gamename";
            this.Gamename.Size = new System.Drawing.Size(121, 21);
            this.Gamename.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Date1);
            this.panel1.Controls.Add(this.Message1);
            this.panel1.Controls.Add(this.User1);
            this.panel1.Location = new System.Drawing.Point(176, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 95);
            this.panel1.TabIndex = 6;
            // 
            // Date1
            // 
            this.Date1.AutoSize = true;
            this.Date1.Location = new System.Drawing.Point(294, 56);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(30, 13);
            this.Date1.TabIndex = 2;
            this.Date1.Text = "Date";
            // 
            // Message1
            // 
            this.Message1.AutoSize = true;
            this.Message1.Location = new System.Drawing.Point(38, 45);
            this.Message1.Name = "Message1";
            this.Message1.Size = new System.Drawing.Size(50, 13);
            this.Message1.TabIndex = 1;
            this.Message1.Text = "Message";
            // 
            // User1
            // 
            this.User1.AutoSize = true;
            this.User1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.User1.Location = new System.Drawing.Point(15, 13);
            this.User1.Name = "User1";
            this.User1.Size = new System.Drawing.Size(99, 18);
            this.User1.TabIndex = 0;
            this.User1.Text = "Kullanıcı Adı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Date2);
            this.panel2.Controls.Add(this.Message2);
            this.panel2.Controls.Add(this.User2);
            this.panel2.Location = new System.Drawing.Point(176, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 95);
            this.panel2.TabIndex = 7;
            // 
            // Date2
            // 
            this.Date2.AutoSize = true;
            this.Date2.Location = new System.Drawing.Point(294, 65);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(30, 13);
            this.Date2.TabIndex = 3;
            this.Date2.Text = "Date";
            // 
            // Message2
            // 
            this.Message2.AutoSize = true;
            this.Message2.Location = new System.Drawing.Point(38, 45);
            this.Message2.Name = "Message2";
            this.Message2.Size = new System.Drawing.Size(50, 13);
            this.Message2.TabIndex = 1;
            this.Message2.Text = "Message";
            // 
            // User2
            // 
            this.User2.AutoSize = true;
            this.User2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.User2.Location = new System.Drawing.Point(15, 13);
            this.User2.Name = "User2";
            this.User2.Size = new System.Drawing.Size(99, 18);
            this.User2.TabIndex = 0;
            this.User2.Text = "Kullanıcı Adı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Date3);
            this.panel3.Controls.Add(this.Message3);
            this.panel3.Controls.Add(this.User3);
            this.panel3.Location = new System.Drawing.Point(176, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 95);
            this.panel3.TabIndex = 7;
            // 
            // Date3
            // 
            this.Date3.AutoSize = true;
            this.Date3.Location = new System.Drawing.Point(294, 64);
            this.Date3.Name = "Date3";
            this.Date3.Size = new System.Drawing.Size(30, 13);
            this.Date3.TabIndex = 4;
            this.Date3.Text = "Date";
            // 
            // Message3
            // 
            this.Message3.AutoSize = true;
            this.Message3.Location = new System.Drawing.Point(38, 45);
            this.Message3.Name = "Message3";
            this.Message3.Size = new System.Drawing.Size(50, 13);
            this.Message3.TabIndex = 1;
            this.Message3.Text = "Message";
            // 
            // User3
            // 
            this.User3.AutoSize = true;
            this.User3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.User3.Location = new System.Drawing.Point(15, 13);
            this.User3.Name = "User3";
            this.User3.Size = new System.Drawing.Size(99, 18);
            this.User3.TabIndex = 0;
            this.User3.Text = "Kullanıcı Adı";
            // 
            // LoL
            // 
            this.LoL.Location = new System.Drawing.Point(20, 247);
            this.LoL.Name = "LoL";
            this.LoL.Size = new System.Drawing.Size(117, 23);
            this.LoL.TabIndex = 8;
            this.LoL.Text = "LoL";
            this.LoL.UseVisualStyleBackColor = true;
            this.LoL.Click += new System.EventHandler(this.LoL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Odalar";
            // 
            // Rooms
            // 
            this.Rooms.Location = new System.Drawing.Point(634, 214);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(85, 33);
            this.Rooms.TabIndex = 11;
            this.Rooms.Text = "Odalar";
            this.Rooms.UseVisualStyleBackColor = true;
            this.Rooms.Click += new System.EventHandler(this.Rooms_Click);
            // 
            // geldi
            // 
            this.geldi.AutoSize = true;
            this.geldi.Location = new System.Drawing.Point(641, 463);
            this.geldi.Name = "geldi";
            this.geldi.Size = new System.Drawing.Size(35, 13);
            this.geldi.TabIndex = 12;
            this.geldi.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 99);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(813, 656);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geldi);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoL);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gamename);
            this.Controls.Add(this.send);
            this.Controls.Add(this.CSGO);
            this.Controls.Add(this.UserMessage);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainpage";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.Mainpage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox UserMessage;
        private System.Windows.Forms.Button CSGO;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ComboBox Gamename;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Message1;
        private System.Windows.Forms.Label User1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Message2;
        private System.Windows.Forms.Label User2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Message3;
        private System.Windows.Forms.Label User3;
        private System.Windows.Forms.Button LoL;
        private System.Windows.Forms.Label Date1;
        private System.Windows.Forms.Label Date2;
        private System.Windows.Forms.Label Date3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Rooms;
        public System.Windows.Forms.Label geldi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}