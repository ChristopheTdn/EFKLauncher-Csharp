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
            ((System.ComponentModel.ISupportInitialize)pictureBox_EFKLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_Steam).BeginInit();
            groupBox_Repertoire.SuspendLayout();
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
            // FenetrePrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 704);
            Controls.Add(groupBox_Repertoire);
            Controls.Add(checkBox_DebugMode);
            Controls.Add(button_LaunchPZ);
            Controls.Add(picture_Steam);
            Controls.Add(label_CollectionSteam);
            Controls.Add(label_TitleEFKC);
            Controls.Add(pictureBox_EFKLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FenetrePrincipale";
            Text = "EFK Launcher";
            Load += FenetrePrincipale_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_EFKLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_Steam).EndInit();
            groupBox_Repertoire.ResumeLayout(false);
            groupBox_Repertoire.PerformLayout();
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
    }
}
