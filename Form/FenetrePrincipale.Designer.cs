namespace EFKLauncher
{
    partial class FenetrePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            pictureBox_EFKLogo = new PictureBox();
            label_TitleEFKC = new Label();
            label_CollectionSteam = new Label();
            picture_Steam = new PictureBox();
            button_LaunchPZ = new Button();
            checkBox_DebugMode = new CheckBox();
            groupBox_Repertoire = new GroupBox();
            textBox_SaveDir = new TextBox();
            label_SaveGame = new Label();
            textBox_ProfilPZ = new TextBox();
            label_ProfilPZ = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox_PreInitEFK = new GroupBox();
            label_Important = new Label();
            richTextBox_PreActivationTip = new RichTextBox();
            pictureBox2 = new PictureBox();
            radioButton_NoModif = new RadioButton();
            radioButton_EFKModPreInstall = new RadioButton();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage_EFKTab = new TabPage();
            richTextBox_Log = new RichTextBox();
            tabPage2 = new TabPage();
            pictureBox6 = new PictureBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            pictureBox7 = new PictureBox();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label11 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label6 = new Label();
            label12 = new Label();
            label8 = new Label();
            label5 = new Label();
            pictureBox_TwitchLogo = new PictureBox();
            pictureBox_YoutubeLogo = new PictureBox();
            pictureBox_DiscordLogo = new PictureBox();
            label_VersionProgramme = new Label();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox_EFKLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_Steam).BeginInit();
            groupBox_Repertoire.SuspendLayout();
            groupBox_PreInitEFK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage_EFKTab.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TwitchLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_YoutubeLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DiscordLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_EFKLogo
            // 
            pictureBox_EFKLogo.Image = Ressources.EFK_Ressources.EFK;
            resources.ApplyResources(pictureBox_EFKLogo, "pictureBox_EFKLogo");
            pictureBox_EFKLogo.Name = "pictureBox_EFKLogo";
            pictureBox_EFKLogo.TabStop = false;
            // 
            // label_TitleEFKC
            // 
            resources.ApplyResources(label_TitleEFKC, "label_TitleEFKC");
            label_TitleEFKC.Name = "label_TitleEFKC";
            // 
            // label_CollectionSteam
            // 
            resources.ApplyResources(label_CollectionSteam, "label_CollectionSteam");
            label_CollectionSteam.Cursor = Cursors.Hand;
            label_CollectionSteam.ForeColor = SystemColors.HotTrack;
            label_CollectionSteam.Name = "label_CollectionSteam";
            label_CollectionSteam.Click += label_CollectionSteam_Click;
            // 
            // picture_Steam
            // 
            picture_Steam.Image = Ressources.EFK_Ressources.Steam_Icon;
            resources.ApplyResources(picture_Steam, "picture_Steam");
            picture_Steam.Name = "picture_Steam";
            picture_Steam.TabStop = false;
            // 
            // button_LaunchPZ
            // 
            resources.ApplyResources(button_LaunchPZ, "button_LaunchPZ");
            button_LaunchPZ.Image = Ressources.EFK_Ressources.pz;
            button_LaunchPZ.Name = "button_LaunchPZ";
            button_LaunchPZ.UseVisualStyleBackColor = true;
            button_LaunchPZ.Click += button_LaunchPZ_Click;
            // 
            // checkBox_DebugMode
            // 
            resources.ApplyResources(checkBox_DebugMode, "checkBox_DebugMode");
            checkBox_DebugMode.Name = "checkBox_DebugMode";
            checkBox_DebugMode.UseVisualStyleBackColor = true;
            checkBox_DebugMode.CheckedChanged += checkBox_DebugMode_CheckedChanged;
            // 
            // groupBox_Repertoire
            // 
            groupBox_Repertoire.Controls.Add(textBox_SaveDir);
            groupBox_Repertoire.Controls.Add(label_SaveGame);
            groupBox_Repertoire.Controls.Add(textBox_ProfilPZ);
            groupBox_Repertoire.Controls.Add(label_ProfilPZ);
            resources.ApplyResources(groupBox_Repertoire, "groupBox_Repertoire");
            groupBox_Repertoire.Name = "groupBox_Repertoire";
            groupBox_Repertoire.TabStop = false;
            // 
            // textBox_SaveDir
            // 
            textBox_SaveDir.BackColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(textBox_SaveDir, "textBox_SaveDir");
            textBox_SaveDir.Name = "textBox_SaveDir";
            textBox_SaveDir.ReadOnly = true;
            textBox_SaveDir.TextChanged += textBox_SaveDir_TextChanged;
            // 
            // label_SaveGame
            // 
            resources.ApplyResources(label_SaveGame, "label_SaveGame");
            label_SaveGame.Name = "label_SaveGame";
            // 
            // textBox_ProfilPZ
            // 
            textBox_ProfilPZ.BackColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(textBox_ProfilPZ, "textBox_ProfilPZ");
            textBox_ProfilPZ.Name = "textBox_ProfilPZ";
            textBox_ProfilPZ.ReadOnly = true;
            // 
            // label_ProfilPZ
            // 
            resources.ApplyResources(label_ProfilPZ, "label_ProfilPZ");
            label_ProfilPZ.Name = "label_ProfilPZ";
            // 
            // groupBox_PreInitEFK
            // 
            groupBox_PreInitEFK.Controls.Add(label_Important);
            groupBox_PreInitEFK.Controls.Add(richTextBox_PreActivationTip);
            groupBox_PreInitEFK.Controls.Add(pictureBox2);
            groupBox_PreInitEFK.Controls.Add(radioButton_NoModif);
            groupBox_PreInitEFK.Controls.Add(radioButton_EFKModPreInstall);
            groupBox_PreInitEFK.Controls.Add(pictureBox1);
            resources.ApplyResources(groupBox_PreInitEFK, "groupBox_PreInitEFK");
            groupBox_PreInitEFK.Name = "groupBox_PreInitEFK";
            groupBox_PreInitEFK.TabStop = false;
            // 
            // label_Important
            // 
            resources.ApplyResources(label_Important, "label_Important");
            label_Important.ForeColor = Color.Brown;
            label_Important.Name = "label_Important";
            // 
            // richTextBox_PreActivationTip
            // 
            richTextBox_PreActivationTip.BackColor = SystemColors.Control;
            richTextBox_PreActivationTip.BorderStyle = BorderStyle.None;
            richTextBox_PreActivationTip.ForeColor = SystemColors.WindowText;
            resources.ApplyResources(richTextBox_PreActivationTip, "richTextBox_PreActivationTip");
            richTextBox_PreActivationTip.Name = "richTextBox_PreActivationTip";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Ressources.EFK_Ressources.accolade;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // radioButton_NoModif
            // 
            resources.ApplyResources(radioButton_NoModif, "radioButton_NoModif");
            radioButton_NoModif.Name = "radioButton_NoModif";
            radioButton_NoModif.TabStop = true;
            radioButton_NoModif.UseVisualStyleBackColor = true;
            radioButton_NoModif.CheckedChanged += radioButton_NoModif_CheckedChanged;
            // 
            // radioButton_EFKModPreInstall
            // 
            resources.ApplyResources(radioButton_EFKModPreInstall, "radioButton_EFKModPreInstall");
            radioButton_EFKModPreInstall.Name = "radioButton_EFKModPreInstall";
            radioButton_EFKModPreInstall.TabStop = true;
            radioButton_EFKModPreInstall.UseVisualStyleBackColor = true;
            radioButton_EFKModPreInstall.CheckedChanged += radioButton_EFKModPreInstall_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Ressources.EFK_Ressources.performance;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_EFKTab);
            tabControl1.Controls.Add(tabPage2);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage_EFKTab
            // 
            tabPage_EFKTab.BackColor = SystemColors.Control;
            tabPage_EFKTab.Controls.Add(richTextBox_Log);
            resources.ApplyResources(tabPage_EFKTab, "tabPage_EFKTab");
            tabPage_EFKTab.Name = "tabPage_EFKTab";
            // 
            // richTextBox_Log
            // 
            resources.ApplyResources(richTextBox_Log, "richTextBox_Log");
            richTextBox_Log.Name = "richTextBox_Log";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(pictureBox6);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label5);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Ressources.EFK_Ressources.tof;
            resources.ApplyResources(pictureBox6, "pictureBox6");
            pictureBox6.Name = "pictureBox6";
            pictureBox6.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox7);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Ressources.EFK_Ressources.info;
            resources.ApplyResources(pictureBox7, "pictureBox7");
            pictureBox7.Name = "pictureBox7";
            pictureBox7.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Ressources.EFK_Ressources.tt;
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Ressources.EFK_Ressources.EFK;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Cursor = Cursors.Hand;
            label10.ForeColor = SystemColors.HotTrack;
            label10.Name = "label10";
            label10.Click += label_CollectionSteam_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Cursor = Cursors.Hand;
            label12.ForeColor = SystemColors.HotTrack;
            label12.Name = "label12";
            label12.Click += label_CollectionSteam_Click;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // pictureBox_TwitchLogo
            // 
            pictureBox_TwitchLogo.Cursor = Cursors.Hand;
            pictureBox_TwitchLogo.Image = Ressources.EFK_Ressources.Twitch_logo;
            resources.ApplyResources(pictureBox_TwitchLogo, "pictureBox_TwitchLogo");
            pictureBox_TwitchLogo.Name = "pictureBox_TwitchLogo";
            pictureBox_TwitchLogo.TabStop = false;
            pictureBox_TwitchLogo.Click += pictureBox_TwitchLogo_Click;
            // 
            // pictureBox_YoutubeLogo
            // 
            pictureBox_YoutubeLogo.Cursor = Cursors.Hand;
            pictureBox_YoutubeLogo.Image = Ressources.EFK_Ressources.youtube;
            resources.ApplyResources(pictureBox_YoutubeLogo, "pictureBox_YoutubeLogo");
            pictureBox_YoutubeLogo.Name = "pictureBox_YoutubeLogo";
            pictureBox_YoutubeLogo.TabStop = false;
            pictureBox_YoutubeLogo.Click += pictureBox_YoutubeLogo_Click;
            // 
            // pictureBox_DiscordLogo
            // 
            pictureBox_DiscordLogo.Cursor = Cursors.Hand;
            pictureBox_DiscordLogo.Image = Ressources.EFK_Ressources.discord;
            resources.ApplyResources(pictureBox_DiscordLogo, "pictureBox_DiscordLogo");
            pictureBox_DiscordLogo.Name = "pictureBox_DiscordLogo";
            pictureBox_DiscordLogo.TabStop = false;
            pictureBox_DiscordLogo.Click += pictureBox_DiscordLogo_Click;
            // 
            // label_VersionProgramme
            // 
            resources.ApplyResources(label_VersionProgramme, "label_VersionProgramme");
            label_VersionProgramme.Name = "label_VersionProgramme";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Brown;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FenetrePrincipale
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox_EFKLogo);
            Controls.Add(label_VersionProgramme);
            Controls.Add(pictureBox_DiscordLogo);
            Controls.Add(pictureBox_YoutubeLogo);
            Controls.Add(pictureBox_TwitchLogo);
            Controls.Add(tabControl1);
            Controls.Add(groupBox_PreInitEFK);
            Controls.Add(groupBox_Repertoire);
            Controls.Add(checkBox_DebugMode);
            Controls.Add(button_LaunchPZ);
            Controls.Add(picture_Steam);
            Controls.Add(label_CollectionSteam);
            Controls.Add(label_TitleEFKC);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FenetrePrincipale";
            Load += FenetrePrincipale_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_EFKLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_Steam).EndInit();
            groupBox_Repertoire.ResumeLayout(false);
            groupBox_Repertoire.PerformLayout();
            groupBox_PreInitEFK.ResumeLayout(false);
            groupBox_PreInitEFK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage_EFKTab.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TwitchLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_YoutubeLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DiscordLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_EFKLogo;
        private Label label_TitleEFKC;
        private Label label_CollectionSteam;
        private PictureBox picture_Steam;
        private Button button_LaunchPZ;
        public CheckBox checkBox_DebugMode;
        private GroupBox groupBox_Repertoire;
        private TextBox textBox_SaveDir;
        private Label label_SaveGame;
        private Label label_ProfilPZ;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox groupBox_PreInitEFK;
        private PictureBox pictureBox1;
        private RadioButton radioButton_EFKModPreInstall;
        private RadioButton radioButton_NoModif;
        private RichTextBox richTextBox_PreActivationTip;
        private PictureBox pictureBox2;
        private TabControl tabControl1;
        private TabPage tabPage_EFKTab;
        private TabPage tabPage2;
        public RichTextBox richTextBox_Log;
        private PictureBox pictureBox_TwitchLogo;
        private PictureBox pictureBox_YoutubeLogo;
        private PictureBox pictureBox_DiscordLogo;
        private Label label_VersionProgramme;
        private Label label1;
        private Label label2;
        private Label label_Important;
        public TextBox textBox_ProfilPZ;
        private OpenFileDialog openFileDialog1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox4;
        private GroupBox groupBox1;
        private Label label5;
        private Label label9;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label10;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox7;
    }
}
