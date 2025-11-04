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
    public partial class Control_de_Jefes : Form
    {
        public Control_de_Jefes()
        {
            InitializeComponent();
        }

        private void Control_de_Jefes_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void lblNuevoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
