using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Consulta_Pacientes.Code.DTO;
using Consulta_Pacientes.Code.BLL;

namespace Consulta_Pacientes
{
    public partial class frm_declara : Form
    {
        // INSTANCIANDO DADOS E REGRAS DE DOMINIO
        dto_declara dto = new dto_declara();
        bll_declara bll = new bll_declara();

        // INSTANCIANDO TELA DE CARREGAMENTO
        frm_splashGrid splash = new frm_splashGrid();

        // RECUPERANDO ACESSO AO MENU QUE ESTÁ ABERTO PARA DESABILITAR AS OPÇÕES ENQUANTO CARREGA OS DADOS
        frm_menuNew menuForm = Application.OpenForms.OfType<frm_menuNew>().FirstOrDefault();

        // ARRAY PARA JUNTAR TODOS OS COMPONESTES PRESENTE NO FORM ABERTO PARA DESABILITAR ENQUANTO CARREGA DADOS
        List<Control> allControls = new List<Control>();


        public frm_declara()
        {
            InitializeComponent();
        }
        private void frm_declara_Load(object sender, EventArgs e)
        {   
            this.splash = new frm_splashGrid();
            this.splash.Show();

            backgroundWorker1.RunWorkerAsync();

            reportViewer1.Visible = false;
            reportViewer2.Visible = false;
        }

        private void btncomCID_Click(object sender, EventArgs e)
        {

            if (txtPront.Text != "" && cbNome.Text != "")
            {
                reportViewer1.Visible = true;
                reportViewer2.Visible = false;
                dto.DTO_Nome = cbNome.Text;
                dto.DTO_pront = txtPront.Text;

                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("dsCCID",bll.RelaCCID(dto));
                reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Nome", dto.DTO_Nome));
                if (dto_menu.select_hosp == "1") { this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Empresa", "Nossa Senhora do Caminho*")); }
                else { this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Empresa", "Nossa Senhora de Fatima")); }

                this.reportViewer1.RefreshReport();
                this.reportViewer1.ZoomMode = ZoomMode.FullPage;
                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            }
            else
            {
                MessageBox.Show("Para emitir a declaração, favor preencher os campos Prontuário e Nome do Paciente.");
            }
        }

        private void txtPront_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dto_declara.DTOVerifica != true)
            {
                bll.preenchePront(cbNome, txtPront);
            }
            else
            {
                dto_declara.DTOVerifica = false;
            }
        }

        private void txtPront_Leave(object sender, EventArgs e)
        {
            bll.preencheNome(cbNome,txtPront);
        }

        private void btnsemCID_Click(object sender, EventArgs e)
        {
            if (txtPront.Text != "" && cbNome.Text != "")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = true;
                dto.DTO_Nome = cbNome.Text;
                dto.DTO_pront = txtPront.Text;

                reportViewer2.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("dsSCID", bll.RelaSCID(dto));
                this.reportViewer2.LocalReport.DataSources.Add(rds);
                this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Nome", dto.DTO_Nome));
                if (dto_menu.select_hosp == "1") { this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Empresa", "Nossa Senhora do Caminho*")); }
                else { this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Empresa", "Nossa Senhora de Fatima")); }

                this.reportViewer2.RefreshReport();
                this.reportViewer2.ZoomMode = ZoomMode.FullPage;
                this.reportViewer2.SetDisplayMode(DisplayMode.PrintLayout);
            }
            else
            {
                MessageBox.Show("Para emitir a declaração, favor preencher os campos Prontuário e Nome do Paciente.");
            }
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

            e.Result = bll.preencheCb(cbNome);
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
        }
    }
}
