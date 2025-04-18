namespace Punisher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBaşlat = new Button();
            menuAnaMenu = new MenuStrip();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            güncellemeleriKontrolEtToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            chkboxÇöpKutusuTemizle = new CheckBox();
            chkboxTarayıcılarıTemizle = new CheckBox();
            button1 = new Button();
            richTbxLog = new RichTextBox();
            textBox1 = new TextBox();
            menuAnaMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnBaşlat
            // 
            btnBaşlat.Location = new Point(240, 227);
            btnBaşlat.Name = "btnBaşlat";
            btnBaşlat.Size = new Size(115, 39);
            btnBaşlat.TabIndex = 1;
            btnBaşlat.Text = "Başlat";
            btnBaşlat.UseVisualStyleBackColor = true;
            btnBaşlat.Click += btnBaşlat_Click;
            // 
            // menuAnaMenu
            // 
            menuAnaMenu.ImageScalingSize = new Size(20, 20);
            menuAnaMenu.Items.AddRange(new ToolStripItem[] { ayarlarToolStripMenuItem });
            menuAnaMenu.Location = new Point(0, 0);
            menuAnaMenu.Name = "menuAnaMenu";
            menuAnaMenu.Size = new Size(367, 28);
            menuAnaMenu.TabIndex = 2;
            menuAnaMenu.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { güncellemeleriKontrolEtToolStripMenuItem, hakkımızdaToolStripMenuItem });
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(70, 24);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // güncellemeleriKontrolEtToolStripMenuItem
            // 
            güncellemeleriKontrolEtToolStripMenuItem.Name = "güncellemeleriKontrolEtToolStripMenuItem";
            güncellemeleriKontrolEtToolStripMenuItem.Size = new Size(261, 26);
            güncellemeleriKontrolEtToolStripMenuItem.Text = "Güncellemeleri Kontrol Et";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(261, 26);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // chkboxÇöpKutusuTemizle
            // 
            chkboxÇöpKutusuTemizle.AutoSize = true;
            chkboxÇöpKutusuTemizle.Location = new Point(12, 85);
            chkboxÇöpKutusuTemizle.Name = "chkboxÇöpKutusuTemizle";
            chkboxÇöpKutusuTemizle.Size = new Size(167, 24);
            chkboxÇöpKutusuTemizle.TabIndex = 3;
            chkboxÇöpKutusuTemizle.Text = "Çöp Kutusunu Boşalt";
            chkboxÇöpKutusuTemizle.UseVisualStyleBackColor = true;
            // 
            // chkboxTarayıcılarıTemizle
            // 
            chkboxTarayıcılarıTemizle.AutoSize = true;
            chkboxTarayıcılarıTemizle.Location = new Point(12, 115);
            chkboxTarayıcılarıTemizle.Name = "chkboxTarayıcılarıTemizle";
            chkboxTarayıcılarıTemizle.Size = new Size(160, 24);
            chkboxTarayıcılarıTemizle.TabIndex = 3;
            chkboxTarayıcılarıTemizle.Text = "Tarayacıları Temizle";
            chkboxTarayıcılarıTemizle.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 237);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTbxLog
            // 
            richTbxLog.Location = new Point(12, 272);
            richTbxLog.Name = "richTbxLog";
            richTbxLog.Size = new Size(343, 258);
            richTbxLog.TabIndex = 5;
            richTbxLog.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 542);
            Controls.Add(textBox1);
            Controls.Add(richTbxLog);
            Controls.Add(button1);
            Controls.Add(chkboxTarayıcılarıTemizle);
            Controls.Add(chkboxÇöpKutusuTemizle);
            Controls.Add(menuAnaMenu);
            Controls.Add(btnBaşlat);
            MainMenuStrip = menuAnaMenu;
            Name = "Form1";
            Text = "Punisher";
            menuAnaMenu.ResumeLayout(false);
            menuAnaMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBaşlat;
        private MenuStrip menuAnaMenu;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem güncellemeleriKontrolEtToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private CheckBox chkboxÇöpKutusuTemizle;
        private CheckBox chkboxTarayıcılarıTemizle;
        private Button button1;
        private RichTextBox richTbxLog;
        private TextBox textBox1;
    }
}
