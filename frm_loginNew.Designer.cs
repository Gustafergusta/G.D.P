
namespace Consulta_Pacientes
{
    partial class frm_loginNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loginNew));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.linkEmail = new System.Windows.Forms.PictureBox();
            this.linkGLPI = new System.Windows.Forms.PictureBox();
            this.linlkWhats = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkGLPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linlkWhats)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(518, 141);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(348, 27);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Location = new System.Drawing.Point(518, 189);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(348, 27);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.Transparent;
            this.btnLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(625, 237);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(113, 28);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "Acessar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            this.btnLogar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogar_KeyDown);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 41;
            this.iconPictureBox3.Location = new System.Drawing.Point(898, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(42, 41);
            this.iconPictureBox3.TabIndex = 7;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // linkEmail
            // 
            this.linkEmail.BackColor = System.Drawing.Color.Transparent;
            this.linkEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkEmail.Location = new System.Drawing.Point(409, 346);
            this.linkEmail.Name = "linkEmail";
            this.linkEmail.Size = new System.Drawing.Size(29, 28);
            this.linkEmail.TabIndex = 8;
            this.linkEmail.TabStop = false;
            this.linkEmail.Click += new System.EventHandler(this.linkEmail_Click);
            // 
            // linkGLPI
            // 
            this.linkGLPI.BackColor = System.Drawing.Color.Transparent;
            this.linkGLPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkGLPI.Location = new System.Drawing.Point(451, 345);
            this.linkGLPI.Name = "linkGLPI";
            this.linkGLPI.Size = new System.Drawing.Size(29, 28);
            this.linkGLPI.TabIndex = 9;
            this.linkGLPI.TabStop = false;
            this.linkGLPI.Click += new System.EventHandler(this.linkGLPI_Click);
            // 
            // linlkWhats
            // 
            this.linlkWhats.BackColor = System.Drawing.Color.Transparent;
            this.linlkWhats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linlkWhats.Location = new System.Drawing.Point(492, 346);
            this.linlkWhats.Name = "linlkWhats";
            this.linlkWhats.Size = new System.Drawing.Size(29, 28);
            this.linlkWhats.TabIndex = 10;
            this.linlkWhats.TabStop = false;
            this.linlkWhats.Click += new System.EventHandler(this.linlkWhats_Click);
            // 
            // frm_loginNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Consulta_Pacientes.Properties.Resources.Tela_de_Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 400);
            this.Controls.Add(this.linlkWhats);
            this.Controls.Add(this.linkGLPI);
            this.Controls.Add(this.linkEmail);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.txtUser);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_loginNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_loginNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkGLPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linlkWhats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.PictureBox linkEmail;
        private System.Windows.Forms.PictureBox linkGLPI;
        private System.Windows.Forms.PictureBox linlkWhats;
    }
}