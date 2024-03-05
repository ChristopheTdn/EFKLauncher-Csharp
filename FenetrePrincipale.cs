using EFKLauncher.Classes;
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


    }
}
