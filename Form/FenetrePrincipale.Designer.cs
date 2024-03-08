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
            richTextBox_PreActivationTip = new RichTextBox();
            pictureBox2 = new PictureBox();
            radioButton_NoModif = new RadioButton();
            radioButton_EFKModPreInstall = new RadioButton();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage_EFKTab = new TabPage();
            richTextBox_Log = new RichTextBox();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox_EFKLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_Steam).BeginInit();
            groupBox_Repertoire.SuspendLayout();
            groupBox_PreInitEFK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage_EFKTab.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_EFKLogo
            // 
            pictureBox_EFKLogo.Image = Ressources.EFK_Ressources.EFK;
            pictureBox_EFKLogo.Location = new Point(12, 12);
            pictureBox_EFKLogo.Name = "pictureBox_EFKLogo";
            pictureBox_EFKLogo.Size = new Size(96, 93);
            pictureBox_EFKLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_EFKLogo.TabIndex = 0;
            pictureBox_EFKLogo.TabStop = false;
            // 
            // label_TitleEFKC
            // 
            label_TitleEFKC.AutoSize = true;
            label_TitleEFKC.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TitleEFKC.Location = new Point(114, 5);
            label_TitleEFKC.Name = "label_TitleEFKC";
            label_TitleEFKC.Size = new Size(250, 90);
            label_TitleEFKC.TabIndex = 1;
            label_TitleEFKC.Text = "ESCAPE FROM\r\nKNOX COUNTY";
            // 
            // label_CollectionSteam
            // 
            label_CollectionSteam.AutoSize = true;
            label_CollectionSteam.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_CollectionSteam.Location = new Point(95, 128);
            label_CollectionSteam.Name = "label_CollectionSteam";
            label_CollectionSteam.Size = new Size(568, 25);
            label_CollectionSteam.TabIndex = 2;
            label_CollectionSteam.Text = "Abonnements à la collection STEAM : ESCAPE FROM KNOX COUNTY";
            label_CollectionSteam.TextAlign = ContentAlignment.MiddleCenter;
            label_CollectionSteam.Click += label_CollectionSteam_Click;
            // 
            // picture_Steam
            // 
            picture_Steam.Image = Ressources.EFK_Ressources.Steam_Icon;
            picture_Steam.Location = new Point(35, 111);
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
            button_LaunchPZ.Location = new Point(527, 23);
            button_LaunchPZ.Name = "button_LaunchPZ";
            button_LaunchPZ.Size = new Size(155, 50);
            button_LaunchPZ.TabIndex = 4;
            button_LaunchPZ.Text = "Lancer PZ";
            button_LaunchPZ.TextAlign = ContentAlignment.MiddleRight;
            button_LaunchPZ.UseVisualStyleBackColor = true;
            button_LaunchPZ.Click += button_LaunchPZ_Click;
            // 
            // checkBox_DebugMode
            // 
            checkBox_DebugMode.AutoSize = true;
            checkBox_DebugMode.Location = new Point(559, 79);
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
            groupBox_Repertoire.Location = new Point(30, 197);
            groupBox_Repertoire.Name = "groupBox_Repertoire";
            groupBox_Repertoire.Size = new Size(633, 99);
            groupBox_Repertoire.TabIndex = 6;
            groupBox_Repertoire.TabStop = false;
            groupBox_Repertoire.Text = "Repertoire utilisateur";
            // 
            // button_locateSaveDiR
            // 
            button_locateSaveDiR.Location = new Point(540, 61);
            button_locateSaveDiR.Name = "button_locateSaveDiR";
            button_locateSaveDiR.Size = new Size(84, 23);
            button_locateSaveDiR.TabIndex = 4;
            button_locateSaveDiR.Text = "Localiser";
            button_locateSaveDiR.UseVisualStyleBackColor = true;
            button_locateSaveDiR.Click += button_locateSaveDiR_Click;
            // 
            // textBox_SaveDir
            // 
            textBox_SaveDir.BackColor = SystemColors.ButtonHighlight;
            textBox_SaveDir.Location = new Point(96, 61);
            textBox_SaveDir.Name = "textBox_SaveDir";
            textBox_SaveDir.ReadOnly = true;
            textBox_SaveDir.Size = new Size(404, 23);
            textBox_SaveDir.TabIndex = 3;
            // 
            // label_SaveGame
            // 
            label_SaveGame.AutoSize = true;
            label_SaveGame.Location = new Point(16, 64);
            label_SaveGame.Name = "label_SaveGame";
            label_SaveGame.Size = new Size(74, 15);
            label_SaveGame.TabIndex = 2;
            label_SaveGame.Text = "Sauvegarde :";
            label_SaveGame.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_ProfilPZ
            // 
            textBox_ProfilPZ.BackColor = SystemColors.ButtonHighlight;
            textBox_ProfilPZ.Location = new Point(96, 26);
            textBox_ProfilPZ.Name = "textBox_ProfilPZ";
            textBox_ProfilPZ.ReadOnly = true;
            textBox_ProfilPZ.Size = new Size(404, 23);
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
            groupBox_PreInitEFK.Controls.Add(richTextBox_PreActivationTip);
            groupBox_PreInitEFK.Controls.Add(pictureBox2);
            groupBox_PreInitEFK.Controls.Add(radioButton_NoModif);
            groupBox_PreInitEFK.Controls.Add(radioButton_EFKModPreInstall);
            groupBox_PreInitEFK.Controls.Add(pictureBox1);
            groupBox_PreInitEFK.Location = new Point(30, 305);
            groupBox_PreInitEFK.Name = "groupBox_PreInitEFK";
            groupBox_PreInitEFK.Size = new Size(641, 87);
            groupBox_PreInitEFK.TabIndex = 7;
            groupBox_PreInitEFK.TabStop = false;
            groupBox_PreInitEFK.Text = "Pré Activation MOD EFK";
            // 
            // richTextBox_PreActivationTip
            // 
            richTextBox_PreActivationTip.BackColor = SystemColors.Control;
            richTextBox_PreActivationTip.BorderStyle = BorderStyle.None;
            richTextBox_PreActivationTip.ForeColor = SystemColors.WindowText;
            richTextBox_PreActivationTip.ImeMode = ImeMode.On;
            richTextBox_PreActivationTip.Location = new Point(382, 15);
            richTextBox_PreActivationTip.Name = "richTextBox_PreActivationTip";
            richTextBox_PreActivationTip.Size = new Size(253, 66);
            richTextBox_PreActivationTip.TabIndex = 3;
            richTextBox_PreActivationTip.Text = "IMPORTANT :\nLe launcher force la pre selection des Mods dans EFK. \nSi tu desires Modder le jeu, choisir : No Modif";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Ressources.EFK_Ressources.accolade;
            pictureBox2.Location = new Point(362, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(14, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // radioButton_NoModif
            // 
            radioButton_NoModif.AutoSize = true;
            radioButton_NoModif.Location = new Point(80, 45);
            radioButton_NoModif.Name = "radioButton_NoModif";
            radioButton_NoModif.Size = new Size(245, 19);
            radioButton_NoModif.TabIndex = 1;
            radioButton_NoModif.TabStop = true;
            radioButton_NoModif.Text = "No Modif (Pour les moddeurs Seulement)";
            radioButton_NoModif.UseVisualStyleBackColor = true;
            radioButton_NoModif.CheckedChanged += radioButton_NoModif_CheckedChanged;
            // 
            // radioButton_EFKModPreInstall
            // 
            radioButton_EFKModPreInstall.AutoSize = true;
            radioButton_EFKModPreInstall.Location = new Point(80, 22);
            radioButton_EFKModPreInstall.Name = "radioButton_EFKModPreInstall";
            radioButton_EFKModPreInstall.Size = new Size(285, 19);
            radioButton_EFKModPreInstall.TabIndex = 1;
            radioButton_EFKModPreInstall.TabStop = true;
            radioButton_EFKModPreInstall.Text = "Pré Initialisation MOD  Escape From Knox County";
            radioButton_EFKModPreInstall.UseVisualStyleBackColor = true;
            radioButton_EFKModPreInstall.CheckedChanged += radioButton_EFKModPreInstall_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Ressources.EFK_Ressources.performance;
            pictureBox1.Location = new Point(16, 22);
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
            tabControl1.Location = new Point(30, 398);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(635, 251);
            tabControl1.TabIndex = 8;
            // 
            // tabPage_EFKTab
            // 
            tabPage_EFKTab.BackColor = SystemColors.Control;
            tabPage_EFKTab.Controls.Add(richTextBox_Log);
            tabPage_EFKTab.Location = new Point(4, 24);
            tabPage_EFKTab.Name = "tabPage_EFKTab";
            tabPage_EFKTab.Padding = new Padding(3);
            tabPage_EFKTab.Size = new Size(627, 223);
            tabPage_EFKTab.TabIndex = 0;
            tabPage_EFKTab.Text = "Journal";
            // 
            // richTextBox_Log
            // 
            richTextBox_Log.Location = new Point(6, 7);
            richTextBox_Log.Name = "richTextBox_Log";
            richTextBox_Log.Size = new Size(614, 210);
            richTextBox_Log.TabIndex = 0;
            richTextBox_Log.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(627, 223);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "A Propos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FenetrePrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 789);
            Controls.Add(tabControl1);
            Controls.Add(groupBox_PreInitEFK);
            Controls.Add(groupBox_Repertoire);
            Controls.Add(checkBox_DebugMode);
            Controls.Add(button_LaunchPZ);
            Controls.Add(picture_Steam);
            Controls.Add(label_CollectionSteam);
            Controls.Add(label_TitleEFKC);
            Controls.Add(pictureBox_EFKLogo);
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
        private TextBox textBox_ProfilPZ;
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
        private RichTextBox richTextBox_Log;
        private TabPage tabPage2;
    }
}
