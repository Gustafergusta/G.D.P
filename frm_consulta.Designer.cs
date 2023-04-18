
namespace Consulta_Pacientes
{
    partial class frm_consulta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPront = new System.Windows.Forms.RadioButton();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.rbNasc = new System.Windows.Forms.RadioButton();
            this.rbRg = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.mskNasci = new System.Windows.Forms.MaskedTextBox();
            this.txRG = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvConsult = new System.Windows.Forms.DataGridView();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPront);
            this.groupBox1.Controls.Add(this.txtProntuario);
            this.groupBox1.Controls.Add(this.rbNasc);
            this.groupBox1.Controls.Add(this.rbRg);
            this.groupBox1.Controls.Add(this.rbCpf);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Controls.Add(this.mskNasci);
            this.groupBox1.Controls.Add(this.txRG);
            this.groupBox1.Controls.Add(this.mskCPF);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1661, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // rbPront
            // 
            this.rbPront.AutoSize = true;
            this.rbPront.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPront.Location = new System.Drawing.Point(1375, 26);
            this.rbPront.Margin = new System.Windows.Forms.Padding(2);
            this.rbPront.Name = "rbPront";
            this.rbPront.Size = new System.Drawing.Size(105, 25);
            this.rbPront.TabIndex = 24;
            this.rbPront.TabStop = true;
            this.rbPront.Text = "Prontuário:";
            this.rbPront.UseVisualStyleBackColor = true;
            this.rbPront.CheckedChanged += new System.EventHandler(this.rbPront_CheckedChanged);
            // 
            // txtProntuario
            // 
            this.txtProntuario.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.txtProntuario.Location = new System.Drawing.Point(1499, 25);
            this.txtProntuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(132, 29);
            this.txtProntuario.TabIndex = 22;
            this.txtProntuario.TextChanged += new System.EventHandler(this.txtProntuario_TextChanged);
            // 
            // rbNasc
            // 
            this.rbNasc.AutoSize = true;
            this.rbNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNasc.Location = new System.Drawing.Point(979, 25);
            this.rbNasc.Margin = new System.Windows.Forms.Padding(2);
            this.rbNasc.Name = "rbNasc";
            this.rbNasc.Size = new System.Drawing.Size(171, 25);
            this.rbNasc.TabIndex = 15;
            this.rbNasc.TabStop = true;
            this.rbNasc.Text = "Data de Nascimento:";
            this.rbNasc.UseVisualStyleBackColor = true;
            this.rbNasc.CheckedChanged += new System.EventHandler(this.rbNasc_CheckedChanged);
            // 
            // rbRg
            // 
            this.rbRg.AutoSize = true;
            this.rbRg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRg.Location = new System.Drawing.Point(732, 25);
            this.rbRg.Margin = new System.Windows.Forms.Padding(2);
            this.rbRg.Name = "rbRg";
            this.rbRg.Size = new System.Drawing.Size(52, 25);
            this.rbRg.TabIndex = 14;
            this.rbRg.TabStop = true;
            this.rbRg.Text = "RG:";
            this.rbRg.UseVisualStyleBackColor = true;
            this.rbRg.CheckedChanged += new System.EventHandler(this.rbRg_CheckedChanged);
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCpf.Location = new System.Drawing.Point(495, 27);
            this.rbCpf.Margin = new System.Windows.Forms.Padding(2);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(58, 25);
            this.rbCpf.TabIndex = 13;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "CPF:";
            this.rbCpf.UseVisualStyleBackColor = true;
            this.rbCpf.CheckedChanged += new System.EventHandler(this.rbCpf_CheckedChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(8, 26);
            this.rbNome.Margin = new System.Windows.Forms.Padding(2);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(74, 25);
            this.rbNome.TabIndex = 12;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome:";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // mskNasci
            // 
            this.mskNasci.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.mskNasci.Location = new System.Drawing.Point(1193, 25);
            this.mskNasci.Margin = new System.Windows.Forms.Padding(2);
            this.mskNasci.Mask = "00/00/0000";
            this.mskNasci.Name = "mskNasci";
            this.mskNasci.Size = new System.Drawing.Size(121, 29);
            this.mskNasci.TabIndex = 12;
            this.mskNasci.TextChanged += new System.EventHandler(this.mskNasci_TextChanged);
            // 
            // txRG
            // 
            this.txRG.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.txRG.Location = new System.Drawing.Point(789, 24);
            this.txRG.Margin = new System.Windows.Forms.Padding(2);
            this.txRG.Name = "txRG";
            this.txRG.Size = new System.Drawing.Size(155, 29);
            this.txRG.TabIndex = 11;
            this.txRG.TextChanged += new System.EventHandler(this.txRG_TextChanged);
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.mskCPF.Location = new System.Drawing.Point(564, 25);
            this.mskCPF.Margin = new System.Windows.Forms.Padding(2);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(134, 29);
            this.mskCPF.TabIndex = 10;
            this.mskCPF.TextChanged += new System.EventHandler(this.mskCPF_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.txtNome.Location = new System.Drawing.Point(96, 24);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(363, 29);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvConsult
            // 
            this.dgvConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsult.Location = new System.Drawing.Point(13, 86);
            this.dgvConsult.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsult.Name = "dgvConsult";
            this.dgvConsult.ReadOnly = true;
            this.dgvConsult.RowHeadersWidth = 51;
            this.dgvConsult.RowTemplate.Height = 24;
            this.dgvConsult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsult.Size = new System.Drawing.Size(1661, 796);
            this.dgvConsult.TabIndex = 10;
            this.dgvConsult.DoubleClick += new System.EventHandler(this.dgvConsult_DoubleClick);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_msg.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.White;
            this.lbl_msg.Location = new System.Drawing.Point(280, 362);
            this.lbl_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(166, 65);
            this.lbl_msg.TabIndex = 11;
            this.lbl_msg.Text = "label9";
            // 
            // frm_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1691, 881);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.dgvConsult);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frm_consulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.TextBox txRG;
        private System.Windows.Forms.MaskedTextBox mskNasci;
        private System.Windows.Forms.DataGridView dgvConsult;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.RadioButton rbNasc;
        private System.Windows.Forms.RadioButton rbRg;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbPront;
        private System.Windows.Forms.TextBox txtProntuario;
    }
}