using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consulta_Pacientes.Code.DAL;
using Consulta_Pacientes.Code.BLL;
using Consulta_Pacientes.Code.DTO;
using BCrypt;

namespace Consulta_Pacientes
{
    public partial class frm_cadUser : Form
    {
        conexao conn = new conexao();
        bll_users bll = new bll_users();
        dto_users dto = new dto_users();

        public frm_cadUser()
        {
            InitializeComponent();
        }

        private void frm_cadUser_Load(object sender, EventArgs e)
        {
            bll.telaini(txtNome,txtSenha,txtSenha2,txtUser,cbDpto,cbPerfil,btnAcao,cbNomeUsers, btnAtualizar,btnExcluir);
            bll.preencheCb(cbNomeUsers);
            btnExcluir.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            bll.telacad(txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir,lblcod);
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bll.telacance(txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir,panelUser,btnNovo,lblcod);
            btnExcluir.Enabled = false;
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (btnAcao.Text == "Cadastrar")
            {
                dto.DTO_nomeuser = txtNome.Text;
                dto.DTO_nomelogin = txtUser.Text;
                dto.DTO_dpto = cbDpto.Text;
                dto.DTO_peril = cbPerfil.Text;
                if (txtSenha.Text == txtSenha2.Text) 
                {
                    string senhaCripto = BCrypt.Net.BCrypt.HashPassword(txtSenha.Text);
                    dto.DTO_senha = senhaCripto;                   
                }
                else { MessageBox.Show("As Senhas Não Coincidem.", "Verificar a Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

                bll.caduser(dto, panelUser, txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir, lblcod);
            }

            if (btnAcao.Text == "Atualizar")
            {
                dto.DTO_nomeuser = txtNome.Text;
                dto.DTO_nomelogin = txtUser.Text;
                dto.DTO_dpto = cbDpto.Text;
                dto.DTO_peril = cbPerfil.Text;
                dto.DTO_coduser = Convert.ToInt32(lblcod.Text);

                if (txtSenha.Text == ";;;")
                {
                    bll.uptadeuserssenha(dto, panelUser, txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir, lblcod);
                }
                else if (txtSenha.Text == txtSenha2.Text)
                {
                    string senhaCripto = BCrypt.Net.BCrypt.HashPassword(txtSenha.Text);
                    dto.DTO_senha = senhaCripto;
                    bll.uptadeuser(dto, panelUser, txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir, lblcod);
                }
                else { MessageBox.Show("As Senhas Não Coincidem.", "Verificar a Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }

        private void cbNomeUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dto.DTO_nomeuser = cbNomeUsers.Text;

            cbNomeUsers.Text = "";
            btnNovo.Enabled = false;
            btnExcluir.Enabled = true;

            bll.consultauser(dto, txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil,lblcod);
            btnAtualizar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            bll.telaatu(txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir, btnNovo);
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dto.DTO_coduser = Convert.ToInt32(lblcod.Text);
            
            bll.deleteuser(dto);
            bll.telaini(txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir);
            cbNomeUsers.Items.Clear();
            bll.preencheCb(cbNomeUsers);

            conn.limpa(frm_cadUser.ActiveForm);
            conn.limpapainel(panelUser.Controls);
            lblcod.Text = "";
            cbNomeUsers.Text = "";
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == ";;;") { txtSenha.Text = ""; txtSenha2.Text = ""; txtSenha.Focus(); }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "") { txtSenha.Text = ";;;"; txtSenha2.Text = ";;;"; }
        }
    }
}
