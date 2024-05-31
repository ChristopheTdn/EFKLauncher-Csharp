using EFKLauncher.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Text.Json;
using System.Globalization;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFKLauncher
{
    public partial class FenetrePrincipale : Form
    {
        Form splashscreen = new Splashscreen();
        string[] argumentGOSLauncher;
        public FenetrePrincipale()
        {
            InitializeComponent();
        }
        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {
            // splashscreen.Show();
            CheckForIllegalCrossThreadCalls = false;
            // Gestion Maj Parametre sur Interface
            // application Langage
            // Core.ChangeLangage("en-GB");
            // Profil
            textBox_ProfilPZ.Text = Config.readConfig("profil");
            if (!Directory.Exists(textBox_ProfilPZ.Text))
            {
                textBox_ProfilPZ.Text = Core.getProfilPZDirectory();
                Config.setConfig("Profil", textBox_ProfilPZ.Text);
            }
            Core.WriteLog(richTextBox_Log, "Setting Pz Profil Directory");


            // Savedir
            textBox_SaveDir.Text = Config.readConfig("SaveDir");
            if (!Directory.Exists(textBox_ProfilPZ.Text + @"\Saves\Sandbox\" + textBox_SaveDir.Text))
            {
                textBox_SaveDir.Text = "";
                Config.setConfig("SaveDir", "");
            }
            Core.WriteLog(richTextBox_Log, "Setting Savedir");


            //DebugMode
            if (Config.readConfig("DebugMode") == "true")
            {
                checkBox_DebugMode.Checked = true;
            }
            Core.WriteLog(richTextBox_Log, "Setting Debug Mode CheckBox");


            //Project zomboid exec
            /*
            Config.setConfig("SteamEXE", ((string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Steam App 108600", "InstallLocation","PZ Exe not found. Error launching ")+ "\\ProjectZomboid64.bat"));
            Core.WriteLog(richTextBox_Log, "Find PZ executable : " + Config.readConfig("SteamEXE"));
            */
            Config.setConfig("SteamEXE", (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamExe", "cle Inconnue"));
            Core.WriteLog(richTextBox_Log, "Find Steam.exe : " + Config.readConfig("SteamEXE"));



            // Difficulty

            Core.copyFile(@"Config\difficulty\EFK STD.cfg",
                             textBox_ProfilPZ.Text + @"\Sandbox Presets\EFK STD.cfg"
                         );
            Core.WriteLog(richTextBox_Log, "Install SandBox Presets :  EFK STD.cfg (remove obsolete HARD and Easy settings if needed)");

            // remove Obsolete difficulty EFK Easy.cfg, EFK Hard.cfg,
            try
            {
                if (File.Exists(textBox_ProfilPZ.Text + @"\Sandbox Presets\EFK Easy.cfg"))
                {
                    File.Delete(textBox_ProfilPZ.Text + @"\Sandbox Presets\EFK Easy.cfg");
                }
                if (File.Exists(textBox_ProfilPZ.Text + @"\Sandbox Presets\EFK Hard.cfg"))
                {
                    File.Delete(textBox_ProfilPZ.Text + @"\Sandbox Presets\EFK Hard.cfg");
                }
            }
            catch
            {
            }




            // PreIni EFKMod
            if (Config.readConfig("PreIniEFK") == "Not Found" ||
                Config.readConfig("PreIniEFK") == "true"
                )
            {

                radioButton_EFKModPreInstall.Checked = true;
                Config.setConfig("PreIniEFK", "true");
            }
            else
            {
                radioButton_NoModif.Checked = true;
            }

            // version programme
            label_VersionProgramme.Text = Core.AfficheVersionProgramme();

            // Init Timer
            System.Timers.Timer temporisation = new System.Timers.Timer(10000);
            temporisation.Enabled = true;
            temporisation.Elapsed += new System.Timers.ElapsedEventHandler(ScanAutoWipeMap);
            temporisation.AutoReset = true;
        }

        private void ScanAutoWipeMap(object source, System.Timers.ElapsedEventArgs e)
        {

            string jsonFilePath = textBox_ProfilPZ.Text + @"\Sandbox Presets\WIPEMAP.json";
            if (File.Exists(jsonFilePath))
            {
                Core.WriteLog(richTextBox_Log, "AUTO WIPEMAP Activated");
                try
                {
                    string json = File.ReadAllText(jsonFilePath);

                    // Désérialisation en utilisant System.Text.Json
                    var jsonDocument = JsonDocument.Parse(json);
                    var root = jsonDocument.RootElement;

                    // récupere donnée JSON "SaveGameDir" :
                    string saveDir = root.GetProperty("SaveGameDir").ToString();
                    textBox_SaveDir.Text = saveDir;
                    Core.WriteLog(richTextBox_Log, $"set SavegameDir >> {saveDir}");

                    Core.WipeMap(textBox_ProfilPZ, textBox_SaveDir, richTextBox_Log);

                    File.Delete(jsonFilePath);
                    Core.WriteLog(richTextBox_Log, "WIPEMAP.json file deleted");
                    Core.WriteLog(richTextBox_Log, "AUTO WIPEMAP Done");
                }
                catch (Exception error)
                {
                    Core.WriteLog(richTextBox_Log, "AUTO WIPEMAP ERROR : " + error.ToString());
                    Core.WriteLog(richTextBox_Log, "AUTO WIPEMAP Aborted");
                }
            }

        }

        private void label_CollectionSteam_Click(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
            Core.RunCmd("steam://openurl/https://steamcommunity.com/sharedfiles/filedetails/?id=3048855836");
        }

        private void button_LaunchPZ_Click(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
            Core.WriteLog(richTextBox_Log, "LAUNCH-PZ : init Launch PZ ");
            if (radioButton_EFKModPreInstall.Checked)
            {
                Core.copyFile(@"Config\EFK\default.txt",
                               textBox_ProfilPZ.Text + @"\mods\default.txt");
                Core.WriteLog(richTextBox_Log, "LAUNCH-PZ : update \"\\mods\\default.txt\" with EFK Mod list");

                Core.copyFile(@"Config\EFK\SurvivorOptions.lua",
                             textBox_ProfilPZ.Text + @"\lua\SurvivorOptions.lua");
                Core.WriteLog(richTextBox_Log, "LAUNCH-PZ : copy \"\\lua\\SurvivorOptions.lua\" (SCAVs options)");

            }
            Core.WriteLog(richTextBox_Log, "LAUNCH-PZ : Debug mode >" + checkBox_DebugMode.Checked.ToString());
            Core.launchPZ(richTextBox_Log, checkBox_DebugMode.Checked);

        }

        private void button_locateSaveDiR_Click(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
            var folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Choose a Save Game Directory for WipeMap Process.";
            folderDialog.SelectedPath = textBox_ProfilPZ.Text + @"\Saves\Sandbox\"; ;
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox_SaveDir.Text = Path.GetFileName(folderDialog.SelectedPath);
                Config.setConfig("SaveDir", textBox_SaveDir.Text);
            }
        }

        private void checkBox_DebugMode_CheckedChanged(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
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
            Core.PlaySound(@"sounds\clic.wav");
            if (radioButton_EFKModPreInstall.Checked == true)
            {
                Config.setConfig("PreIniEFK", "true");
            }
        }

        private void radioButton_NoModif_CheckedChanged(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
            if (radioButton_NoModif.Checked == true)
            {
                Config.setConfig("PreIniEFK", "false");
            }
        }

        private void textBox_SaveDir_TextChanged(object sender, EventArgs e)
        {

            if (!Directory.Exists(textBox_ProfilPZ.Text + @"\Saves\Sandbox\" + textBox_SaveDir.Text))
            {
                textBox_SaveDir.Text = "";
                Config.setConfig("SaveDir", "");
            }
        }

        private void pictureBox_TwitchLogo_Click(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
            Core.RunCmd("https://www.twitch.tv/tancredterror");

        }

        private void pictureBox_YoutubeLogo_Click(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
            Core.RunCmd("https://www.youtube.com/@TancredTerror");
        }

        private void pictureBox_DiscordLogo_Click(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
            Core.RunCmd("https://discord.com/invite/rbd36ERXyu");
        }

        private void label_SourceCodeLink_Click(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
            Core.RunCmd("https://github.com/ChristopheTdn/EFKLauncher-Csharp");
        }

        private void label_DiscordProject_Link_Click(object sender, EventArgs e)
        {
            Core.PlaySound(@"sounds\clic.wav");
            Core.RunCmd("https://discord.com/invite/rbd36ERXyu");
        }

    }
}
