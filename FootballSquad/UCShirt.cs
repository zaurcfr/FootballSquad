using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballSquad
{
    public partial class UCShirt : UserControl
    {
        public string PlayerName { get; set; }
        public int PlayerNumber { get; set; }

        public UCShirt()
        {
            InitializeComponent();
        }

        private void UCShirt_Load(object sender, EventArgs e)
        {
            PlayerNameLbl.Text = PlayerName;
            PlayerNumberLbl.Text = PlayerNumber.ToString();
        }
    }
}
