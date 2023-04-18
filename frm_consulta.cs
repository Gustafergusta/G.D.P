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
using System.Globalization;

namespace Consulta_Pacientes
{
    public partial class frm_consulta : Form
    {
        bll_consulta bll = new bll_consulta();
        dto_ficha dtoficha = new dto_ficha();

        public frm_consulta()
        {
            InitializeComponent();
        }

        private void frm_consulta_Load(object sender, EventArgs e)
        {
            bll.listaGrid(dgvConsult, lbl_msg);
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            txRG.Enabled = false;
            mskNasci.Enabled = false;
            txtProntuario.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                bll.listaGrid(dgvConsult, lbl_msg);
            }
            else
            {
                bll.consultanome(dgvConsult, txtNome);
            }
            
        }
        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            mskCPF.Enabled = false;
            txRG.Enabled = false;
            mskNasci.Enabled = false;
            txtProntuario.Enabled = false;
            txtNome.Text = "";
            txtNome.Focus();
        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            mskCPF.Enabled = true;
            mskCPF.Clear();
            txRG.Enabled = false;
            mskNasci.Enabled = false;
            txtProntuario.Enabled = false;
            mskCPF.Focus();
        }

        private void rbRg_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            txRG.Enabled = true;
            txRG.Text = "";
            mskNasci.Enabled = false;
            txtProntuario.Enabled = false;
            txRG.Focus();
        }

        private void rbNasc_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            txRG.Enabled = false;
            mskNasci.Enabled = true;
            mskNasci.Clear();
            txtProntuario.Enabled = false;
            mskNasci.Focus();
        }

        private void rbPront_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            txRG.Enabled = false;
            mskNasci.Enabled = false;
            txtProntuario.Enabled = true;
            txtProntuario.Text = "";
            txtProntuario.Focus();
        }

        private void rbDtAtend_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            txRG.Enabled = false;
            mskNasci.Enabled = false;
            txtProntuario.Enabled = false;
        }

        private void rbAlta_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            txRG.Enabled = false;
            mskNasci.Enabled = false;
            txtProntuario.Enabled = false;
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            if (mskCPF.Text == "")
            {
                bll.listaGrid(dgvConsult, lbl_msg);
            }
            else
            {
                string cpf= mskCPF.Text.Replace(".", "").Replace("-", "").Replace(" ", "");
                bll.consultaCPF(dgvConsult, cpf);
            }
        }

        private void txRG_TextChanged(object sender, EventArgs e)
        {
            if (txRG.Text == "")
            {
                bll.listaGrid(dgvConsult, lbl_msg);
            }
            else
            {
                bll.consultarg(dgvConsult, txRG);
            }
        }

        private void mskNasci_TextChanged(object sender, EventArgs e)
        {
            // RETIRANDO FORMATAÇÃO DA MASKED PARA VALIDAÇÃO DE DADOS
            string dtnas = mskNasci.Text.Replace("/", "").Replace("-", "").Replace(" ", "");
            int quantidadeCaracteres = dtnas.Length;
            char caractere = '-';
            
            // VARIAVEL CONVERTER STRINGBULDER PARA STRING 
            string convertData;

            //VARIAVEL PARA INVERTER DATA
            string[] partesData; string dataEua;

            if (quantidadeCaracteres == 0)
            {
                bll.listaGrid(dgvConsult, lbl_msg);
            }
            else
            {
                if (quantidadeCaracteres <= 2)
                {
                    bll.consultaDTNas(dgvConsult, dtnas);
                }
                else if (quantidadeCaracteres >= 3 && quantidadeCaracteres <=4)
                {
                    //INSERINDO A O TRAÇO (EXEMPLO 0101 = 01-01)
                    StringBuilder sb = new StringBuilder(dtnas);
                    sb.Insert(2, caractere);

                    // CONVERTENDO STRINGBULDER PARA STRING
                    convertData = sb.ToString();

                    //INVERTER DATA
                    partesData = convertData.Split('-');

                    //ATRIBUINDO A UMA VARIAVEL POREM INVERTIDO AS PARTES DAS DATAS
                    StringBuilder novaData = new StringBuilder();
                    novaData.Append(partesData[1]); // adiciona o mês
                    novaData.Append("-");
                    novaData.Append(partesData[0]); // adiciona o dia
                    
                    dataEua = novaData.ToString(); // converte para string


                    bll.consultaDTNas(dgvConsult, dataEua);
                }
                else if (quantidadeCaracteres == 8)
                {
                    //INSERINDO A O TRAÇO
                    StringBuilder sb = new StringBuilder(dtnas);
                    sb.Insert(2, caractere);
                    sb.Insert(5, caractere);

                    // CONVERTENDO STRINGBULDER PARA STRING
                    convertData = sb.ToString();

                    //INVERTER DATA
                    partesData = convertData.Split('-');

                    //ATRIBUINDO A UMA VARIAVEL POREM INVERTIDO AS PARTES DAS DATAS
                    StringBuilder novaData = new StringBuilder();
                    novaData.Append(partesData[2]); // adiciona o ano
                    novaData.Append("-");
                    novaData.Append(partesData[1]); // adiciona o mês
                    novaData.Append("-");
                    novaData.Append(partesData[0]); // adiciona o dia

                    dataEua = novaData.ToString(); // converte para string


                    bll.consultaDTNas(dgvConsult, dataEua);
                }
            }
        }

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {
            if (txtProntuario.Text == "")
            {
                bll.listaGrid(dgvConsult, lbl_msg);
            }
            else
            {
                bll.consultapront(dgvConsult, txtProntuario);
            }
        }

        private void dgvConsult_DoubleClick(object sender, EventArgs e)
        {
            dtoficha.DTO_Prontuario = dgvConsult.CurrentRow.Cells[3].Value.ToString();
            frm_ficha form =  new frm_ficha();
            form.ShowDialog();
        }
    }
}
