using System;
using System.Net;
using System.Windows;

namespace WindowsRestorer
{
    /// <summary>
    /// Icon by Maxim Basinski.
    /// Info: A simple tool to get you back on your feet after a system restore.
    /// Developer: Wolfijiyn @ GitHub
    /// Version: 1.0
    /// License: MIT
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            statusLabel.Content = "Overall Progress " + e.ProgressPercentage.ToString() + "%";
        }

        private void StartDownload(string requestUrl, string filename, string savePath, string combinedPaths)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileAsync(new System.Uri(requestUrl), combinedPaths);
            }
        }

        private void restoreBtn_Click(object sender, RoutedEventArgs e)
        {

            var mask = 0;
            if (GeForceCb.IsChecked == true)
                try
                {
                    string requestUrl = "http://us.download.nvidia.com/GFE/GFEClient/3.2.0.96/GeForce_Experience_v3.2.0.96.exe";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\GeForce Experience Installer.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch
                {

                }
            mask |= 1 << 0;

            if (amdCataclystCb.IsChecked == true)
                try
                {
                    System.Diagnostics.Process.Start("http://support.amd.com/en-us/download/auto-detect-tool");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            mask |= 1 << 2;

            if (comodoCb.IsChecked == true) // 
                try
                {
                    string requestUrl = "http://download.comodo.com/cis/download/installs/2000/partners/cfw_installer_6106_53.exe";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\Comodo Firewall Installer.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            mask |= 1 << 3;


            if (KeyscramblerCb.IsChecked == true)
                try
                {
                    string requestUrl = "http://download.qfxsoftware.com/download/KeyScrambler_Setup.exe";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\KeyScramblerInstaller.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            mask |= 1 << 4;


            if (malwareBytesCb.IsChecked == true)
                try
                {
                    string requestUrl = "https://downloads.malwarebytes.com/file/mb3/";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\malwareBytesInstaller.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            mask |= 1 << 5;


            if (firefoxCb.IsChecked == true)
                try
                {
                    string requestUrl = "https://download.mozilla.org/?product=firefox-stub&os=win&lang=sv-SE";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\FirefoxInstaller.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            mask |= 1 << 6;


            if (ChromeCb.IsChecked == true)
                try
                {
                    System.Diagnostics.Process.Start("https://www.google.com/chrome/browser/desktop/index.html");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            mask |= 1 << 7;


            if (OperaCb.IsChecked == true)
                try
                {
                    string requestUrl = "http://net.geo.opera.com/opera/stable/windows?http_referrer=missing_via_opera_com&utm_source=(direct)_via_opera_com&utm_medium=doc&utm_campaign=(direct)_via_opera_com";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\OperaInstaller.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                ;
            mask |= 1 << 8;

            if (vlcMediaCB.IsChecked == true)
                try
                {
                    string requestUrl = "https://get.videolan.org/vlc/2.2.4/win32/vlc-2.2.4-win32.exe";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\VLCInstaller.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch
                {

                }
            mask |= 1 << 9;


            if (SpotifyCb.IsChecked == true) 
                try
                {
                    string requestUrl = "https://download.scdn.co/SpotifySetup.exe";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\SpotifyInstaller.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch
                {

                }
            mask |= 1 << 10;


            if (javaandJdkCb.IsChecked == true) 
                try
                {
                    string requestUrl = "http://javadl.oracle.com/webapps/download/AutoDL?BundleId=216462";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\JavaInstaller.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch
                {

                }
                mask |= 1 << 11;


            if (dotnetFrameworkDb.IsChecked == true)
                try
                {
                    string requestUrl = "https://download.microsoft.com/download/B/A/4/BA4A7E71-2906-4B2D-A0E1-80CF16844F5F/dotNetFx45_Full_setup.exe";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\DotNet45.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch
                {

                }
            mask |= 1 << 12; 

            if (visualStudioCb.IsChecked == true)
                try
                {
                    System.Diagnostics.Process.Start("https://www.microsoft.com/en-us/download/confirmation.aspx?id=48146");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            mask |= 1 << 13;

            if (EclipseCb.IsChecked == true)
                try
                {
                    System.Diagnostics.Process.Start("https://eclipse.org/downloads/eclipse-packages/");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                mask |= 1 << 14;

            if (BracketsCb.IsChecked == true) 
                try
                {
                    string requestUrl = "https://github.com/adobe/brackets/releases/download/release-1.8/Brackets.Release.1.8.msi";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\BracketsInstallet.msi";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch
                {

                }
            mask |= 1 << 15;

            if (Notepadplusplus.IsChecked == true) 
                try
                {
                    string requestUrl = "https://notepad-plus-plus.org/repository/7.x/7.2.2/npp.7.2.2.Installer.exe";
                    string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "\\notePadPlusInstaller.exe";
                    string combinedPaths = savePath + fileName;

                    StartDownload(requestUrl, fileName, savePath, combinedPaths);
                }
                catch
                {

                }
            mask |= 1 << 16;
        }
    }
}

