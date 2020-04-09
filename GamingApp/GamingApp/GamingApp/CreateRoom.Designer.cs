namespace GamingApp
{
    partial class CreateRoom
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
            this.Roomtitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gamename = new System.Windows.Forms.TextBox();
            this.PlayerCount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SPLB = new System.Windows.Forms.Label();
            this.SpecialRoom = new System.Windows.Forms.CheckBox();
            this.Create = new System.Windows.Forms.Button();
            this.now = new System.Windows.Forms.CheckBox();
            this.later = new System.Windows.Forms.CheckBox();
            this.Hour = new System.Windows.Forms.ComboBox();
            this.Minute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Roomtitle
            // 
            this.Roomtitle.Location = new System.Drawing.Point(112, 88);
            this.Roomtitle.Name = "Roomtitle";
            this.Roomtitle.Size = new System.Drawing.Size(100, 20);
            this.Roomtitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oda Başlığı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oyun İsmi:";
            // 
            // Gamename
            // 
            this.Gamename.Location = new System.Drawing.Point(112, 119);
            this.Gamename.Name = "Gamename";
            this.Gamename.Size = new System.Drawing.Size(100, 20);
            this.Gamename.TabIndex = 3;
            // 
            // PlayerCount
            // 
            this.PlayerCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerCount.FormattingEnabled = true;
            this.PlayerCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.PlayerCount.Location = new System.Drawing.Point(114, 150);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(98, 21);
            this.PlayerCount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oyuncu Sayısı:";
            // 
            // SPLB
            // 
            this.SPLB.AutoSize = true;
            this.SPLB.Location = new System.Drawing.Point(34, 186);
            this.SPLB.Name = "SPLB";
            this.SPLB.Size = new System.Drawing.Size(51, 13);
            this.SPLB.TabIndex = 6;
            this.SPLB.Text = "Özel Oda";
            // 
            // SpecialRoom
            // 
            this.SpecialRoom.AutoSize = true;
            this.SpecialRoom.Location = new System.Drawing.Point(114, 186);
            this.SpecialRoom.Name = "SpecialRoom";
            this.SpecialRoom.Size = new System.Drawing.Size(15, 14);
            this.SpecialRoom.TabIndex = 7;
            this.SpecialRoom.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(137, 216);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 8;
            this.Create.Text = "Oluştur";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // now
            // 
            this.now.AutoSize = true;
            this.now.Checked = true;
            this.now.CheckState = System.Windows.Forms.CheckState.Checked;
            this.now.Location = new System.Drawing.Point(3, 5);
            this.now.Name = "now";
            this.now.Size = new System.Drawing.Size(51, 17);
            this.now.TabIndex = 9;
            this.now.Text = "Şimdi";
            this.now.UseVisualStyleBackColor = true;
            this.now.CheckedChanged += new System.EventHandler(this.now_CheckedChanged);
            // 
            // later
            // 
            this.later.AutoSize = true;
            this.later.Location = new System.Drawing.Point(79, 5);
            this.later.Name = "later";
            this.later.Size = new System.Drawing.Size(78, 17);
            this.later.TabIndex = 10;
            this.later.Text = "İleri Tarihte";
            this.later.UseVisualStyleBackColor = true;
            this.later.CheckedChanged += new System.EventHandler(this.later_CheckedChanged);
            // 
            // Hour
            // 
            this.Hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hour.Enabled = false;
            this.Hour.FormattingEnabled = true;
            this.Hour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.Hour.Location = new System.Drawing.Point(294, 145);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(46, 21);
            this.Hour.TabIndex = 12;
            // 
            // Minute
            // 
            this.Minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Minute.Enabled = false;
            this.Minute.FormattingEnabled = true;
            this.Minute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.Minute.Location = new System.Drawing.Point(364, 145);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(51, 21);
            this.Minute.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(346, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = ":";
            // 
            // Day
            // 
            this.Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day.Enabled = false;
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.Day.Location = new System.Drawing.Point(294, 118);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(121, 21);
            this.Day.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gün";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Saat";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.now);
            this.panel1.Controls.Add(this.later);
            this.panel1.Location = new System.Drawing.Point(258, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 29);
            this.panel1.TabIndex = 18;
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.SpecialRoom);
            this.Controls.Add(this.SPLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerCount);
            this.Controls.Add(this.Gamename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Roomtitle);
            this.Name = "CreateRoom";
            this.Text = "CreateRoom";
            this.Load += new System.EventHandler(this.CreateRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Roomtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Gamename;
        private System.Windows.Forms.ComboBox PlayerCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SPLB;
        private System.Windows.Forms.CheckBox SpecialRoom;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.CheckBox now;
        private System.Windows.Forms.CheckBox later;
        private System.Windows.Forms.ComboBox Hour;
        private System.Windows.Forms.ComboBox Minute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.Panel panel1;
    }
}