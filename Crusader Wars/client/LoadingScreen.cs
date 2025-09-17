using System;
using System.Windows.Forms;

namespace Crusader_Wars
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();

            //Icon
            Icon = Properties.Resources.logo;
            flowLayoutPanel2.Hide();
        }

        public void ChangeMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(ChangeMessage), message);
            }
            else
            {
                Label_Message.Text = message;
            }
        }

        public void ChangeUnitMapperMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(ChangeUnitMapperMessage), message);
            }
            else
            {
                Label_UnitMapper.Text = message;
                flowLayoutPanel2.Show();
            }
        }

        private void LoadingScreen_Shown(object sender, EventArgs e)
        {
            TopMost = false;
        }

    }
}

