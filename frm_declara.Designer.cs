
namespace Consulta_Pacientes
{
    partial class frm_declara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnsemCID = new FontAwesome.Sharp.IconButton();
            this.btncomCID = new FontAwesome.Sharp.IconButton();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.txtPront = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dadosRelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosRelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosRelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosRelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsemCID
            // 
            this.btnsemCID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsemCID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsemCID.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnsemCID.IconColor = System.Drawing.Color.Black;
            this.btnsemCID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsemCID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsemCID.Location = new System.Drawing.Point(1371, 23);
            this.btnsemCID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsemCID.Name = "btnsemCID";
            this.btnsemCID.Size = new System.Drawing.Size(248, 52);
            this.btnsemCID.TabIndex = 2;
            this.btnsemCID.Text = "Declaração sem CID";
            this.btnsemCID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsemCID.UseVisualStyleBackColor = true;
            this.btnsemCID.Click += new System.EventHandler(this.btnsemCID_Click);
            // 
            // btncomCID
            // 
            this.btncomCID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomCID.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btncomCID.IconColor = System.Drawing.Color.Black;
            this.btncomCID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncomCID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncomCID.Location = new System.Drawing.Point(1115, 23);
            this.btncomCID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncomCID.Name = "btncomCID";
            this.btncomCID.Size = new System.Drawing.Size(248, 52);
            this.btncomCID.TabIndex = 1;
            this.btncomCID.Text = "Declaração com CID";
            this.btncomCID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncomCID.UseVisualStyleBackColor = true;
            this.btncomCID.Click += new System.EventHandler(this.btncomCID_Click);
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(377, 35);
            this.cbNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(712, 29);
            this.cbNome.TabIndex = 3;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // txtPront
            // 
            this.txtPront.Location = new System.Drawing.Point(141, 35);
            this.txtPront.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPront.Name = "txtPront";
            this.txtPront.Size = new System.Drawing.Size(136, 29);
            this.txtPront.TabIndex = 4;
            this.txtPront.TextChanged += new System.EventHandler(this.txtPront_TextChanged);
            this.txtPront.Leave += new System.EventHandler(this.txtPront_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prontuário:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPront);
            this.groupBox1.Controls.Add(this.btnsemCID);
            this.groupBox1.Controls.Add(this.btncomCID);
            this.groupBox1.Controls.Add(this.cbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1640, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsCCID";
            reportDataSource1.Value = this.dadosRelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Consulta_Pacientes.Relatorios.report_CCID.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1640, 675);
            this.reportViewer1.TabIndex = 7;
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Consulta_Pacientes.Relatorios.report_SCID .rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(24, 101);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1640, 734);
            this.reportViewer2.TabIndex = 8;
            // 
            // dadosRelBindingSource
            // 
            this.dadosRelBindingSource.DataSource = typeof(Consulta_Pacientes.Relatorios.dadosRel);
            // 
            // dadosRelBindingSource1
            // 
            this.dadosRelBindingSource1.DataSource = typeof(Consulta_Pacientes.Relatorios.dadosRel);
            // 
            // frm_declara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1708, 847);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_declara";
            this.Text = "Declaração de Atendimentos";
            this.Load += new System.EventHandler(this.frm_declara_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosRelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosRelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btncomCID;
        private FontAwesome.Sharp.IconButton btnsemCID;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.TextBox txtPront;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dadosRelBindingSource;
        private System.Windows.Forms.BindingSource dadosRelBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}