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
    public partial class frm_splashGrid : Form
    {
        public frm_splashGrid()
        {
            InitializeComponent();
        }

        private void timerGrid_Tick(object sender, EventArgs e)
        {
            progressBarGrid.Value += 1;

            if (progressBarGrid.Value == 100)
            {
                progressBarGrid.Value = 0;
            }
        }
    }
}
