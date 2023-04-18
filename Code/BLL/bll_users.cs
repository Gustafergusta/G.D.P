using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using Consulta_Pacientes.Code.DAL;
using Consulta_Pacientes.Code.DTO;

namespace Consulta_Pacientes.Code.BLL
{
    class bll_users
    {
        conexao conn = new conexao();

        public void preencheCb(ComboBox cb)
        {
            string sql = "select nomecom_user from users ORDER BY nomecom_user ASC";
            NpgsqlCommand command = new NpgsqlCommand(sql, conn.conectarBD());
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader.GetString(0);
                cb.Items.Add(nome);
            }

            reader.Close();
            conn.desconectarBD();
        }

        public void caduser(dto_users dto, Panel panel, TextBox txtNome, TextBox txtSenha, TextBox txtSenha2, TextBox txtUser, ComboBox cbDpto, ComboBox cbPerfil, Button btnAcao, ComboBox cbNomeUsers, Button btnAtualizar, Button btnExcluir, Label lblcod)
        {
            // Verificar se o nome de login já existe
            using (NpgsqlCommand checkCmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE login_user = @login_user", conn.conectarBD()))
            {
                checkCmd.Parameters.AddWithValue("@login_user", dto.DTO_nomelogin);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("O nome de login informado já existe. Por favor, escolha outro nome de login.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // ou faça alguma outra ação, dependendo do seu caso
                }
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO users (nomecom_user, depart_user, login_user, senha_user, perfil_user) VALUES (@nome_user, @dpto_user, @login_user, @senha_user, @perfil_user)", conn.conectarBD()))
            {
                cmd.Parameters.AddWithValue("@nome_user", dto.DTO_nomeuser);
                cmd.Parameters.AddWithValue("@dpto_user", dto.DTO_dpto);
                cmd.Parameters.AddWithValue("@login_user", dto.DTO_nomelogin);
                cmd.Parameters.AddWithValue("@senha_user", dto.DTO_senha);
                cmd.Parameters.AddWithValue("@perfil_user", dto.DTO_peril);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário Cadastrado com sucesso!", "Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            cbNomeUsers.Items.Clear();

            preencheCb(cbNomeUsers);

            telaini(txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir);

            conn.limpa(frm_cadUser.ActiveForm);
            conn.limpapainel(panel.Controls);
            lblcod.Text = "";
        }

        public void uptadeuser(dto_users dto, Panel panel, TextBox txtNome, TextBox txtSenha, TextBox txtSenha2, TextBox txtUser, ComboBox cbDpto, ComboBox cbPerfil, Button btnAcao, ComboBox cbNomeUsers, Button btnAtualizar, Button btnExcluir,Label lblcod)
        {
            // Verificar se o nome de login já existe
            using (NpgsqlCommand checkCmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE login_user = @login_user AND coduser != @coduser", conn.conectarBD()))
            {
                checkCmd.Parameters.AddWithValue("@login_user", dto.DTO_nomelogin);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("O nome de login informado já existe. Por favor, escolha outro nome de login.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // ou faça alguma outra ação, dependendo do seu caso
                }
                conn.desconectarBD();
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE users SET nomecom_user=@nome ,depart_user=@depart, login_user=@login, senha_user=@senha, perfil_user=@perfi WHERE coduser=@coduser", conn.conectarBD()))
            {
                cmd.Parameters.AddWithValue("@nome", dto.DTO_nomeuser);
                cmd.Parameters.AddWithValue("@depart", dto.DTO_dpto);
                cmd.Parameters.AddWithValue("@login", dto.DTO_nomelogin);
                cmd.Parameters.AddWithValue("@senha", dto.DTO_senha);
                cmd.Parameters.AddWithValue("@perfi", dto.DTO_peril);
                cmd.Parameters.AddWithValue("@coduser", dto.DTO_coduser);

                cmd.ExecuteNonQuery();
                conn.desconectarBD();
                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            cbNomeUsers.Items.Clear();

            preencheCb(cbNomeUsers);

            telaini(txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir);
            conn.limpa(frm_cadUser.ActiveForm);
            conn.limpapainel(panel.Controls);
            cbNomeUsers.Text = "";
            lblcod.Text = "";
        }

        public void uptadeuserssenha(dto_users dto, Panel panel, TextBox txtNome, TextBox txtSenha, TextBox txtSenha2, TextBox txtUser, ComboBox cbDpto, ComboBox cbPerfil, Button btnAcao, ComboBox cbNomeUsers, Button btnAtualizar, Button btnExcluir, Label lblcod)
        {
            // Verificar se o nome de login já existe
            using (NpgsqlCommand checkCmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE login_user = @login_user AND coduser != @coduser", conn.conectarBD()))
            {
                checkCmd.Parameters.AddWithValue("@login_user", dto.DTO_nomelogin);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("O nome de login informado já existe. Por favor, escolha outro nome de login.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // ou faça alguma outra ação, dependendo do seu caso
                }
                conn.desconectarBD();
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE users SET nomecom_user=@nome ,depart_user=@depart, login_user=@login, perfil_user=@perfi WHERE coduser=@coduser", conn.conectarBD()))
            {
                cmd.Parameters.AddWithValue("@nome", dto.DTO_nomeuser);
                cmd.Parameters.AddWithValue("@depart", dto.DTO_dpto);
                cmd.Parameters.AddWithValue("@login", dto.DTO_nomelogin);
                cmd.Parameters.AddWithValue("@perfi", dto.DTO_peril);
                cmd.Parameters.AddWithValue("@coduser", dto.DTO_coduser);

                cmd.ExecuteNonQuery();
                conn.desconectarBD();
                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cbNomeUsers.Items.Clear();

            preencheCb(cbNomeUsers);

            telaini(txtNome, txtSenha, txtSenha2, txtUser, cbDpto, cbPerfil, btnAcao, cbNomeUsers, btnAtualizar, btnExcluir);
            conn.limpa(frm_cadUser.ActiveForm);
            conn.limpapainel(panel.Controls);
            cbNomeUsers.Text = "";
            lblcod.Text = "";
        }

        public void deleteuser(dto_users dto)
        {
            if (MessageBox.Show("Deseja deletar o usuário?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM users WHERE coduser=@coduser", conn.conectarBD());
                cmd.Parameters.AddWithValue("@coduser", dto.DTO_coduser);
                
                cmd.ExecuteNonQuery();
                conn.desconectarBD();

                MessageBox.Show("Usuário Deletado com Sucesso!", "Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        public void consultauser(dto_users dto, TextBox txtNome, TextBox txtSenha, TextBox txtSenha2, TextBox txtUser, ComboBox cbDpto, ComboBox cbPerfil, Label lblcod)
        {
            // Buscar os dados do colaborador no banco de dados
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT coduser, nomecom_user, depart_user, login_user, perfil_user FROM users WHERE nomecom_user = @nomecom_user", conn.conectarBD()))
            {
                cmd.Parameters.AddWithValue("@nomecom_user", dto.DTO_nomeuser);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Atribuir os dados do colaborador aos campos correspondentes
                        lblcod.Text = reader["coduser"].ToString();
                        txtNome.Text = reader["nomecom_user"].ToString();
                        cbDpto.Text = reader["depart_user"].ToString();
                        txtUser.Text = reader["login_user"].ToString();
                        txtSenha.Text = ";;;";
                        txtSenha2.Text = ";;;";
                        cbPerfil.Text = reader["perfil_user"].ToString();
                    }
                }
            }
        }

        public void telaini(TextBox txtNome,TextBox txtSenha,TextBox txtSenha2,TextBox txtUser,ComboBox cbDpto,ComboBox cbPerfil,Button btnAcao, ComboBox cbNomeUsers, Button btnAtualizar, Button btnExcluir)
        {
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtSenha2.Enabled = false;
            txtUser.Enabled = false;
            cbDpto.Enabled = false;
            cbPerfil.Enabled = false;
                        
            //BOTOES
            cbNomeUsers.Enabled = true; // BTN CAD
            btnAtualizar.Enabled = false; // BTN ATUALIZAR
            btnExcluir.Enabled = true; // BTN EXCLUIR

            btnAcao.Visible = false; // BTN AÇÃO (VISIBILIDADE)
            btnAcao.Text = ""; // BTN AÇÃO (TEXTO)
            btnAcao.Visible = false;
        }

        public void telacad(TextBox txtNome, TextBox txtSenha, TextBox txtSenha2, TextBox txtUser, ComboBox cbDpto, ComboBox cbPerfil, Button btnAcao,ComboBox cbNomeUsers,Button btnAtualizar,Button btnExcluir, Label lblcod)
        {
            //CAMPO ID
            lblcod.Text = "Definada Após o Cadastro.";

            //CAMPOS DE TEXTO
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtSenha2.Enabled = true;
            txtUser.Enabled = true;
            cbDpto.Enabled = true;
            cbPerfil.Enabled = true;
            txtNome.Focus();

            //BOTOES
            cbNomeUsers.Enabled = false; // BTN CAD
            btnAtualizar.Enabled = false; // BTN ATUALIZAR
            btnExcluir.Enabled = false; // BTN EXCLUIR
            btnAcao.Visible = true; // BTN AÇÃO (VISIBILIDADE)
            btnAcao.Text = "Cadastrar"; // BTN AÇÃO (TEXTO)
        }

        public void telacance(TextBox txtNome, TextBox txtSenha, TextBox txtSenha2, TextBox txtUser, ComboBox cbDpto, ComboBox cbPerfil, Button btnAcao, ComboBox cbNomeUsers, Button btnAtualizar, Button btnExcluir, Panel panelUser, Button btnNovo, Label lblcod)
        {
            //CAMPOS DE TEXTO
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtSenha2.Enabled = false;
            txtUser.Enabled = false;
            cbDpto.Enabled = false;
            cbPerfil.Enabled = false;
            lblcod.Text = "";

            //BOTOES
            cbNomeUsers.Enabled = true; // BTN CAD
            cbNomeUsers.Text = ""; // BTN CAD TEXTO
            btnAtualizar.Enabled = false; // BTN ATUALIZAR
            btnExcluir.Enabled = true; // BTN EXCLUIR
            btnAcao.Visible = false; // BTN AÇÃO (VISIBILIDADE)
            btnAcao.Text = ""; // BTN AÇÃO (TEXTO)
            btnNovo.Enabled = true;

            conn.limpapainel(panelUser.Controls);
            conn.limpa(frm_loginNew.ActiveForm);
        }

        public void telaatu(TextBox txtNome, TextBox txtSenha, TextBox txtSenha2, TextBox txtUser, ComboBox cbDpto, ComboBox cbPerfil, Button btnAcao, ComboBox cbNomeUsers, Button btnAtualizar, Button btnExcluir, Button btnNovo)
        {
            if (cbNomeUsers.Text == "") { MessageBox.Show("Selecione um usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);cbNomeUsers.Focus(); }
            else {
                        txtNome.Enabled = true;
                        txtSenha.Enabled = true;
                        txtSenha2.Enabled = true;
                        txtUser.Enabled = true;
                        cbDpto.Enabled = true;
                        cbPerfil.Enabled = true;

                        //BOTOES
                        cbNomeUsers.Enabled = false; // BTN CAD
                        btnAtualizar.Enabled = false; // BTN ATUALIZAR
                        btnExcluir.Enabled = false; // BTN EXCLUIR
                        btnNovo.Enabled = false; // BTN NOVO

                        btnAcao.Visible = true; // BTN AÇÃO (VISIBILIDADE)
                        btnAcao.Text = "Atualizar"; // BTN AÇÃO (TEXTO)
                    }
        }

    }
}
