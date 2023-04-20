using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Consulta_Pacientes.Code.DTO;

namespace Consulta_Pacientes.Code.BLL
{
    class bll_menu
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        dto_login dtologin = new dto_login();

        public void initialize(Panel panelEsquerdo)
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 49);
            panelEsquerdo.Controls.Add(leftBorderBtn);
        }

        public void nivelacesso(Label lblNome, IconButton btngerenUser)
        {
            lblNome.Text = dtologin.DTO_NomeCompleto;
            if(dtologin.DTO_perfil != "Admin")
            {
                btngerenUser.Visible = false;
            }
        }

        public void ActivateButton(object sendBtn, Color color, IconPictureBox icoMenu)
        {
            if (sendBtn != null)
            {
                DisableButton();
                //BUTTON
                currentBtn = (IconButton)sendBtn;
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //LEFT BORDER BUTTON
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //ICON CURRENT CHILD FORM
                icoMenu.IconChar = currentBtn.IconChar;
                icoMenu.IconColor = color;
            }
        }

        public void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(140, 0, 82); // COR DE FUNDO
                currentBtn.ForeColor = Color.White; // COR DA LETRA

                currentBtn.TextAlign = ContentAlignment.MiddleCenter; // ALINHAMENTO DO TEXTO
                currentBtn.IconColor = Color.White; // COR DO ICONE

                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; // ALINHAMENTO DA IMG
            }
        }
        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(220, 96, 73);
            public static Color color2 = Color.FromArgb(0, 56, 61);
            public static Color color3 = Color.FromArgb(74, 105, 189);
            public static Color color4 = Color.FromArgb(59, 134, 189);
        }
        public void Reset(bool condicao, IconPictureBox icoMenu, Label lblMenu)
        {
            DisableButton();
            leftBorderBtn.Visible = condicao;
            icoMenu.IconChar = IconChar.Home;
            icoMenu.IconColor = Color.Black;
            lblMenu.Text = "Inicio";
            lblMenu.ForeColor = Color.Black;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        public void OpenChildForm(Form childForm, Panel panelForm, Label lblMenu, Color color)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblMenu.Text = childForm.Text;
            lblMenu.ForeColor = color;
        }
    }
}
