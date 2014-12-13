using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone3
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ManageGButton_Click(object sender, EventArgs e)
        {
            ManageGPanel.BringToFront();
            MyGPanel.SendToBack();
            SettingsPanel.SendToBack();

            MyGPanel.Visible = false;
            ManageGPanel.Visible = true;
            SettingsPanel.Visible = false;

            MyGSearchLabel.Visible = false;
            MyGSearch.Visible = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.BringToFront();
            ManageGPanel.SendToBack();
            MyGPanel.SendToBack();

            MyGPanel.Visible = false;
            ManageGPanel.Visible = false;
            SettingsPanel.Visible = true;
            
            MyGSearchLabel.Visible = false;
            MyGSearch.Visible = false;
        }

        private void MyGButton_Click(object sender, EventArgs e)
        {
            MyGPanel.BringToFront();
            ManageGPanel.SendToBack();
            SettingsPanel.SendToBack();

            MyGPanel.Visible = true;
            ManageGPanel.Visible = false;
            SettingsPanel.Visible = false;

            MyGSearchLabel.Visible = true;
            MyGSearch.Visible = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            MyGPanel.BringToFront();
            ManageGPanel.SendToBack();
            SettingsPanel.SendToBack();

            MyGPanel.Visible = true;
            ManageGPanel.Visible = false;
            SettingsPanel.Visible = false;

            MyGSearchLabel.Visible = true;
            MyGSearch.Visible = true;
        }
        //matt's test line
    }
}
