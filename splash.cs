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
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            lblCarregando.Text = "Carregando... " + progressBar.Value.ToString() + "%";

            if (progressBar.Value == 100)
            {
                timer.Enabled = false;

                frm_loginNew login = new frm_loginNew();
                login.Show();

                this.Close();
            }
        }
    }
}
