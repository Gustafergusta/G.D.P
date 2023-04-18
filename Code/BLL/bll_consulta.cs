using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consulta_Pacientes.Code.DAL;
using Consulta_Pacientes.Code.DTO;
using Npgsql;
using System.Windows.Forms;
using System.Data;


namespace Consulta_Pacientes.Code.BLL
{
    class bll_consulta
    {
        conexao conn = new conexao();
        dto_menu dto = new dto_menu();

        public void listaGrid(DataGridView dg,Label lbl)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn.conectarBD();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cadpac.sistema as \"Sistema\", cadpac.nomepac as \"Nome\", cadpac.nomesocial as \"Nome Social\", cadpac.codpac as \"Prontuário\", cadpac.proantigo as \"Prontuário Ant.\", cadpac.cpfpac as \"CPF\", cadpac.rgpac as \"RG\", cadpac.cartaosus as \"Cartão SUS\", cadpac.sexo as \"Sexo\", cadpac.datanasc as \"Data Nascimento\", cadpac.nomepai as \"Nome Pai\", cadpac.nomemae as \"Nome Mãe\", cadpac.conjuge as \"Nome Conjuge\" from cadpac where empresa = '" + dto_menu.select_hosp + "' ORDER BY cadpac.nomepac ASC;";
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                lbl.Visible = false;
                DataTable dt = new DataTable();
                dt.Load(dr);
                dg.DataSource = dt;
                dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            else
            {
                lbl.Visible = true;
                lbl.Text = "Não existem dados para serem exibido.";
            }
            cmd.Dispose();
            conn.desconectarBD();                
        }
        public void consultanome(DataGridView dgv,TextBox a)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select cadpac.sistema as \"Sistema\", cadpac.nomepac as \"Nome\", cadpac.nomesocial as \"Nome Social\", cadpac.codpac as \"Prontuário\", cadpac.proantigo as \"Prontuário Ant.\", cadpac.cpfpac as \"CPF\", cadpac.rgpac as \"RG\", cadpac.cartaosus as \"Cartão SUS\", cadpac.sexo as \"Sexo\", cadpac.datanasc as \"Data Nascimento\", cadpac.nomepai as \"Nome Pai\", cadpac.nomemae as \"Nome Mãe\", cadpac.conjuge as \"Nome Conjuge\" from cadpac where nomepac LIKE '%" + a.Text + "%' AND empresa = '" + dto_menu.select_hosp + "' ORDER BY cadpac.nomepac ASC;", conn.conectarBD());
            cmd.CommandType = CommandType.Text;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            
            DataTable cliente = new DataTable();
            da.Fill(cliente);
            dgv.DataSource = cliente;
            conn.desconectarBD();
        }
        public void consultaCPF(DataGridView dgv, string a)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select cadpac.sistema as \"Sistema\", cadpac.nomepac as \"Nome\", cadpac.nomesocial as \"Nome Social\", cadpac.codpac as \"Prontuário\", cadpac.proantigo as \"Prontuário Ant.\", cadpac.cpfpac as \"CPF\", cadpac.rgpac as \"RG\", cadpac.cartaosus as \"Cartão SUS\", cadpac.sexo as \"Sexo\", cadpac.datanasc as \"Data Nascimento\", cadpac.nomepai as \"Nome Pai\", cadpac.nomemae as \"Nome Mãe\", cadpac.conjuge as \"Nome Conjuge\" from cadpac where CAST(cpfpac AS TEXT) LIKE '%" + a + "%' AND empresa = '" + dto_menu.select_hosp + "' ORDER BY cadpac.nomepac ASC;", conn.conectarBD());
            cmd.CommandType = CommandType.Text;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable cliente = new DataTable();
            da.Fill(cliente);
            dgv.DataSource = cliente;
            conn.desconectarBD();
        }
        public void consultarg(DataGridView dgv, TextBox a)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select cadpac.sistema as \"Sistema\", cadpac.nomepac as \"Nome\", cadpac.nomesocial as \"Nome Social\", cadpac.codpac as \"Prontuário\", cadpac.proantigo as \"Prontuário Ant.\", cadpac.cpfpac as \"CPF\", cadpac.rgpac as \"RG\", cadpac.cartaosus as \"Cartão SUS\", cadpac.sexo as \"Sexo\", cadpac.datanasc as \"Data Nascimento\", cadpac.nomepai as \"Nome Pai\", cadpac.nomemae as \"Nome Mãe\", cadpac.conjuge as \"Nome Conjuge\" from cadpac where rgpac LIKE '%" + a.Text + "%' AND empresa = '" + dto_menu.select_hosp + "' ORDER BY cadpac.nomepac ASC;", conn.conectarBD());
            cmd.CommandType = CommandType.Text;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

            DataTable cliente = new DataTable();
            da.Fill(cliente);
            dgv.DataSource = cliente;
            conn.desconectarBD();
        }
        public void consultaDTNas(DataGridView dgv, string a)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select cadpac.sistema as \"Sistema\", cadpac.nomepac as \"Nome\", cadpac.nomesocial as \"Nome Social\", cadpac.codpac as \"Prontuário\", cadpac.proantigo as \"Prontuário Ant.\", cadpac.cpfpac as \"CPF\", cadpac.rgpac as \"RG\", cadpac.cartaosus as \"Cartão SUS\", cadpac.sexo as \"Sexo\", cadpac.datanasc as \"Data Nascimento\", cadpac.nomepai as \"Nome Pai\", cadpac.nomemae as \"Nome Mãe\", cadpac.conjuge as \"Nome Conjuge\" from cadpac where CAST(datanasc AS TEXT) LIKE '%" + a + "%' AND empresa = '" + dto_menu.select_hosp + "' ORDER BY cadpac.nomepac ASC;", conn.conectarBD());
            cmd.CommandType = CommandType.Text;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable cliente = new DataTable();
            da.Fill(cliente);
            dgv.DataSource = cliente;
            conn.desconectarBD();
        }
        public void consultapront(DataGridView dgv, TextBox a)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select cadpac.sistema as \"Sistema\", cadpac.nomepac as \"Nome\", cadpac.nomesocial as \"Nome Social\", cadpac.codpac as \"Prontuário\", cadpac.proantigo as \"Prontuário Ant.\", cadpac.cpfpac as \"CPF\", cadpac.rgpac as \"RG\", cadpac.cartaosus as \"Cartão SUS\", cadpac.sexo as \"Sexo\", cadpac.datanasc as \"Data Nascimento\", cadpac.nomepai as \"Nome Pai\", cadpac.nomemae as \"Nome Mãe\", cadpac.conjuge as \"Nome Conjuge\" from cadpac where CAST(codpac AS TEXT) LIKE '%" + a.Text + "%' AND empresa = '" + dto_menu.select_hosp + "' ORDER BY cadpac.nomepac ASC;", conn.conectarBD());
            cmd.CommandType = CommandType.Text;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable cliente = new DataTable();
            da.Fill(cliente);
            dgv.DataSource = cliente;
            conn.desconectarBD();
        }
    }
}
