using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP2A1HotelHeavens
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(lblReserva, "Por favor teclea la hora en la terminaste el CheckIn");
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true; 
            toolTip1.AutoPopDelay = 6000;    
            toolTip1.InitialDelay = 500;     
            toolTip1.ReshowDelay = 200;
        }

        private void lblTipodehabitacion_Click(object sender, EventArgs e)
        {

        }
    }
}
