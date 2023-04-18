using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Pacientes.Code.DTO
{
    class dto_users
    {
        private static string DTOnomelogin;
        private static string DTOsenha;
        private static string DTOnomeuser;
        private static string DTOdpto;
        private static string DTOperil;
        private static int DTOcoduser;
        public int DTO_coduser
        {
            set { DTOcoduser = value; }

            get { return DTOcoduser; }
        }

        public string DTO_nomelogin
        {
            set { DTOnomelogin = value; }

            get { return DTOnomelogin; }
        }
        public string DTO_senha
        {
            set { DTOsenha = value; }

            get { return DTOsenha; }
        }
        public string DTO_nomeuser
        {
            set { DTOnomeuser = value; }

            get { return DTOnomeuser; }
        }
        public string DTO_dpto
        {
            set { DTOdpto = value; }

            get { return DTOdpto; }
        }public string DTO_peril
        {
            set { DTOperil = value; }

            get { return DTOperil; }
        }
    }
}
