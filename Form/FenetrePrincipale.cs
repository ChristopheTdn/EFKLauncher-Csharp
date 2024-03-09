using EFKLauncher.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace EFKLauncher
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
        }
        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {
            // Gestion Maj Parametre sur Interface
            // Savedir
            this.textBox_SaveDir.Text = Config.readConfig("SaveDir");
            if (!Directory.Exists(this.textBox_SaveDir.Text))
            {
                this.textBox_SaveDir.Text = "";
                Config.setConfig("SaveDir", "");
            }
            this.checkBox_ActivateWipeMap.Checked = false;
            this.button_WIPEMAP.Enabled = false;
            this.checkBox_ActivateWipeMap.Enabled = Directory.Exists(this.textBox_SaveDir.Text);



            Core.WriteLog(richTextBox_Log, "Setting Savedir");
            // Profil
            this.textBox_ProfilPZ.Text = Config.readConfig("profil");
            if (!Directory.Exists(this.textBox_ProfilPZ.Text))
            {
                this.textBox_ProfilPZ.Text = Core.getProfilPZDirectory();
                Config.setConfig("Profil", this.textBox_ProfilPZ.Text);
            }
            Core.WriteLog(richTextBox_Log, "Setting Pz Profil Directory");

            //DebugMode
            if (Config.readConfig("DebugMode") == "true")
            {
                this.checkBox_DebugMode.Checked = true;
            }
            Core.WriteLog(richTextBox_Log, "Setting Debug Mode CheckBox");
            //SteamExe
            Config.setConfig("SteamEXE", (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamExe", "cle Inconnue"));
            Core.WriteLog(richTextBox_Log, "Find Steam.exe : " + Config.readConfig("SteamEXE"));

            //Copyfile

            Core.copyFile(@"Config\difficulty\EFK Easy.cfg",
                            this.textBox_ProfilPZ.Text + @"\Sandbox Presets\EFK Easy.cfg"
                         );
            Core.copyFile(@"Config\difficulty\EFK Hard.cfg",
                            this.textBox_ProfilPZ.Text + @"\Sandbox Presets\EFK Hard.cfg"
                         );
            Core.copyFile(@"Config\difficulty\EFK STD.cfg",
                            this.textBox_ProfilPZ.Text + @"\Sandbox Presets\EFK STD.cfg"
                         );
            Core.WriteLog(richTextBox_Log, "Install SandBox Presets : EFK Easy.cfg, EFK Hard.cfg, EFK STD.cfg");


            // PreIni EFKMod
            if (Config.readConfig("PreIniEFK") == "Not Found" ||
                Config.readConfig("PreIniEFK") == "true"
                )
            {
                this.radioButton_EFKModPreInstall.Checked = true;
                Config.setConfig("PreIniEFK", "true");
            }
            else
            {
                this.radioButton_NoModif.Checked = true;
            }

            // version programme
            this.label_VersionProgramme.Text = Core.AfficheVersionProgramme();


        }
        private void label_CollectionSteam_Click(object sender, EventArgs e)
        {
            Core.RunCmd("steam://openurl/https://steamcommunity.com/sharedfiles/filedetails/?id=3048855836");
        }

        private void button_LaunchPZ_Click(object sender, EventArgs e)
        {
            Core.WriteLog(richTextBox_Log, "LAUNCH-PZ : init Launch PZ ");
            if (this.radioButton_EFKModPreInstall.Checked)
            {
                Core.copyFile(@"Config\EFK\AdvancedEFK_default.txt",
                              this.textBox_ProfilPZ.Text + @"\mods\default.txt");
                Core.WriteLog(richTextBox_Log, "LAUNCH-PZ : update \"\\mods\\default.txt\" with EFK Mod list");
            }
            Core.WriteLog(richTextBox_Log, "LAUNCH-PZ : Debug mode >" + checkBox_DebugMode.Checked.ToString());
            Core.launchPZ(richTextBox_Log, checkBox_DebugMode.Checked);

        }

        private void button_locateSaveDiR_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Choose a Save Game Directory for WipeMap Process.";
            folderDialog.SelectedPath = textBox_ProfilPZ.Text + @"\Saves\Sandbox\"; ;
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox_SaveDir.Text = folderDialog.SelectedPath;
                Config.setConfig("SaveDir", textBox_SaveDir.Text);
            }
        }

        private void checkBox_DebugMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DebugMode.Checked)
            {
                Config.setConfig("DebugMode", "true");
            }
            else
            {
                Config.setConfig("DebugMode", "false");
            }
        }

        private void radioButton_EFKModPreInstall_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_EFKModPreInstall.Checked == true)
            {
                Config.setConfig("PreIniEFK", "true");
            }
        }

        private void radioButton_NoModif_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_NoModif.Checked == true)
            {
                Config.setConfig("PreIniEFK", "false");
            }
        }

        private void checkBox_ActivateWipeMap_CheckedChanged(object sender, EventArgs e)
        {
            this.button_WIPEMAP.Enabled = checkBox_ActivateWipeMap.Checked;
        }

        private void button_WIPEMAP_Click(object sender, EventArgs e)
        {
            Core.WriteLog(richTextBox_Log, "WIPE MAP : Starting WIPEMAP");

            string fileName = @"Config\delfile\fichiers.txt";
            IEnumerable<string> lines = File.ReadLines(fileName);

            foreach (string line in lines)
            {
                if (File.Exists(textBox_SaveDir.Text + "\\" + line))
                {
                    Core.delFile(
                        richTextBox_Log,
                        textBox_SaveDir.Text,
                        line);
                }
            }
            Core.WriteLog(richTextBox_Log, "WIPE MAP : Ending WIPEMAP");
        }

        private void textBox_SaveDir_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.textBox_SaveDir.Text))
            {
                this.textBox_SaveDir.Text = "";
                Config.setConfig("SaveDir", "");
            }
            this.checkBox_ActivateWipeMap.Checked = false;
            this.button_WIPEMAP.Enabled = false;
            this.checkBox_ActivateWipeMap.Enabled = Directory.Exists(this.textBox_SaveDir.Text);
        }

        private void pictureBox_TwitchLogo_Click(object sender, EventArgs e)
        {
            Core.RunCmd("https://www.twitch.tv/tancredterror");

        }

        private void pictureBox_YoutubeLogo_Click(object sender, EventArgs e)
        {
            Core.RunCmd("https://www.youtube.com/@TancredTerror");
        }

        private void pictureBox_DiscordLogo_Click(object sender, EventArgs e)
        {
            Core.RunCmd("https://discord.com/invite/rbd36ERXyu");
        }
    }
}
