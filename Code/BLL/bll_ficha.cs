using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consulta_Pacientes.Code.DAL;
using Consulta_Pacientes.Code.DTO;
using Consulta_Pacientes.Code.BLL;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace Consulta_Pacientes.Code.BLL
{
    class bll_ficha
    {
        conexao conn = new conexao();
        public void conulta_ficha(dto_ficha dto,DataGridView dgv)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn.conectarBD();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select codpac, proantigo, sistema, nomepac, nomesocial, datanasc, sexo, cpfpac, rgpac, nomemae, nomepai, conjuge, datcadast from cadpac where codpac = '"+ dto.DTO_Prontuario +"' and empresa ='" + dto_menu.select_hosp + "' ORDER BY cadpac.nomepac ASC;";

            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dto.DTO_Prontuario = dr[0].ToString();
                dto.DTO_ProntuarioAntigo = dr[1].ToString();
                dto.DTO_Sistema = dr[2].ToString();
                dto.DTO_Nome = dr[3].ToString();
                dto.DTO_nomeSocial = dr[4].ToString();
                dto.DTO_dataNasc = dr[5].ToString();
                dto.DTO_Sexo = dr[6].ToString();
                dto.DTO_Cpf = dr[7].ToString();
                dto.DTO_Rg = dr[8].ToString();
                dto.DTO_nomeMae = dr[9].ToString();
                dto.DTO_nomePai = dr[10].ToString();
                dto.DTO_nomeConjuge = dr[11].ToString();
                dto.DTO_dataCad = dr[12].ToString();
            }

            dr.Close();

            cmd.CommandText = "select numatend as \"Num. Atendimento\", tipoatend as \"Tipo Atendimento\", datatend as \"Data Atendimento\", datasai as \"Data Alta\", cidprin as \"CID Princ.\", cidsec as \"CID Segund.\" from arqatend where codpac ='" + dto.DTO_Prontuario + "';";
            cmd.CommandType = CommandType.Text;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

            DataTable cliente = new DataTable();
            da.Fill(cliente);
            dgv.DataSource = cliente;


            conn.desconectarBD();
        }
    }
}
