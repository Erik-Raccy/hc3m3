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
            AddGPanel.Visible = false;
            RemoveGPanel.Visible = false;
            EditGPanel.Visible = false;

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
            CSchemePanel.Visible = false;
            SoundPanel.Visible = false;
            DisplayPanel.Visible = false;
            
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

        private void CSchemeButton_Click(object sender, EventArgs e)
        {
            CSchemePanel.Visible = true;
            
            CSchemePanel.BringToFront();
            SoundPanel.SendToBack();
            DisplayPanel.SendToBack();
        }

        private void SoundButton_Click(object sender, EventArgs e)
        {
            SoundPanel.Visible = true;
            
            CSchemePanel.SendToBack();
            SoundPanel.BringToFront();
            DisplayPanel.SendToBack();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayPanel.Visible = true;
            
            CSchemePanel.SendToBack();
            SoundPanel.SendToBack();
            DisplayPanel.BringToFront();
        }

        private void AddGButton_Click(object sender, EventArgs e)
        {
            AddGPanel.Visible = true;

            AddGPanel.BringToFront();
            RemoveGPanel.SendToBack();
            EditGPanel.SendToBack();
        }

        private void RemoveGButton_Click(object sender, EventArgs e)
        {
            RemoveGPanel.Visible = true;

            AddGPanel.SendToBack();
            RemoveGPanel.BringToFront();
            EditGPanel.SendToBack();
        }

        private void EditGButton_Click(object sender, EventArgs e)
        {
            EditGPanel.Visible = true;

            AddGPanel.SendToBack();
            RemoveGPanel.SendToBack();
            EditGPanel.BringToFront();
        }
        //matt's test line
    }
}
