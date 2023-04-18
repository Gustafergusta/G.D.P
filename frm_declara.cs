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
        dto_declara dto = new dto_declara();
        bll_declara bll = new bll_declara();


        public frm_declara()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_declara_Load(object sender, EventArgs e)
        {
            bll.preencheCb(cbNome);
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
                dto.DTO_pront = Convert.ToInt32(txtPront.Text);

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
                dto.DTO_pront = Convert.ToInt32(txtPront.Text);

                reportViewer2.LocalReport.DataSources.Clear();

                int x = Convert.ToInt32(txtPront.Text);

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
    }
}
