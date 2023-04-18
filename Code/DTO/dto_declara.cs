using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Pacientes.Code.DTO
{
    class dto_declara
    {
        public static bool DTOVerifica;
        private static string DTONome;
        public string DTO_Nome
        {
            set { DTONome = value; }

            get { return DTONome; }
        }

        private static int DTOpront;
        public int DTO_pront
        {
            set { DTOpront = value; }

            get { return DTOpront; }
        }

    }
}
