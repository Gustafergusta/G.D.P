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
using Consulta_Pacientes.Code.DTO;

namespace Consulta_Pacientes
{
    public partial class frm_menuNew : Form
    {
        bll_menu bll = new bll_menu();
        dto_menu dto = new dto_menu();

        public frm_menuNew()
        {
            InitializeComponent();
            bll.initialize(panelEsquerdo);
            bll.nivelacesso(lblNome, btngerenUser);
        }
        private void picLogo_Click(object sender, EventArgs e)
        {
            bll.Reset(false,icoMenu,lblMenu);
            cbHospital.Enabled = true;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            bll.ActivateButton(sender, bll_menu.RGBColors.color1, icoMenu);
            bll.OpenChildForm(new frm_consulta(), panelForm, lblMenu, bll_menu.RGBColors.color1);
            cbHospital.Enabled = false;
        }

        private void btnDeclaracao_Click(object sender, EventArgs e)
        {
            bll.ActivateButton(sender, bll_menu.RGBColors.color2, icoMenu);
            bll.OpenChildForm(new frm_declara(), panelForm, lblMenu, bll_menu.RGBColors.color2);
            cbHospital.Enabled = false;
        }

        private void btngerenUser_Click(object sender, EventArgs e)
        {
            bll.ActivateButton(sender, bll_menu.RGBColors.color3, icoMenu);
            bll.OpenChildForm(new frm_cadUser(), panelForm, lblMenu, bll_menu.RGBColors.color3);
            cbHospital.Enabled = false;
        }

        private void btnadmUser_Load(object sender, EventArgs e)
        {
            cbHospital.SelectedIndex = 0;
        }

        private void cbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHospital.SelectedIndex == 0) 
            {
                dto_menu.select_hosp = "1";
                btn_info.Image = Properties.Resources.CAMINHO;
            }
            else if (cbHospital.SelectedIndex == 1) 
            { 
                dto_menu.select_hosp = "2";
                btn_info.Image = Properties.Resources.Logo_Fatima_vertical;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o aplicativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto_menu.fechar = false;
                Application.ExitThread();
            }
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de login novamente ou outra tela de login/início de sessão apropriada
            if (MessageBox.Show("Deseja realmente fazer logoff?", "Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_loginNew formLogin = new frm_loginNew();
                formLogin.Show();
                dto_menu.fechar = false;
                this.Close();
            }
        }

        private void frm_menuNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dto_menu.fechar == true)
                if (MessageBox.Show("Deseja realmente fechar o aplicativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            frm_ajuda ajuda = new frm_ajuda();
            ajuda.ShowDialog();
        }
    }
}