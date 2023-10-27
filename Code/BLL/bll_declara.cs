using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;
using Consulta_Pacientes.Code.DAL;
using Consulta_Pacientes.Code.DTO;

namespace Consulta_Pacientes.Code.BLL
{
    class bll_declara
    {
        conexao conn = new conexao();
        
        public bool preencheCb(ComboBox cb)
        {
            try
            { 
                string sql = "select nomepac from CADPAC where empresa = '" + dto_menu.select_hosp + "' ORDER BY nomepac ASC";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn.conectarBD());
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string nome = dr.GetString(0);
                    cb.Invoke(new Action(() =>
                    {
                        cb.Items.Add(nome);
                    }));
                    
                }

                dr.Close();
                cmd.Dispose();

                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.desconectarBD();
            }
        }

        public void preenchePront(ComboBox cb, TextBox pront)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn.conectarBD();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select codpac from CADPAC where nomepac = '" + cb.Text + "' and empresa = '" + dto_menu.select_hosp + "'";
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        string prontuario = dr.GetString(0);
                        pront.Text = prontuario.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Prontuário não encontrado. Favor digitar o prontuário.");
                }

                dr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.desconectarBD();
            }
        }

        public void preencheNome(ComboBox cb, TextBox a)
        {
            try
            {
                if (a.Text != "")
                {
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn.conectarBD();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select nomepac from CADPAC where codpac = '" + a.Text + "' and empresa = '" + dto_menu.select_hosp + "'";
                    NpgsqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            string nome = dr.GetString(0);
                            cb.Items.Add(nome);
                            dto_declara.DTOVerifica = true;
                            cb.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Prontuário não encontrado. Favor buscar pelo nome.");
                    }
                    dr.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.desconectarBD();
            }
        }
//===================================================================================================================================================
        public DataTable RelaCCID (dto_declara dto)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT cadpac.codpac, arqatend.numatend, arqatend.tipoatend, arqatend.datatend, arqatend.datasai, arqatend.cidprin, arqatend.cidsec FROM arqatend INNER JOIN cadpac ON arqatend.codpac = cadpac.codpac WHERE cadpac.codpac = '" + dto.DTO_pront + "' AND cadpac.empresa = '" + dto_menu.select_hosp.ToString() + "' ORDER BY arqatend.datatend ASC;", conn.conectarBD());
                da.Fill(tabela);
                
                da.Dispose();

                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.desconectarBD();
            }
        }

        public DataTable RelaSCID(dto_declara dto)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT cadpac.codpac, arqatend.numatend, arqatend.tipoatend, arqatend.datatend, arqatend.datasai FROM arqatend INNER JOIN cadpac ON arqatend.codpac = cadpac.codpac WHERE cadpac.codpac = '" + dto.DTO_pront + "' AND cadpac.empresa = '" + dto_menu.select_hosp.ToString() + "' ORDER BY arqatend.datatend ASC;", conn.conectarBD());
                da.Fill(tabela);
                
                da.Dispose();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.desconectarBD();
            }
        }
    }
}
