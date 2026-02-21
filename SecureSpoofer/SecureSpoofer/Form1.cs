using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SecureSpoofer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblInfo.Text = "Enable protection to spoof hardware safely and bypass FiveGuard bans.";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiðinde çalýþýr
        }

        private void btnSpoofHWID_Click(object sender, EventArgs e)
        {
            SpoofVolumeID();

            if (chkFiveGuard.Checked)
            {
                SpoofBIOS();
                SpoofMAC();
            }

            if (chkProtection.Checked)
            {
                EnableProtection();
            }

            MessageBox.Show("Spoof iþlemi tamamlandý!");
        }

        private void SpoofVolumeID()
        {
            Process.Start("cmd.exe", "/c vol C: & Volumeid C: A1B2-C3D4");
        }

        private void SpoofMAC()
        {
            string regPath = @"SYSTEM\CurrentControlSet\Control\Class\{4D36E972-E325-11CE-BFC1-08002BE10318}\0001";
            Registry.SetValue($"HKEY_LOCAL_MACHINE\\{regPath}", "NetworkAddress", "001A2B3C4D5E");
        }

        private void SpoofBIOS()
        {
            // BIOS spoof sadece görsel amaçlý örnek
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "SerialNumber", "FAKEBIOS12345");
        }

        private void EnableProtection()
        {
            if (Debugger.IsAttached)
            {
                Application.Exit();
            }
        }
    }
}
