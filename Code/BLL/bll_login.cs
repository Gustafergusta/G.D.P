using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using Consulta_Pacientes.Code.DAL;
using Consulta_Pacientes.Code.DTO;
using BCrypt;

namespace Consulta_Pacientes.Code.BLL
{
    class bll_login
    {
        conexao conn = new conexao();
        string loginbd, senhabd;

        public bool passadados(dto_login dto)
        {
            return VerificarUsuario(dto);
        }

        private bool VerificarUsuario(dto_login dto)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT senha_user, perfil_user, nomecom_user FROM users WHERE login_user = @login", conn.conectarBD()))
            {
                cmd.Parameters.AddWithValue("@login", dto.DTO_user);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Atribuir os dados do colaborador aos campos correspondentes                       
                        senhabd = reader["senha_user"].ToString();
                        dto.DTO_perfil = reader["perfil_user"].ToString();
                        dto.DTO_NomeCompleto = reader["nomecom_user"].ToString();
                        return BCrypt.Net.BCrypt.Verify(dto.DTO_senha, senhabd);
                    }
                    else 
                    {
                        return false;
                    }
                }  
                conn.desconectarBD();
            }
        }

    }
}
