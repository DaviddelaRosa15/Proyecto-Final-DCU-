namespace GUI
{
    partial class FormMaestro
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.ibtnAyuda = new FontAwesome.Sharp.IconButton();
            this.ibtnCalificar = new FontAwesome.Sharp.IconButton();
            this.ibtnCursos = new FontAwesome.Sharp.IconButton();
            this.ibtnPerfil = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.lblChildFormActual = new System.Windows.Forms.Label();
            this.iconChildFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmFechayHora = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildFormActual)).BeginInit();
            this.panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.ibtnCerrarSesion);
            this.panelMenu.Controls.Add(this.ibtnAyuda);
            this.panelMenu.Controls.Add(this.ibtnCalificar);
            this.panelMenu.Controls.Add(this.ibtnCursos);
            this.panelMenu.Controls.Add(this.ibtnPerfil);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 670);
            this.panelMenu.TabIndex = 0;
            // 
            // ibtnCerrarSesion
            // 
            this.ibtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.ibtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.ibtnCerrarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCerrarSesion.IconSize = 32;
            this.ibtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCerrarSesion.Location = new System.Drawing.Point(0, 610);
            this.ibtnCerrarSesion.Name = "ibtnCerrarSesion";
            this.ibtnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnCerrarSesion.Size = new System.Drawing.Size(220, 60);
            this.ibtnCerrarSesion.TabIndex = 7;
            this.ibtnCerrarSesion.Text = "Cerrar sesion";
            this.ibtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCerrarSesion.UseVisualStyleBackColor = true;
            this.ibtnCerrarSesion.Click += new System.EventHandler(this.ibtnCerrarSesion_Click);
            // 
            // ibtnAyuda
            // 
            this.ibtnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAyuda.FlatAppearance.BorderSize = 0;
            this.ibtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAyuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAyuda.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnAyuda.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.ibtnAyuda.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAyuda.IconSize = 32;
            this.ibtnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAyuda.Location = new System.Drawing.Point(0, 320);
            this.ibtnAyuda.Name = "ibtnAyuda";
            this.ibtnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnAyuda.Size = new System.Drawing.Size(220, 60);
            this.ibtnAyuda.TabIndex = 6;
            this.ibtnAyuda.Text = "Documentación";
            this.ibtnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAyuda.UseVisualStyleBackColor = true;
            this.ibtnAyuda.Click += new System.EventHandler(this.ibtnAyuda_Click);
            // 
            // ibtnCalificar
            // 
            this.ibtnCalificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCalificar.FlatAppearance.BorderSize = 0;
            this.ibtnCalificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCalificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCalificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCalificar.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.ibtnCalificar.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCalificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCalificar.IconSize = 32;
            this.ibtnCalificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCalificar.Location = new System.Drawing.Point(0, 260);
            this.ibtnCalificar.Name = "ibtnCalificar";
            this.ibtnCalificar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnCalificar.Size = new System.Drawing.Size(220, 60);
            this.ibtnCalificar.TabIndex = 5;
            this.ibtnCalificar.Text = "Calificar";
            this.ibtnCalificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCalificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCalificar.UseVisualStyleBackColor = true;
            this.ibtnCalificar.Click += new System.EventHandler(this.ibtnCalificar_Click);
            // 
            // ibtnCursos
            // 
            this.ibtnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCursos.FlatAppearance.BorderSize = 0;
            this.ibtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCursos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCursos.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCursos.IconChar = FontAwesome.Sharp.IconChar.School;
            this.ibtnCursos.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCursos.IconSize = 32;
            this.ibtnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCursos.Location = new System.Drawing.Point(0, 200);
            this.ibtnCursos.Name = "ibtnCursos";
            this.ibtnCursos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnCursos.Size = new System.Drawing.Size(220, 60);
            this.ibtnCursos.TabIndex = 4;
            this.ibtnCursos.Text = "Cursos";
            this.ibtnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCursos.UseVisualStyleBackColor = true;
            this.ibtnCursos.Click += new System.EventHandler(this.ibtnCursos_Click);
            // 
            // ibtnPerfil
            // 
            this.ibtnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnPerfil.FlatAppearance.BorderSize = 0;
            this.ibtnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnPerfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnPerfil.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.ibtnPerfil.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPerfil.IconSize = 32;
            this.ibtnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPerfil.Location = new System.Drawing.Point(0, 140);
            this.ibtnPerfil.Name = "ibtnPerfil";
            this.ibtnPerfil.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnPerfil.Size = new System.Drawing.Size(220, 60);
            this.ibtnPerfil.TabIndex = 1;
            this.ibtnPerfil.Text = "Mi Perfil";
            this.ibtnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnPerfil.UseVisualStyleBackColor = true;
            this.ibtnPerfil.Click += new System.EventHandler(this.ibtnPerfil_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Image = global::GUI.Properties.Resources.logo_large;
            this.btnInicio.Location = new System.Drawing.Point(12, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(189, 112);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
            this.panelTitulo.Controls.Add(this.lblChildFormActual);
            this.panelTitulo.Controls.Add(this.iconChildFormActual);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(980, 80);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitulo_Paint);
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 26;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(905, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 23);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 26;
            this.btnCerrar.Location = new System.Drawing.Point(957, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 26;
            this.btnMaximizar.Location = new System.Drawing.Point(931, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 23);
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // lblChildFormActual
            // 
            this.lblChildFormActual.AutoSize = true;
            this.lblChildFormActual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildFormActual.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChildFormActual.Location = new System.Drawing.Point(60, 32);
            this.lblChildFormActual.Name = "lblChildFormActual";
            this.lblChildFormActual.Size = new System.Drawing.Size(42, 17);
            this.lblChildFormActual.TabIndex = 1;
            this.lblChildFormActual.Text = "Inicio";
            // 
            // iconChildFormActual
            // 
            this.iconChildFormActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconChildFormActual.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconChildFormActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconChildFormActual.IconColor = System.Drawing.Color.MediumPurple;
            this.iconChildFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChildFormActual.Location = new System.Drawing.Point(22, 23);
            this.iconChildFormActual.Name = "iconChildFormActual";
            this.iconChildFormActual.Size = new System.Drawing.Size(32, 32);
            this.iconChildFormActual.TabIndex = 0;
            this.iconChildFormActual.TabStop = false;
            this.iconChildFormActual.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(220, 80);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(980, 10);
            this.panelSombra.TabIndex = 2;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelEscritorio.Controls.Add(this.label2);
            this.panelEscritorio.Controls.Add(this.label1);
            this.panelEscritorio.Controls.Add(this.pictureBox1);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 90);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(980, 580);
            this.panelEscritorio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(403, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(381, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo_large;
            this.pictureBox1.Location = new System.Drawing.Point(302, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tmFechayHora
            // 
            this.tmFechayHora.Enabled = true;
            this.tmFechayHora.Tick += new System.EventHandler(this.tmFechayHora_Tick);
            // 
            // FormMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 670);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMaestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDirector";
            this.Load += new System.EventHandler(this.FormDirector_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildFormActual)).EndInit();
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton ibtnCursos;
        private FontAwesome.Sharp.IconButton ibtnPerfil;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox iconChildFormActual;
        private System.Windows.Forms.Label lblChildFormActual;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmFechayHora;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton ibtnCalificar;
        private FontAwesome.Sharp.IconButton ibtnCerrarSesion;
        private FontAwesome.Sharp.IconButton ibtnAyuda;
    }
}