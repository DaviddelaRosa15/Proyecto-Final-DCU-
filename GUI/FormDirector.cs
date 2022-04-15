﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDirector : Form
    {
        //Campos para animar botones
        private IconButton btnActual;
        private Panel bordeBTN;
        private Form childFormActual;

        public FormDirector()
        {
            InitializeComponent();
            bordeBTN = new Panel();
            bordeBTN.Size = new Size(7, 60);
            panelMenu.Controls.Add(bordeBTN);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct colores
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void activarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                desactivarBoton();
                //Button
                btnActual = (IconButton)senderBtn;
                btnActual.BackColor = Color.FromArgb(37, 36, 81);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                bordeBTN.BackColor = color;
                bordeBTN.Location = new Point(0, btnActual.Location.Y);
                bordeBTN.Visible = true;
                bordeBTN.BringToFront();
                //Current Child Form Icon
                iconChildFormActual.IconChar = btnActual.IconChar;
                iconChildFormActual.IconColor = color;
            }
        }

        private void desactivarBoton()
        {
            if (btnActual != null)
            {
                btnActual.BackColor = Color.FromArgb(31, 30, 68);
                btnActual.ForeColor = Color.Gainsboro;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.Gainsboro;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ibtnPerfil_Click(object sender, EventArgs e)
        {
            activarBoton(sender, colores.color1);
        }

        private void ibtnMaestros_Click(object sender, EventArgs e)
        {
            activarBoton(sender, colores.color2);
        }

        private void ibtnEstudiantes_Click(object sender, EventArgs e)
        {
            activarBoton(sender, colores.color3);
        }

        private void ibtnCursos_Click(object sender, EventArgs e)
        {
            activarBoton(sender, colores.color4);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            desactivarBoton();
            bordeBTN.Visible = false;
            iconChildFormActual.IconChar = IconChar.Home;
            iconChildFormActual.IconColor = Color.MediumPurple;
            lblChildFormActual.Text = "Inicio";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}