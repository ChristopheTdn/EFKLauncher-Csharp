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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Channels;
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
            /*
            if (debug)
            {
                Core.WriteLog(textbox, "LAUNCH-PZ : run command line "
                     + Config.readConfig("SteamEXE")
                     + " -debug");
                Process.Start(new ProcessStartInfo(Config.readConfig("SteamEXE"),"-debug") { CreateNoWindow = true }); 
            }
            else
            {
                Core.WriteLog(textbox, "LAUNCH-PZ : run command line "
                             + Config.readConfig("SteamEXE"));
                Process.Start(new ProcessStartInfo(Config.readConfig("SteamEXE")){ CreateNoWindow = true }); 
            }
            */
            if (debug)
            {
                Core.WriteLog(textbox, "LAUNCH-PZ : run command line "
                     + Config.readConfig("SteamEXE")
                     + "\"steam://run/108600//-debug/\"");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start \"{Config.readConfig("SteamEXE")}\" steam://run/108600//-debug/") { CreateNoWindow = true });
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
            try
            {
                if (File.Exists(saveDir + file))
                {
                    File.Delete(saveDir + file.ToString());
                }
            }
            catch (Exception e)
            {
                string msg = e.Message.ToString();
                string texte = " > ERROR delFile ! :" + file.ToString() + " NOT deleted. (" + msg + ").";
                textbox.AppendText(texte + Environment.NewLine);
                textbox.ScrollToCaret();
            }
            

        }

        static public void WriteLog(RichTextBox textbox, string source)
        {
            textbox.SelectionFont = new Font(textbox.Font, FontStyle.Bold);
            textbox.AppendText(DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + " : ");
            textbox.SelectionFont = new Font(textbox.Font, FontStyle.Regular);
            textbox.AppendText(source + Environment.NewLine);
            textbox.ScrollToCaret();
        }

        static public string AfficheVersionProgramme()
        {
            string versionString = Environment.GetEnvironmentVariable("ClickOnce_CurrentVersion") ?? "0.0.0.0";
            //Version version = Version.Parse(versionString);
            return "v. " + versionString;
        }

        static public void WipeMap(TextBox textBox_ProfilPZ,
            TextBox textBox_SaveDir,
            RichTextBox richTextBox_Log)
        {
            string saveDir = textBox_ProfilPZ.Text + @"\Saves\Sandbox\" + textBox_SaveDir.Text + "\\";
            string fichierDelFile = @"Config\delfile\fichiers.txt";

            Core.WriteLog(richTextBox_Log, "WIPE MAP : Starting WIPEMAP");

            string[] listeDelFile = File.ReadAllLines(fichierDelFile);

            var fichiersSaveDir = Directory.GetFiles(textBox_ProfilPZ.Text + @"\Saves\Sandbox\" + textBox_SaveDir.Text).Select(Path.GetFileName); ;

            int nbrFileDeleted = 0;
            foreach (var line in fichiersSaveDir)
            {
                if (!listeDelFile.Contains(line) &
                    line != null)
                {
                    try
                    {
                        Core.delFile(
                            richTextBox_Log,
                            saveDir,
                            line.ToString());
                        nbrFileDeleted++;
                    }
                    catch (Exception e)
                    {
                        string msg = e.Message.ToString();
                        Core.WriteLog(richTextBox_Log, "     > ERROR ! :"  + msg + ").");

                    }
                }
            }
            Core.WriteLog(richTextBox_Log, "WIPE MAP : "+nbrFileDeleted.ToString()+ " files deleted.");
            Core.WriteLog(richTextBox_Log, "WIPE MAP : Ending WIPEMAP");
            Core.PlaySound(@"sounds\whoosh.wav");
        }
        static public void PlaySound(string son)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(son);
            player.Play();
        }
        /*
        *    LANGAGE
        */

        #region LANGAGE
        static public void ChangeLangage(string langue)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(langue);
            //SauvegardeLangage(langue);
        }
        static private void SauvegardeLangage(string langue)
        {
            //GOSLauncherCore.SetKeyValue(@"Software\Clan GOS\GOS Launcher A3\", "langage", langue);
        }
        #endregion
    }
}
