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
        FileReader reader = new FileReader();
        int SelectedGame = 0;
        const int small=12;
        const int medium = 18;
        const int large = 22;
        Color backC = SystemColors.Control;
        Color fontC = SystemColors.ControlText;
        Color borderC = Color.Black;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ManageGButton_Click(object sender, EventArgs e)
        {
            if (ManageGButton.BackColor != Color.Teal)
            {
            AddGPanel.Visible = false;
            RemoveGPanel.Visible = false;
            EditGPanel.Visible = false;

            ManageGPanel.BringToFront();
            MyGPanel.SendToBack();
            SettingsPanel.SendToBack();
            GInfoPanel.SendToBack();

            MyGPanel.Visible = false;
            ManageGPanel.Visible = true;
            SettingsPanel.Visible = false;
            GInfoPanel.Visible = false;

            MyGSearchLabel.Visible = false;
            MyGSearch.Visible = false;

           
                uncolorAll();
                currentTab(ManageGButton);
            }        
            }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (SettingsButton.BackColor != Color.Teal)
            {
            CSchemePanel.Visible = false;
            SoundPanel.Visible = false;
            DisplayPanel.Visible = false;
            
            SettingsPanel.BringToFront();
            ManageGPanel.SendToBack();
            MyGPanel.SendToBack();
            GInfoPanel.SendToBack();

            MyGPanel.Visible = false;
            ManageGPanel.Visible = false;
            SettingsPanel.Visible = true;
            GInfoPanel.Visible = false;
            
            MyGSearchLabel.Visible = false;
            MyGSearch.Visible = false;

            
                uncolorAll();
                currentTab(SettingsButton);
            }    
            
        }

        private void MyGButton_Click(object sender, EventArgs e)
        {
            if (MyGButton.BackColor != Color.Teal)
            {
                MyGPanel.BringToFront();
                ManageGPanel.SendToBack();
                SettingsPanel.SendToBack();
                GInfoPanel.SendToBack();

                MyGPanel.Visible = true;
                ManageGPanel.Visible = false;
                SettingsPanel.Visible = false;
                GInfoPanel.Visible = false;

                MyGSearchLabel.Visible = true;
                MyGSearch.Visible = true;

                uncolorAll();
                currentTab(MyGButton);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            MyGPanel.BringToFront();
            ManageGPanel.SendToBack();
            SettingsPanel.SendToBack();
            GInfoPanel.SendToBack();

            MyGPanel.Visible = true;
            ManageGPanel.Visible = false;
            SettingsPanel.Visible = false;
            GInfoPanel.Visible = false;

            MyGSearchLabel.Visible = true;
            MyGSearch.Visible = true;
            
            for (int i = 0; i < reader.getGamesList().Count(); i++)
            {
                Console.WriteLine(i);
                EditGList.Items.Add(reader.getGamesList()[i]);
            }

      

           // for(int i;Genre1.count>i;i++)
            //populater all the genres
           populateGenre("moba");
        }

        private void CSchemeButton_Click(object sender, EventArgs e)
        {
            CSchemePanel.Visible = true;
            
            CSchemePanel.BringToFront();
            SoundPanel.SendToBack();
            DisplayPanel.SendToBack();
            currentSettingsTab(CSchemeButton);
        }

        private void SoundButton_Click(object sender, EventArgs e)
        {
            SoundPanel.Visible = true;
            
            CSchemePanel.SendToBack();
            SoundPanel.BringToFront();
            DisplayPanel.SendToBack();
            currentSettingsTab(SoundButton);
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayPanel.Visible = true;
            
            CSchemePanel.SendToBack();
            SoundPanel.SendToBack();
            DisplayPanel.BringToFront();

            currentSettingsTab(DisplayButton);
            currentDisplaySettings();
        }

        private void AddGButton_Click(object sender, EventArgs e)
        {
            AddGPanel.Visible = true;

            AddGPanel.BringToFront();
            RemoveGPanel.SendToBack();
            EditGPanel.SendToBack();

            uncolorG();
            currentGTab(AddGButton);

        }

        private void RemoveGButton_Click(object sender, EventArgs e)
        {
            RemoveGPanel.Visible = true;

            AddGPanel.SendToBack();
            RemoveGPanel.BringToFront();
            EditGPanel.SendToBack();

            uncolorG();
            currentGTab(RemoveGButton);
        }

        private void EditGButton_Click(object sender, EventArgs e)
        {
            EditGPanel.Visible = true;

            AddGPanel.SendToBack();
            RemoveGPanel.SendToBack();
            EditGPanel.BringToFront();

            uncolorG();
            currentGTab(EditGButton);
        }

        private void Genre1G1Info_Click(object sender, EventArgs e)
        {
            SelectedGame = 1;

            GInfoPanel.BringToFront();
            MyGPanel.SendToBack();
            ManageGPanel.SendToBack();
            SettingsPanel.SendToBack();

            GInfoPanel.Visible = true;
            MyGPanel.Visible = false;
            ManageGPanel.Visible = false;
            SettingsPanel.Visible = false;

            MyGSearchLabel.Visible = false;
            MyGSearch.Visible = false;
        }
        //matt's test line

        //functions to change color
        private void currentTab(Button tab)
        {
            uncolorTabs();
            tab.BackColor = Color.Teal;
            tab.ForeColor = Color.WhiteSmoke;
        }

        private void uncolorTabs()
        { 
        MyGButton.BackColor = backC;
        ManageGButton.BackColor = backC;
        SettingsButton.BackColor = backC;

        MyGButton.ForeColor = fontC;
        ManageGButton.ForeColor = fontC;
        SettingsButton.ForeColor = fontC;
        }

        private void currentSettingsTab(Button tab)
        {
            uncolorSettings();
            tab.BackColor = Color.Teal;
            tab.ForeColor = Color.WhiteSmoke;
        }

        private void uncolorSettings()
        {
           CSchemeButton.BackColor = backC;
           SoundButton.BackColor = backC;
           DisplayButton.BackColor = backC;

           CSchemeButton.ForeColor = fontC;
           SoundButton.ForeColor = fontC;
           DisplayButton.ForeColor = fontC;
        }

        private void currentIconTab(Button tab)
        {
            uncolorIconSettings();
            tab.BackColor = Color.Teal;
            tab.ForeColor = Color.WhiteSmoke;
        }

        private void uncolorIconSettings()
        {
            SIcon.BackColor = backC;
           MIcon.BackColor = backC;
            LIcon.BackColor = backC;

            SIcon.ForeColor = fontC;
            MIcon.ForeColor = fontC;
            LIcon.ForeColor = fontC;
        }

        private void currentTextTab(Button tab)
        {
            uncolorTextSettings();
            tab.BackColor = Color.Teal;
            tab.ForeColor = Color.WhiteSmoke;
        }

        private void uncolorTextSettings()
        {
            SText.BackColor = backC;
            MText.BackColor = backC;
            LText.BackColor = backC;

            SText.ForeColor = fontC;
            MText.ForeColor = fontC;
            LText.ForeColor = fontC;
        }

        private void currentGTab(Button tab)
        {
            uncolorG();
            tab.BackColor = Color.Teal;
            tab.ForeColor = Color.WhiteSmoke;
        }

        private void uncolorG()
        {
            AddGButton.BackColor = backC;
            RemoveGButton.BackColor = backC;
            EditGButton.BackColor = backC;

            AddGButton.ForeColor = fontC;
            RemoveGButton.ForeColor = fontC;
            EditGButton.ForeColor = fontC;
        }
        private void uncolorAll()
        {
            uncolorG();
            uncolorTabs();
            uncolorSettings();
            uncolorIconSettings();
            uncolorTextSettings();
        }
        //functions to change color end.
        private void SIcon_Click(object sender, EventArgs e)
        {
            currentIconTab(SIcon);
        }

        private void MIcon_Click(object sender, EventArgs e)
        {
            currentIconTab(MIcon);
        }

        private void LIcon_Click(object sender, EventArgs e)
        {
            currentIconTab(LIcon);

        }

        private void SText_Click(object sender, EventArgs e)
        {
            currentTextTab(SText);
            changeTextSize(12);
        }

        private void MText_Click(object sender, EventArgs e)
        {
            currentTextTab(MText);
            changeTextSize(18);
        }

        private void LText_Click(object sender, EventArgs e)
        {
            currentTextTab(LText);
            changeTextSize(22);
        }

        private void changeTextSize(int FontSize)
        {
            ManageGButton.Font = new Font("Microsoft Sans Serif", FontSize);
            SettingsButton.Font = new Font("Microsoft Sans Serif", FontSize);
            MyGButton.Font = new Font("Microsoft Sans Serif", FontSize);
            CSchemeButton.Font = new Font("Microsoft Sans Serif", FontSize);
            SoundButton.Font = new Font("Microsoft Sans Serif", FontSize);
            DisplayButton.Font = new Font("Microsoft Sans Serif", FontSize);
            AddGButton.Font = new Font("Microsoft Sans Serif", FontSize);
            RemoveGButton.Font = new Font("Microsoft Sans Serif", FontSize);
            EditGButton.Font = new Font("Microsoft Sans Serif", FontSize);
            SIcon.Font = new Font("Microsoft Sans Serif", FontSize);
            MIcon.Font = new Font("Microsoft Sans Serif", FontSize);
            LIcon.Font = new Font("Microsoft Sans Serif", FontSize);
            BackgroundColor.Font = new Font("Microsoft Sans Serif", FontSize);
            FontColor.Font = new Font("Microsoft Sans Serif", FontSize);
            Recommended.Font = new Font("Microsoft Sans Serif", FontSize);
        }

        private void currentDisplaySettings()
        {
            //put if statements for icons here
            currentIconTab(MIcon);
         
         if(AddGButton.Font.Size==small)
         {
             currentTextTab(SText);
         }
         else if (AddGButton.Font.Size == large)
         {
             currentTextTab(LText);
         }
         else
         {
             currentTextTab(MText);
         }
        }
        //background colors

        private void button2_Click(object sender, EventArgs e)
        {
            backC = button2.BackColor;
            uncolorAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backC = button1.BackColor;
            uncolorAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             backC = button3.BackColor;
             uncolorAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             backC = button4.BackColor;
             uncolorAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            backC = button5.BackColor; uncolorAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            backC = button6.BackColor; uncolorAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            backC = button7.BackColor; uncolorAll();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            backC = button8.BackColor; uncolorAll();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            backC = button9.BackColor; uncolorAll();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            backC = button10.BackColor; uncolorAll();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            backC = button11.BackColor; uncolorAll();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            backC = button12.BackColor; uncolorAll();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            backC = button13.BackColor; uncolorAll();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            backC = button14.BackColor; uncolorAll();
        }

        //background colors end

        //font colors

        private void button28_Click(object sender, EventArgs e)
        {
            fontC = button28.BackColor; uncolorAll();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            fontC = button27.BackColor; uncolorAll();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            fontC = button26.BackColor; uncolorAll();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            fontC = button25.BackColor; uncolorAll();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            fontC = button24.BackColor; uncolorAll();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            fontC = button23.BackColor; uncolorAll();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            fontC = button22.BackColor; uncolorAll();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            fontC = button21.BackColor; uncolorAll();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            fontC = button20.BackColor; uncolorAll();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            fontC = button19.BackColor; uncolorAll();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            fontC = button18.BackColor; uncolorAll();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            fontC = button17.BackColor; uncolorAll();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            fontC = button16.BackColor; uncolorAll();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            fontC = button15.BackColor; uncolorAll();
        }
        //font colors end
      
        //presets
        private void button32_Click(object sender, EventArgs e)
        {
            backC = button32.BackColor;
            fontC = button32.ForeColor;
            uncolorAll();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            backC = button31.BackColor;
            fontC = button31.ForeColor;
            uncolorAll();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            backC = button30.BackColor;
            fontC = button30.ForeColor;
            uncolorAll();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            backC = button29.BackColor;
            fontC = button29.ForeColor;
            uncolorAll();
        }

        private void populateGenre(String genre)
        {
            PictureBox[] gamePics = new PictureBox[30];
            Button[] gameiButtons = new Button[30];
            for (int i = 0; i < reader.getGamesList().Count(); i++)
            {
                gamePics[i] = new PictureBox();
                gamePics[i].Size = new Size(104, 109);
                // gamePics[0].Visible = true;
                gamePics[i].BorderStyle = BorderStyle.FixedSingle;


                gameiButtons[i] = new Button();
                gameiButtons[i].Size = new Size(36, 38);
                gameiButtons[i].BackColor = SystemColors.Control;
                //  gameiButtons[0].BorderStyle = BorderStyle.FixedSingle;
                gameiButtons[i].Text = "i";

                gameiButtons[i].Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold | FontStyle.Italic);


                if (genre == "moba")
                {
                    Genre1.Controls.Add(gamePics[i]);
                    Genre1.Controls.Add(gameiButtons[i]);

                    gameiButtons[i].BringToFront();
                    gamePics[i].Location = new Point(Genre1Add.Location.X, Genre1Add.Location.Y);
                    gameiButtons[i].Location = new Point(Genre1Add.Location.X + 81, Genre1Add.Location.Y + 88);
                    Genre1Add.Location = new Point(Genre1Add.Location.X + 144, Genre1Add.Location.Y);
                }
                else if (genre == "shooter")
                {
                    Genre2.Controls.Add(gamePics[i]);
                    Genre2.Controls.Add(gameiButtons[i]);

                    gameiButtons[i].BringToFront();
                    gamePics[i].Location = new Point(Genre2Add.Location.X, Genre2Add.Location.Y);
                    gameiButtons[i].Location = new Point(Genre2Add.Location.X + 81, Genre2Add.Location.Y + 88);
                    Genre2Add.Location = new Point(Genre2Add.Location.X + 144, Genre2Add.Location.Y);
                }
                else if (genre == "fucker")
                {
                    Genre3.Controls.Add(gamePics[i]);
                    Genre3.Controls.Add(gameiButtons[i]);

                    gameiButtons[i].BringToFront();
                    gamePics[i].Location = new Point(Genre3Add.Location.X, Genre3Add.Location.Y);
                    gameiButtons[i].Location = new Point(Genre3Add.Location.X + 81, Genre3Add.Location.Y + 88);
                    Genre3Add.Location = new Point(Genre3Add.Location.X + 144, Genre3Add.Location.Y);
                }
            }
        }
    }
}
