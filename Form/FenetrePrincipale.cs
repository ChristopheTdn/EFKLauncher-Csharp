using EFKLauncher.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;

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

            this.textBox_ProfilPZ.Text = Core.getProfilPZDirectory();

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
                //Use folder path
            }
        }
    }
}
