using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Pacientes
{
    public partial class frm_ajuda : Form
    {
        public frm_ajuda()
        {
            InitializeComponent();
        }

        private void iconPictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.suporte.irmashospitaleiras.org");
        }
    }
}
