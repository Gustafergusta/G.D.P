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

        frm_splashGrid splash = new frm_splashGrid();

        // RECUPERANDO ACESSO AO MENU QUE ESTÁ ABERTO PARA DESABILITAR AS OPÇÕES ENQUANTO CARREGA OS DADOS
        frm_menuNew menuForm = Application.OpenForms.OfType<frm_menuNew>().FirstOrDefault();

        // ARRAY PARA JUNTAR TODOS OS COMPONESTES PRESENTE NO FORM ABERTO PARA DESABILITAR ENQUANTO CARREGA DADOS
        List<Control> allControls = new List<Control>();

        public frm_consulta()
        {
            InitializeComponent();
        }

        private void frm_consulta_Load(object sender, EventArgs e)
        {
            this.splash = new frm_splashGrid();
            this.splash.Show();

            backgroundWorker1.RunWorkerAsync();

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
                this.splash = new frm_splashGrid();
                this.splash.Show();

                backgroundWorker1.RunWorkerAsync();
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
            string cpfSemMascara = mskCPF.Text.Replace(".", "").Replace("-", "").Trim();

            if (cpfSemMascara.Length == 0)
            {
                this.splash = new frm_splashGrid();
                this.splash.Show();

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void txRG_TextChanged(object sender, EventArgs e)
        {
            if (txRG.Text == "")
            {
                this.splash = new frm_splashGrid();
                this.splash.Show();

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void mskNasci_TextChanged(object sender, EventArgs e)
        {
            // RETIRANDO FORMATAÇÃO DA MASKED PARA VALIDAÇÃO DE DADOS
            string dtnas = mskNasci.Text.Replace("/", "").Replace("-", "").Replace(" ", "");
            int quantidadeCaracteres = dtnas.Length;

            if (quantidadeCaracteres == 0)
            {
                this.splash = new frm_splashGrid();
                this.splash.Show();

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {
            if (txtProntuario.Text == "")
            {
                this.splash = new frm_splashGrid();
                this.splash.Show();

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void dgvConsult_DoubleClick(object sender, EventArgs e)
        {
            dtoficha.DTO_Prontuario = dgvConsult.CurrentRow.Cells[3].Value.ToString();
            frm_ficha form =  new frm_ficha();
            form.ShowDialog();
        }

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            if (rbNome.Checked == true)
            {
                bll.consultanome(dgvConsult, txtNome, lbl_msg);
            }
            else if (rbCpf.Checked == true)
            {
                string cpf = mskCPF.Text.Replace(".", "").Replace("-", "").Replace(" ", "");
                bll.consultaCPF(dgvConsult, cpf, lbl_msg);
            }
            else if (rbRg.Checked == true)
            {
                bll.consultarg(dgvConsult, txRG, lbl_msg);
            }
            else if (rbNasc.Checked == true)
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
                    this.splash = new frm_splashGrid();
                    this.splash.Show();

                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    if (quantidadeCaracteres <= 2)
                    {
                        bll.consultaDTNas(dgvConsult, dtnas, lbl_msg);
                    }
                    else if (quantidadeCaracteres >= 3 && quantidadeCaracteres <= 4)
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


                        bll.consultaDTNas(dgvConsult, dataEua, lbl_msg);
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


                        bll.consultaDTNas(dgvConsult, dataEua, lbl_msg);
                    }
                }
            }
            else if (rbPront.Checked == true)
            {
                bll.consultapront(dgvConsult, txtProntuario, lbl_msg);
            }
            else { MessageBox.Show("Selecione e inclua o critério de pesquisa.","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            allControls.AddRange(this.Controls.Cast<Control>());
            allControls.AddRange(menuForm.Controls.Cast<Control>());

            foreach (Control control in allControls)
            {
                control.Invoke(new Action(() =>
                {
                    control.Enabled = false;
                }));
            }

            e.Result = bll.listaGrid(dgvConsult);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.splash.Close();
            
            foreach (Control control in allControls)
            {
                control.Enabled = true;
            }

            if (e.Error != null)
            {
                MessageBox.Show("Erro ao carregar dados: " + e.Error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((bool)e.Result)
                {
                    lbl_msg.Visible = false;
                }
                else
                {
                    lbl_msg.Visible = true;
                    lbl_msg.Text = "Não existem dados para serem exibidos.";
                }
            }
        }
    }
}
