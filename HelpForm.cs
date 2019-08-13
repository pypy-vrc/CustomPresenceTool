using MetroFramework.Forms;
using System.Windows.Forms;

namespace CustomPresenceTool
{
    public partial class HelpForm : MetroForm
    {
        public static HelpForm Instance { get; private set; } = null;

        public HelpForm()
        {
            Instance = this;
            InitializeComponent();
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
