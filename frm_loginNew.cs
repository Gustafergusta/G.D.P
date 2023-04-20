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
    public partial class frm_loginNew : Form
    {
        bll_login bll = new bll_login();
        dto_login dto = new dto_login();

        public frm_loginNew()
        {
            InitializeComponent();
            dto_menu.fechar = true;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            dto.DTO_user = txtUser.Text.ToLower();
            dto.DTO_senha = txtSenha.Text;

            // Realizar a verificação do usuário e senha no banco de dados ou em outra fonte de dados
            if (bll.passadados(dto))
            {
                // Se o usuário e senha forem válidos, permitir o acesso à próxima tela
                frm_menuNew telaPrincipal = new frm_menuNew();
                this.Hide();

                telaPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos. Por favor, tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_loginNew_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            dto.DTO_user = txtUser.Text.ToLower();
            dto.DTO_senha = txtSenha.Text;

            if (e.KeyCode == Keys.Enter)
            {
                // Realizar a verificação do usuário e senha no banco de dados ou em outra fonte de dados
                if (bll.passadados(dto))
                {
                    // Se o usuário e senha forem válidos, permitir o acesso à próxima tela
                    frm_menuNew telaPrincipal = new frm_menuNew();
                    this.Hide();
                    telaPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos. Por favor, tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkEmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + "grupo.ti@irmashospitaleiras.org" + "?subject=" + Uri.EscapeDataString("Suporte G.P.D."));
        }

        private void linkGLPI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://irmashospitaleiras.org/glpi");
        }

        private void linlkWhats_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send/?phone=5511976210829&text&type=phone_number&app_absent=0");
        }
    }
}
