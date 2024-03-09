/*
███████╗███████╗██╗  ██╗██╗      █████╗ ██╗   ██╗███╗   ██╗ ██████╗██╗  ██╗███████╗██████╗
██╔════╝██╔════╝██║ ██╔╝██║     ██╔══██╗██║   ██║████╗  ██║██╔════╝██║  ██║██╔════╝██╔══██╗
█████╗  █████╗  █████╔╝ ██║     ███████║██║   ██║██╔██╗ ██║██║     ███████║█████╗  ██████╔╝
██╔══╝  ██╔══╝  ██╔═██╗ ██║     ██╔══██║██║   ██║██║╚██╗██║██║     ██╔══██║██╔══╝  ██╔══██╗
███████╗██║     ██║  ██╗███████╗██║  ██║╚██████╔╝██║ ╚████║╚██████╗██║  ██║███████╗██║  ██║
╚══════╝╚═╝     ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝

# Classe CORE
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EFKLauncher.Classes
{
    public class Core
    {

        static public void RunCmd(string url)
        {
            /*
             *   Open Url
             *   Lance une commande dans l environnement windows/Linux ou Mac OS
             *   En faisant appel a CMD
             */

            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        static public void launchPZ(RichTextBox textbox, bool debug)
        {
            if (debug)
            {
                Core.WriteLog(textbox, "LAUNCH-PZ : run command line "
                     + Config.readConfig("SteamEXE")
                     + "\"steam://run/108600//-debug/\"");
                Process.Start(Config.readConfig("SteamEXE"), "steam://run/108600//-debug/");
            }
            else
            {
                Core.WriteLog(textbox, "LAUNCH-PZ : run command line "
                             + Config.readConfig("SteamEXE")
                             + "\"steam://run/108600/");
                Process.Start(Config.readConfig("SteamEXE"), "steam://run/108600/");
            }
        }
        static public string getProfilPZDirectory()
        {
            /*
             *   getProfilPZDirectory
             *   Recupere le chemin dur repertoire Zomboid
             */
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Zomboid";
        }

        static public void copyFile(string source, string dest)
        {
            if (File.Exists(source))
            {
                File.Copy(source, dest, true);
            }

        }
        static public void delFile(RichTextBox textbox, string saveDir, string file)
        {
            File.Delete(saveDir + "\\" + file);
            textbox.AppendText("     >" + file + " deleted." + Environment.NewLine);
            textbox.ScrollToCaret();

        }


        static public void WriteLog(RichTextBox textbox, string source)
        {
            textbox.SelectionFont = new Font(textbox.Font, FontStyle.Bold);
            textbox.AppendText(DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + " :");
            textbox.SelectionFont = new Font(textbox.Font, FontStyle.Regular);
            textbox.AppendText(source + Environment.NewLine);
            textbox.ScrollToCaret();
        }

        static public string AfficheVersionProgramme()
        {
            string versionString = Environment.GetEnvironmentVariable("ClickOnce_CurrentVersion") ?? "0.0.0.0";
            //Version version = Version.Parse(versionString);
            return "v. "+versionString;
        }
    }   
}
