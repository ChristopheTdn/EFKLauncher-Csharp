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
            button_locateSaveDiR = new Button();
            textBox_SaveDir = new TextBox();
            label_SaveGame = new Label();
            textBox_ProfilPZ = new TextBox();
            label_ProfilPZ = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox_PreInitEFK = new GroupBox();
            label3 = new Label();
            richTextBox_PreActivationTip = new RichTextBox();
            pictureBox2 = new PictureBox();
            radioButton_NoModif = new RadioButton();
            radioButton_EFKModPreInstall = new RadioButton();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage_EFKTab = new TabPage();
            richTextBox_Log = new RichTextBox();
            tabPage2 = new TabPage();
            button_WIPEMAP = new Button();
            checkBox_ActivateWipeMap = new CheckBox();
            pictureBox_TwitchLogo = new PictureBox();
            pictureBox_YoutubeLogo = new PictureBox();
            pictureBox_DiscordLogo = new PictureBox();
            label_VersionProgramme = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_EFKLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_Steam).BeginInit();
            groupBox_Repertoire.SuspendLayout();
            groupBox_PreInitEFK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage_EFKTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TwitchLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_YoutubeLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DiscordLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_EFKLogo
            // 
            pictureBox_EFKLogo.Image = Ressources.EFK_Ressources.EFK;
            pictureBox_EFKLogo.Location = new Point(11, 8);
            pictureBox_EFKLogo.Name = "pictureBox_EFKLogo";
            pictureBox_EFKLogo.Size = new Size(102, 97);
            pictureBox_EFKLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_EFKLogo.TabIndex = 0;
            pictureBox_EFKLogo.TabStop = false;
            // 
            // label_TitleEFKC
            // 
            label_TitleEFKC.AutoSize = true;
            label_TitleEFKC.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TitleEFKC.Location = new Point(107, 2);
            label_TitleEFKC.Name = "label_TitleEFKC";
            label_TitleEFKC.Size = new Size(275, 94);
            label_TitleEFKC.TabIndex = 1;
            label_TitleEFKC.Text = "ESCAPE FROM\r\nKNOX COUNTY";
            // 
            // label_CollectionSteam
            // 
            label_CollectionSteam.AutoSize = true;
            label_CollectionSteam.Cursor = Cursors.Hand;
            label_CollectionSteam.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_CollectionSteam.ForeColor = SystemColors.HotTrack;
            label_CollectionSteam.Location = new Point(86, 133);
            label_CollectionSteam.Name = "label_CollectionSteam";
            label_CollectionSteam.Size = new Size(485, 25);
            label_CollectionSteam.TabIndex = 2;
            label_CollectionSteam.Text = "ESCAPE FROM KNOX COUNTY Steam Collection (link)";
            label_CollectionSteam.TextAlign = ContentAlignment.MiddleCenter;
            label_CollectionSteam.Click += label_CollectionSteam_Click;
            // 
            // picture_Steam
            // 
            picture_Steam.Image = Ressources.EFK_Ressources.Steam_Icon;
            picture_Steam.Location = new Point(16, 111);
            picture_Steam.Name = "picture_Steam";
            picture_Steam.Size = new Size(64, 64);
            picture_Steam.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_Steam.TabIndex = 3;
            picture_Steam.TabStop = false;
            // 
            // button_LaunchPZ
            // 
            button_LaunchPZ.BackgroundImageLayout = ImageLayout.None;
            button_LaunchPZ.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_LaunchPZ.Image = Ressources.EFK_Ressources.pz;
            button_LaunchPZ.ImageAlign = ContentAlignment.MiddleLeft;
            button_LaunchPZ.Location = new Point(460, 12);
            button_LaunchPZ.Name = "button_LaunchPZ";
            button_LaunchPZ.Size = new Size(148, 50);
            button_LaunchPZ.TabIndex = 4;
            button_LaunchPZ.Text = "Launch PZ";
            button_LaunchPZ.TextAlign = ContentAlignment.MiddleRight;
            button_LaunchPZ.UseVisualStyleBackColor = true;
            button_LaunchPZ.Click += button_LaunchPZ_Click;
            // 
            // checkBox_DebugMode
            // 
            checkBox_DebugMode.AutoSize = true;
            checkBox_DebugMode.Location = new Point(482, 68);
            checkBox_DebugMode.Name = "checkBox_DebugMode";
            checkBox_DebugMode.Size = new Size(95, 19);
            checkBox_DebugMode.TabIndex = 5;
            checkBox_DebugMode.Text = "Debug Mode";
            checkBox_DebugMode.UseVisualStyleBackColor = true;
            checkBox_DebugMode.CheckedChanged += checkBox_DebugMode_CheckedChanged;
            // 
            // groupBox_Repertoire
            // 
            groupBox_Repertoire.Controls.Add(button_locateSaveDiR);
            groupBox_Repertoire.Controls.Add(textBox_SaveDir);
            groupBox_Repertoire.Controls.Add(label_SaveGame);
            groupBox_Repertoire.Controls.Add(textBox_ProfilPZ);
            groupBox_Repertoire.Controls.Add(label_ProfilPZ);
            groupBox_Repertoire.Location = new Point(11, 197);
            groupBox_Repertoire.Name = "groupBox_Repertoire";
            groupBox_Repertoire.Size = new Size(598, 99);
            groupBox_Repertoire.TabIndex = 6;
            groupBox_Repertoire.TabStop = false;
            groupBox_Repertoire.Text = "User Directories";
            // 
            // button_locateSaveDiR
            // 
            button_locateSaveDiR.Location = new Point(471, 60);
            button_locateSaveDiR.Name = "button_locateSaveDiR";
            button_locateSaveDiR.Size = new Size(84, 23);
            button_locateSaveDiR.TabIndex = 4;
            button_locateSaveDiR.Text = "Find";
            button_locateSaveDiR.UseVisualStyleBackColor = true;
            button_locateSaveDiR.Click += button_locateSaveDiR_Click;
            // 
            // textBox_SaveDir
            // 
            textBox_SaveDir.BackColor = SystemColors.ButtonHighlight;
            textBox_SaveDir.Location = new Point(96, 61);
            textBox_SaveDir.Name = "textBox_SaveDir";
            textBox_SaveDir.ReadOnly = true;
            textBox_SaveDir.Size = new Size(351, 23);
            textBox_SaveDir.TabIndex = 3;
            textBox_SaveDir.TextChanged += textBox_SaveDir_TextChanged;
            // 
            // label_SaveGame
            // 
            label_SaveGame.AutoSize = true;
            label_SaveGame.Location = new Point(19, 64);
            label_SaveGame.Name = "label_SaveGame";
            label_SaveGame.Size = new Size(71, 15);
            label_SaveGame.TabIndex = 2;
            label_SaveGame.Text = "Save Game :";
            label_SaveGame.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_ProfilPZ
            // 
            textBox_ProfilPZ.BackColor = SystemColors.ButtonHighlight;
            textBox_ProfilPZ.Location = new Point(96, 26);
            textBox_ProfilPZ.Name = "textBox_ProfilPZ";
            textBox_ProfilPZ.ReadOnly = true;
            textBox_ProfilPZ.Size = new Size(351, 23);
            textBox_ProfilPZ.TabIndex = 1;
            // 
            // label_ProfilPZ
            // 
            label_ProfilPZ.AutoSize = true;
            label_ProfilPZ.Location = new Point(32, 29);
            label_ProfilPZ.Name = "label_ProfilPZ";
            label_ProfilPZ.Size = new Size(58, 15);
            label_ProfilPZ.TabIndex = 0;
            label_ProfilPZ.Text = "Profil PZ :";
            label_ProfilPZ.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox_PreInitEFK
            // 
            groupBox_PreInitEFK.Controls.Add(label3);
            groupBox_PreInitEFK.Controls.Add(richTextBox_PreActivationTip);
            groupBox_PreInitEFK.Controls.Add(pictureBox2);
            groupBox_PreInitEFK.Controls.Add(radioButton_NoModif);
            groupBox_PreInitEFK.Controls.Add(radioButton_EFKModPreInstall);
            groupBox_PreInitEFK.Controls.Add(pictureBox1);
            groupBox_PreInitEFK.Location = new Point(11, 305);
            groupBox_PreInitEFK.Name = "groupBox_PreInitEFK";
            groupBox_PreInitEFK.Size = new Size(598, 78);
            groupBox_PreInitEFK.TabIndex = 7;
            groupBox_PreInitEFK.TabStop = false;
            groupBox_PreInitEFK.Text = "Pre Select EFK in PZ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(304, 19);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 17;
            label3.Text = "IMPORTANT  : ";
            // 
            // richTextBox_PreActivationTip
            // 
            richTextBox_PreActivationTip.BackColor = SystemColors.Control;
            richTextBox_PreActivationTip.BorderStyle = BorderStyle.None;
            richTextBox_PreActivationTip.ForeColor = SystemColors.WindowText;
            richTextBox_PreActivationTip.ImeMode = ImeMode.On;
            richTextBox_PreActivationTip.Location = new Point(300, 37);
            richTextBox_PreActivationTip.Name = "richTextBox_PreActivationTip";
            richTextBox_PreActivationTip.Size = new Size(288, 32);
            richTextBox_PreActivationTip.TabIndex = 3;
            richTextBox_PreActivationTip.Text = "Choose \"no mods inits\" ONLY  if you want to activate manually MODS (no support for this choice).";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Ressources.EFK_Ressources.accolade;
            pictureBox2.Location = new Point(284, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(14, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // radioButton_NoModif
            // 
            radioButton_NoModif.AutoSize = true;
            radioButton_NoModif.Location = new Point(80, 45);
            radioButton_NoModif.Name = "radioButton_NoModif";
            radioButton_NoModif.Size = new Size(198, 19);
            radioButton_NoModif.TabIndex = 1;
            radioButton_NoModif.TabStop = true;
            radioButton_NoModif.Text = "No Mods init (for Modders Only)";
            radioButton_NoModif.UseVisualStyleBackColor = true;
            radioButton_NoModif.CheckedChanged += radioButton_NoModif_CheckedChanged;
            // 
            // radioButton_EFKModPreInstall
            // 
            radioButton_EFKModPreInstall.AutoSize = true;
            radioButton_EFKModPreInstall.Location = new Point(80, 22);
            radioButton_EFKModPreInstall.Name = "radioButton_EFKModPreInstall";
            radioButton_EFKModPreInstall.Size = new Size(207, 19);
            radioButton_EFKModPreInstall.TabIndex = 1;
            radioButton_EFKModPreInstall.TabStop = true;
            radioButton_EFKModPreInstall.Text = " MODS  Escape From Knox County";
            radioButton_EFKModPreInstall.UseVisualStyleBackColor = true;
            radioButton_EFKModPreInstall.CheckedChanged += radioButton_EFKModPreInstall_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Ressources.EFK_Ressources.performance;
            pictureBox1.Location = new Point(19, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_EFKTab);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 383);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(598, 249);
            tabControl1.TabIndex = 8;
            // 
            // tabPage_EFKTab
            // 
            tabPage_EFKTab.BackColor = SystemColors.Control;
            tabPage_EFKTab.Controls.Add(richTextBox_Log);
            tabPage_EFKTab.Location = new Point(4, 24);
            tabPage_EFKTab.Name = "tabPage_EFKTab";
            tabPage_EFKTab.Padding = new Padding(3);
            tabPage_EFKTab.Size = new Size(590, 221);
            tabPage_EFKTab.TabIndex = 0;
            tabPage_EFKTab.Text = "Log";
            // 
            // richTextBox_Log
            // 
            richTextBox_Log.Location = new Point(6, 7);
            richTextBox_Log.Name = "richTextBox_Log";
            richTextBox_Log.Size = new Size(578, 208);
            richTextBox_Log.TabIndex = 0;
            richTextBox_Log.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(590, 221);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "About";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_WIPEMAP
            // 
            button_WIPEMAP.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_WIPEMAP.Location = new Point(60, 634);
            button_WIPEMAP.Name = "button_WIPEMAP";
            button_WIPEMAP.Size = new Size(201, 51);
            button_WIPEMAP.TabIndex = 9;
            button_WIPEMAP.Text = "WIPE MAP";
            button_WIPEMAP.UseVisualStyleBackColor = true;
            button_WIPEMAP.Click += button_WIPEMAP_Click;
            // 
            // checkBox_ActivateWipeMap
            // 
            checkBox_ActivateWipeMap.AutoSize = true;
            checkBox_ActivateWipeMap.Enabled = false;
            checkBox_ActivateWipeMap.Image = Ressources.EFK_Ressources.danger;
            checkBox_ActivateWipeMap.Location = new Point(60, 691);
            checkBox_ActivateWipeMap.Name = "checkBox_ActivateWipeMap";
            checkBox_ActivateWipeMap.Size = new Size(201, 35);
            checkBox_ActivateWipeMap.TabIndex = 10;
            checkBox_ActivateWipeMap.Text = "Unlock  Wipe Map Bouton";
            checkBox_ActivateWipeMap.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkBox_ActivateWipeMap.UseVisualStyleBackColor = true;
            checkBox_ActivateWipeMap.CheckedChanged += checkBox_ActivateWipeMap_CheckedChanged;
            // 
            // pictureBox_TwitchLogo
            // 
            pictureBox_TwitchLogo.Cursor = Cursors.Hand;
            pictureBox_TwitchLogo.Image = Ressources.EFK_Ressources.Twitch_logo;
            pictureBox_TwitchLogo.Location = new Point(119, 99);
            pictureBox_TwitchLogo.Name = "pictureBox_TwitchLogo";
            pictureBox_TwitchLogo.Size = new Size(22, 22);
            pictureBox_TwitchLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_TwitchLogo.TabIndex = 11;
            pictureBox_TwitchLogo.TabStop = false;
            pictureBox_TwitchLogo.Click += pictureBox_TwitchLogo_Click;
            // 
            // pictureBox_YoutubeLogo
            // 
            pictureBox_YoutubeLogo.Cursor = Cursors.Hand;
            pictureBox_YoutubeLogo.Image = Ressources.EFK_Ressources.youtube;
            pictureBox_YoutubeLogo.Location = new Point(147, 99);
            pictureBox_YoutubeLogo.Name = "pictureBox_YoutubeLogo";
            pictureBox_YoutubeLogo.Size = new Size(32, 22);
            pictureBox_YoutubeLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_YoutubeLogo.TabIndex = 12;
            pictureBox_YoutubeLogo.TabStop = false;
            pictureBox_YoutubeLogo.Click += pictureBox_YoutubeLogo_Click;
            // 
            // pictureBox_DiscordLogo
            // 
            pictureBox_DiscordLogo.Cursor = Cursors.Hand;
            pictureBox_DiscordLogo.Image = Ressources.EFK_Ressources.discord;
            pictureBox_DiscordLogo.Location = new Point(185, 99);
            pictureBox_DiscordLogo.Name = "pictureBox_DiscordLogo";
            pictureBox_DiscordLogo.Size = new Size(32, 22);
            pictureBox_DiscordLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_DiscordLogo.TabIndex = 13;
            pictureBox_DiscordLogo.TabStop = false;
            pictureBox_DiscordLogo.Click += pictureBox_DiscordLogo_Click;
            // 
            // label_VersionProgramme
            // 
            label_VersionProgramme.AutoSize = true;
            label_VersionProgramme.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_VersionProgramme.Location = new Point(306, 104);
            label_VersionProgramme.Name = "label_VersionProgramme";
            label_VersionProgramme.Size = new Size(58, 17);
            label_VersionProgramme.TabIndex = 14;
            label_VersionProgramme.Text = "v. 1.0.0.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(91, 158);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 15;
            label1.Text = "IMPORTANT  : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(175, 158);
            label2.Name = "label2";
            label2.Size = new Size(265, 15);
            label2.TabIndex = 16;
            label2.Text = "Subscribing to this collection is a must to play EFK";
            // 
            // FenetrePrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 726);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox_EFKLogo);
            Controls.Add(label_VersionProgramme);
            Controls.Add(pictureBox_DiscordLogo);
            Controls.Add(pictureBox_YoutubeLogo);
            Controls.Add(pictureBox_TwitchLogo);
            Controls.Add(checkBox_ActivateWipeMap);
            Controls.Add(button_WIPEMAP);
            Controls.Add(tabControl1);
            Controls.Add(groupBox_PreInitEFK);
            Controls.Add(groupBox_Repertoire);
            Controls.Add(checkBox_DebugMode);
            Controls.Add(button_LaunchPZ);
            Controls.Add(picture_Steam);
            Controls.Add(label_CollectionSteam);
            Controls.Add(label_TitleEFKC);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FenetrePrincipale";
            Text = "EFK Launcher";
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
        private Button button_locateSaveDiR;
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
        private Button button_WIPEMAP;
        private CheckBox checkBox_ActivateWipeMap;
        private PictureBox pictureBox_TwitchLogo;
        private PictureBox pictureBox_YoutubeLogo;
        private PictureBox pictureBox_DiscordLogo;
        private Label label_VersionProgramme;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox textBox_ProfilPZ;
    }
}
