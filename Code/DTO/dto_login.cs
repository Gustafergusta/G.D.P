using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Pacientes.Code.DTO
{
    class dto_login
    {
        private static string DTOuser;
        private static string DTOsenha;
        private static string DTOnomeCompleto;
        private static string DTOperfil;
        public string DTO_user
        {
            set { DTOuser = value; }

            get { return DTOuser; }
        }
        public string DTO_perfil
        {
            set { DTOperfil = value; }

            get { return DTOperfil; }
        }

        public string DTO_NomeCompleto
        {
            set { DTOnomeCompleto = value; }

            get { return DTOnomeCompleto; }
        }

        public string DTO_senha
        {
            set { DTOsenha = value; }

            get { return DTOsenha; }
        }
       
    }
}
