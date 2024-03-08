using EFKLauncher.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Configuration;
using System.Windows.Forms;
using System.IO;

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
            // Profil
            this.textBox_ProfilPZ.Text = Config.readConfig("profil");
            if (!Directory.Exists(this.textBox_ProfilPZ.Text))
            {
                this.textBox_ProfilPZ.Text = Core.getProfilPZDirectory();
                Config.setConfig("Profil", this.textBox_ProfilPZ.Text);
            }
            //DebugMode
            if (Config.readConfig("DebugMode") == "true")
            {
                this.checkBox_DebugMode.Checked = true;
            }
        }
        private void label_CollectionSteam_Click(object sender, EventArgs e)
        {
            Core.RunCmd("steam://openurl/https://steamcommunity.com/sharedfiles/filedetails/?id=3048855836");
        }

        private void button_LaunchPZ_Click(object sender, EventArgs e)
        {
            if (checkBox_DebugMode.Checked)
            {
                Core.RunCmd("steam://run/108600/-debug/");
            }
            else
            {
                Core.RunCmd("steam://run/108600/");
            }
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
            if (checkBox_DebugMode.Checked) {
                Config.setConfig("DebugMode", "true");
            }
            else
            {
                Config.setConfig("DebugMode", "false");
            }
        }
    }
}
