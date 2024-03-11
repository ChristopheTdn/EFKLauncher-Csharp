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
            button_WIPEMAP = new Button();
            checkBox_ActivateWipeMap = new CheckBox();
            pictureBox_TwitchLogo = new PictureBox();
            pictureBox_YoutubeLogo = new PictureBox();
            pictureBox_DiscordLogo = new PictureBox();
            label_VersionProgramme = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label_Important_2 = new Label();
            richTextBox_WIPEMAP_TIP = new RichTextBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            groupBox_Repertoire.Controls.Add(button_locateSaveDiR);
            groupBox_Repertoire.Controls.Add(textBox_SaveDir);
            groupBox_Repertoire.Controls.Add(label_SaveGame);
            groupBox_Repertoire.Controls.Add(textBox_ProfilPZ);
            groupBox_Repertoire.Controls.Add(label_ProfilPZ);
            resources.ApplyResources(groupBox_Repertoire, "groupBox_Repertoire");
            groupBox_Repertoire.Name = "groupBox_Repertoire";
            groupBox_Repertoire.TabStop = false;
            // 
            // button_locateSaveDiR
            // 
            resources.ApplyResources(button_locateSaveDiR, "button_locateSaveDiR");
            button_locateSaveDiR.Name = "button_locateSaveDiR";
            button_locateSaveDiR.UseVisualStyleBackColor = true;
            button_locateSaveDiR.Click += button_locateSaveDiR_Click;
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
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_WIPEMAP
            // 
            resources.ApplyResources(button_WIPEMAP, "button_WIPEMAP");
            button_WIPEMAP.Name = "button_WIPEMAP";
            button_WIPEMAP.UseVisualStyleBackColor = true;
            button_WIPEMAP.Click += button_WIPEMAP_Click;
            // 
            // checkBox_ActivateWipeMap
            // 
            resources.ApplyResources(checkBox_ActivateWipeMap, "checkBox_ActivateWipeMap");
            checkBox_ActivateWipeMap.Image = Ressources.EFK_Ressources.danger;
            checkBox_ActivateWipeMap.Name = "checkBox_ActivateWipeMap";
            checkBox_ActivateWipeMap.UseVisualStyleBackColor = true;
            checkBox_ActivateWipeMap.CheckedChanged += checkBox_ActivateWipeMap_CheckedChanged;
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
            // pictureBox3
            // 
            pictureBox3.Image = Ressources.EFK_Ressources.accolade;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // label_Important_2
            // 
            resources.ApplyResources(label_Important_2, "label_Important_2");
            label_Important_2.ForeColor = Color.Brown;
            label_Important_2.Name = "label_Important_2";
            // 
            // richTextBox_WIPEMAP_TIP
            // 
            richTextBox_WIPEMAP_TIP.BackColor = SystemColors.Control;
            richTextBox_WIPEMAP_TIP.BorderStyle = BorderStyle.None;
            richTextBox_WIPEMAP_TIP.ForeColor = SystemColors.WindowText;
            resources.ApplyResources(richTextBox_WIPEMAP_TIP, "richTextBox_WIPEMAP_TIP");
            richTextBox_WIPEMAP_TIP.Name = "richTextBox_WIPEMAP_TIP";
            // 
            // FenetrePrincipale
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_Important_2);
            Controls.Add(richTextBox_WIPEMAP_TIP);
            Controls.Add(pictureBox3);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox_TwitchLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_YoutubeLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DiscordLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label_Important;
        public TextBox textBox_ProfilPZ;
        private PictureBox pictureBox3;
        private Label label_Important_2;
        private RichTextBox richTextBox_WIPEMAP_TIP;
    }
}
