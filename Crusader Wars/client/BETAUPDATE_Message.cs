using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace Crusader_Wars.client
{
    public partial class BETAUPDATE_Message : Form
    {
        public BETAUPDATE_Message()
        {
            InitializeComponent();
            Icon = Properties.Resources.logo;
        }

        private void SetMessage(string message)
        {
            Text_Warning.Text = message;
        }

        public static void ShowWarningMessage(string message)
        {
            var warning_message = new BETAUPDATE_Message();
            warning_message.SetMessage(message);
            SystemSounds.Exclamation.Play();
            warning_message.ShowDialog();

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            //Internet Connection
            try
            {
                Process.Start("https://crusaderwars.com/#download-page");
                Close();
            }
            //Offline
            catch 
            {
                MessageBox.Show("No Internet connection." +
                                " Your ck3 mod version is for the new beta release, " +
                                "if you don't download the new the CW launcher from the website it may cause crashes!",
                    "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
