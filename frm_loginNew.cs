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
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            dto.DTO_user = txtUser.Text;
            dto.DTO_senha = txtSenha.Text;

            // Realizar a verificação do usuário e senha no banco de dados ou em outra fonte de dados
            if (bll.passadados(dto))
            {
                // Se o usuário e senha forem válidos, permitir o acesso à próxima tela
                btnadmUser telaPrincipal = new btnadmUser();
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
            if (e.KeyCode == Keys.Enter)
            {
                dto.DTO_user = txtUser.Text;
                dto.DTO_senha = txtSenha.Text;

                // Realizar a verificação do usuário e senha no banco de dados ou em outra fonte de dados
                if (bll.passadados(dto))
                {
                    // Se o usuário e senha forem válidos, permitir o acesso à próxima tela
                    btnadmUser telaPrincipal = new btnadmUser();
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

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
