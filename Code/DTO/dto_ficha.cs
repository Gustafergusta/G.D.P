using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Pacientes.Code.DTO
{
    class dto_ficha
    {
        private static string DTOProntuario;
        private static string DTOprontAntigo;
        private static string DTOSistema;
        private static string DTONome;
        private static string DTOnomeSocial;
        private static string DTOdataNasc;
        private static string DTOSexo;
        private static string DTOCpf;
        private static string DTORg;
        private static string DTOnomeMae;
        private static string DTOnomePai;
        private static string DTOnomeConjuge; 
        private static string DTOdataCad;
        public string DTO_Prontuario
        {
            set { DTOProntuario = value; }

            get { return DTOProntuario; }
        }
        public string DTO_ProntuarioAntigo
        {
            set { DTOprontAntigo = value; }

            get { return DTOprontAntigo; }
        }
        public string DTO_Sistema
        {
            set { DTOSistema = value; }

            get { return DTOSistema; }
        }
        public string DTO_Nome
        {
            set { DTONome = value; }

            get { return DTONome; }
        }
        public string DTO_nomeSocial
        {
            set { DTOnomeSocial = value; }

            get { return DTOnomeSocial; }
        }
        public string DTO_dataNasc
        {
            set { DTOdataNasc = value; }

            get { return DTOdataNasc; }
        }
        public string DTO_Sexo
        {
            set { DTOSexo = value; }

            get { return DTOSexo; }
        }
        public string DTO_Cpf
        {
            set { DTOCpf = value; }

            get { return DTOCpf; }
        }
        public string DTO_Rg
        {
            set { DTORg = value; }

            get { return DTORg; }
        }
        public string DTO_nomeMae
        {
            set { DTOnomeMae = value; }

            get { return DTOnomeMae; }
        }
        public string DTO_nomePai
        {
            set { DTOnomePai = value; }

            get { return DTOnomePai; }
        }
        public string DTO_nomeConjuge
        {
            set { DTOnomeConjuge = value; }

            get { return DTOnomeConjuge; }
        }
        public string DTO_dataCad
        {
            set { DTOdataCad = value; }

            get { return DTOdataCad; }
        }
        
    }
}
