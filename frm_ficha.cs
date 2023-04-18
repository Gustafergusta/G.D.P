using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consulta_Pacientes.Code.BLL;
using Consulta_Pacientes.Code.DTO;

namespace Consulta_Pacientes
{
    public partial class frm_ficha : Form
    {
        bll_ficha bll = new bll_ficha();
        dto_ficha dto = new dto_ficha();

        public frm_ficha()
        {
            InitializeComponent();
        }

        private void frm_ficha_Load(object sender, EventArgs e)
        {
            bll.conulta_ficha(dto,dgv_Atend);

            lbl_Pront.Text = dto.DTO_Prontuario;
            lbl_prontAnt.Text = dto.DTO_ProntuarioAntigo;
            lbl_sistema.Text = dto.DTO_Sistema;
            lbl_Nome.Text = dto.DTO_Nome;
            lbl_nomeSocial.Text = dto.DTO_nomeSocial;
            lbl_Nasci.Text = dto.DTO_dataNasc;
            lbl_Sexo.Text = dto.DTO_Sexo;
            lbl_Cpf.Text = dto.DTO_Cpf;
            lbl_Rg.Text = dto.DTO_Rg;
            lbl_nomeMae.Text = dto.DTO_nomeMae;
            lbl_nomePai.Text = dto.DTO_nomePai;
            lbl_nomeConj.Text = dto.DTO_nomeConjuge;
            lbl_dataCad.Text = dto.DTO_dataCad;
        }
    }
}
