using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP2A1HotelHeavens
{
    public partial class CheckIn : Form
    {
        string tradicinal = "", suit = "", presidencial = "";
        RadioButton[] select;
        public CheckIn()
        {
            InitializeComponent();

            select=new RadioButton[]{radHabNormal,radHabPresidencial,radHabSuit};
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(lblReserva, "Por favor teclea la hora en la terminaste el CheckIn");
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            dtpHoraReserva.Format = DateTimePickerFormat.Time;
            dtpHoraReserva.ShowUpDown = true;
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.ShowUpDown = true;
        }

        private void lblTipodehabitacion_Click(object sender, EventArgs e)
        {

        }

        private void radHabSuit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dtpInicioEstancia.Value = monthCalendar1.SelectionRange.Start;
            dtpFinaldeEstancia.Value = monthCalendar1.SelectionRange.End;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre,  horadellegada, horadesalida, adultos, menores, diadellegada,diadesalida,a;
            nombre = txtNombre.Text;
            horadellegada = dtpHoraReserva.Text.ToString();
            horadesalida = dtpHoraSalida.Text.ToString();
            adultos = numericUpDown1.Value.ToString();
            menores = numericUpDown2.Value.ToString();
            if (radHabNormal.Checked)
            {
                tradicinal = "Tradicional";
            }
            else if (radHabSuit.Checked)
            {
                suit = "Suite";
            }
            else if (radHabPresidencial.Checked)
            {
                presidencial = "Presidencial";
            }
            diadellegada = dtpInicioEstancia.Value.ToString("dd/MM/yyyy");
            diadesalida = dtpFinaldeEstancia.Value.ToString("dd/MM/yyyy");

            string si=verify();

            if(!string.IsNullOrEmpty(si))
            {
                MessageBox.Show($"Te falta \n {si}");
            }
            else
            {
                
                txtNombre.Clear();
                numericUpDown1.Value=numericUpDown1.Minimum;
                numericUpDown2.Value=numericUpDown2.Minimum;

                dtpHoraSalida.Value = DateTime.Today.AddHours(00);
                dtpHoraReserva.Value = DateTime.Today.AddHours(00);

                monthCalendar1.SelectionStart=DateTime.Today;
                foreach (RadioButton simon in select)
                {
                    simon.Checked = false;
                }

                notifyIcon1.BalloonTipTitle = "Check_In";
                notifyIcon1.BalloonTipText = "Reistro Completado";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }
        private string verify()
        {
            string llenado = "";
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                llenado += "- Nombre del huésped\n";
            }
            if (!radHabNormal.Checked && !radHabSuit.Checked && !radHabPresidencial.Checked)
            {
                llenado += "- Tipo de habitación\n";
            }
            if (string.IsNullOrEmpty(dtpHoraReserva.Text) || dtpHoraReserva.Text.Contains("_"))
            {
                llenado += "- Hora de llegada\n";
            }
            if(dtpHoraReserva.Value.Hour<1 || dtpHoraReserva.Value.Hour >24)
            {
                llenado += "- Hora de llegada fuera del rango";
            }
            if (string.IsNullOrEmpty(dtpHoraSalida.Text) || dtpHoraSalida.Text.Contains("_"))
            {
                llenado += "- Hora de salida\n";
            }
            if(dtpHoraSalida.Value.Hour<1 || dtpHoraSalida.Value.Hour>24)
            {
                llenado += "- Hora salida fuera del rango";
            }

            
            return llenado;

        }
    }
}
