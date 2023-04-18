using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consulta_Pacientes.Code.BLL;

namespace Consulta_Pacientes
{
    public partial class btnadmUser : Form
    {
        bll_menu bll = new bll_menu();

        public btnadmUser()
        {
            InitializeComponent();
            bll.initialize(panelEsquerdo);
        }
        private void picLogo_Click(object sender, EventArgs e)
        {
            bll.Reset(false,icoMenu,lblMenu);
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            bll.ActivateButton(sender, bll_menu.RGBColors.color1, icoMenu);
            bll.OpenChildForm(new frm_consulta(), panelForm, lblMenu, bll_menu.RGBColors.color1);
        }

        private void btnDeclaracao_Click(object sender, EventArgs e)
        {
            bll.ActivateButton(sender, bll_menu.RGBColors.color2, icoMenu);
            bll.OpenChildForm(new frm_declara(), panelForm, lblMenu, bll_menu.RGBColors.color2);
        }

        private void btngerenUser_Click(object sender, EventArgs e)
        {
            bll.ActivateButton(sender, bll_menu.RGBColors.color3, icoMenu);
            bll.OpenChildForm(new frm_cadUser(), panelForm, lblMenu, bll_menu.RGBColors.color3);
        }
    }
}
