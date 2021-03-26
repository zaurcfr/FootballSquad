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
    public partial class UCPlayer : UserControl
    {
        public string PlayerPosition { get; set; }

        public UCPlayer()
        {
            InitializeComponent();
        }

        private void UCPlayer_Load(object sender, EventArgs e)
        {
            PositionLbl.Text = PlayerPosition;
        }
        

    }
}
