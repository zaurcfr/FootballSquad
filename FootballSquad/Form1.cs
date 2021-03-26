using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;

namespace FootballSquad
{


    public partial class Form1 : Form
    {
        UCPlayer[] uCPlayers = new UCPlayer[11];
        public Form1()
        {
            InitializeComponent();
            countriesCmbbx.DataSource = GetAllCountrysNames();
        }

        public static List<string> GetAllCountrysNames()
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            var rez = cultures.Select(cult => (new RegionInfo(cult.LCID)).DisplayName).Distinct().OrderBy(q => q).ToList();
            return rez;
        }

        public static string GetCountryCode(string countryName)
        {
            var regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
            var englishRegion = regions.FirstOrDefault(region => region.EnglishName.Contains(countryName));
            var countryAbbrev = englishRegion.TwoLetterISORegionName;
            return countryAbbrev;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void countriesCmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormationCmbbx.Enabled = true;
        }

        void CreateFormation(UCPlayer uCPlayer, string position)
        {
            uCPlayer = new UCPlayer();
            uCPlayer.PlayerPosition = position;
            FormationFLP.Controls.Add(uCPlayer);
        }

        private void FormationCmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormationFLP.Controls.Clear();
            if (FormationCmbbx.SelectedIndex == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    CreateFormation(uCPlayers[i], "Forward");
                }
                for (int i = 2; i < 7; i++)
                {
                    CreateFormation(uCPlayers[i], "Midfielder");
                }
                for (int i = 7; i < 10; i++)
                {
                    CreateFormation(uCPlayers[i], "Defender");
                }
            }
            else if (FormationCmbbx.SelectedIndex == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    CreateFormation(uCPlayers[i], "Forward");
                }
                for (int i = 3; i < 6; i++)
                {
                    CreateFormation(uCPlayers[i], "Midfielder");
                }
                for (int i = 6; i < 10; i++)
                {
                    CreateFormation(uCPlayers[i], "Defender");
                }
            }
            else if (FormationCmbbx.SelectedIndex == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    CreateFormation(uCPlayers[i], "Forward");
                }
                for (int i = 2; i < 6; i++)
                {
                    CreateFormation(uCPlayers[i], "Midfielder");
                }
                for (int i = 6; i < 10; i++)
                {
                    CreateFormation(uCPlayers[i], "Defender");
                }
            }
            else if (FormationCmbbx.SelectedIndex == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    CreateFormation(uCPlayers[i], "Forward");
                }
                for (int i = 2; i < 5; i++)
                {
                    CreateFormation(uCPlayers[i], "Midfielder");
                }
                for (int i = 5; i < 10; i++)
                {
                    CreateFormation(uCPlayers[i], "Defender");
                }
            }
            CreateFormation(uCPlayers[10], "Goalkeeper");
            generateBtn.Enabled = true;
        }

        void CreatePlayerJersey(UCShirt uCShirt, int x, int y)
        {
            uCShirt = new UCShirt();
            uCShirt.Location = new Point(x, y);
            uCShirt.PlayerName = "Zaur";
            uCShirt.PlayerNumber = 5;
            this.Controls.Add(uCShirt);
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            FormationFLP.Controls.Clear();
            FormationFLP.Hide();
            panel1.Hide();
            FormationCmbbx.Hide();
            countriesCmbbx.Hide();
            generateBtn.Hide();
            var countryCode = GetCountryCode(countriesCmbbx.SelectedItem.ToString());
            FlagPctrbx.Load($"https://www.countryflags.io/{countryCode}/flat/64.png");
            FlagPctrbx.Visible = true;
            this.BackgroundImage = Properties.Resources.football_pitch;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            UCShirt[] uCShirts = new UCShirt[11];
            int ForwardX = 0;
            int ForwardY = 50;
            int MidfielderX = 0;
            int MidfielderY = 280;
            int DefenderX = 0;
            int DefenderY = 500;
            if (FormationCmbbx.SelectedIndex == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    ForwardX += 170;
                    CreatePlayerJersey(uCShirts[i], ForwardX, ForwardY);
                }
                MidfielderX = -100;
                for (int i = 2; i < 7; i++)
                {
                    MidfielderX += 120;
                    CreatePlayerJersey(uCShirts[i], MidfielderX, MidfielderY);
                }
                for (int i = 7; i < 10; i++)
                {
                    DefenderX += 120;
                    CreatePlayerJersey(uCShirts[i], DefenderX, DefenderY);
                }
            }
            else if (FormationCmbbx.SelectedIndex==1)
            {
                for (int i = 0; i < 3; i++)
                {
                    ForwardX += 125;
                    CreatePlayerJersey(uCShirts[i], ForwardX, ForwardY);
                }
                for (int i = 3; i < 6; i++)
                {
                    MidfielderX += 120;
                    CreatePlayerJersey(uCShirts[i], MidfielderX, MidfielderY);
                }
                DefenderX = -50;
                for (int i = 6; i < 10; i++)
                {
                    DefenderX += 120;
                    CreatePlayerJersey(uCShirts[i], DefenderX, DefenderY);
                }
            }
            else if (FormationCmbbx.SelectedIndex==2)
            {
                for (int i = 0; i < 2; i++)
                {
                    ForwardX += 170;
                    CreatePlayerJersey(uCShirts[i], ForwardX, ForwardY);
                }
                MidfielderX = -50;
                for (int i = 2; i < 6; i++)
                {
                    MidfielderX += 120;
                    CreatePlayerJersey(uCShirts[i], MidfielderX, MidfielderY);
                }
                DefenderX = -50;
                for (int i = 6; i < 10; i++)
                {
                    DefenderX += 120;
                    CreatePlayerJersey(uCShirts[i], DefenderX, DefenderY);
                }
            }
            else if (FormationCmbbx.SelectedIndex==3)
            {
                for (int i = 0; i < 2; i++)
                {
                    ForwardX += 170;
                    CreatePlayerJersey(uCShirts[i], ForwardX, ForwardY);
                }
                for (int i = 2; i < 5; i++)
                {
                    MidfielderX += 120;
                    CreatePlayerJersey(uCShirts[i], MidfielderX, MidfielderY);
                }
                DefenderX = -100;
                for (int i = 5; i < 10; i++)
                {
                    DefenderX += 120;
                    CreatePlayerJersey(uCShirts[i], DefenderX, DefenderY);
                }
            }
            CreatePlayerJersey(uCShirts[10], 250, 650);
        }
    }
}
