namespace GUI
{
    partial class FormDirector
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnCursos = new FontAwesome.Sharp.IconButton();
            this.ibtnEstudiantes = new FontAwesome.Sharp.IconButton();
            this.ibtnMaestros = new FontAwesome.Sharp.IconButton();
            this.ibtnPerfil = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblChildFormActual = new System.Windows.Forms.Label();
            this.iconChildFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildFormActual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.ibtnCursos);
            this.panelMenu.Controls.Add(this.ibtnEstudiantes);
            this.panelMenu.Controls.Add(this.ibtnMaestros);
            this.panelMenu.Controls.Add(this.ibtnPerfil);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 670);
            this.panelMenu.TabIndex = 0;
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
            this.ibtnCursos.Location = new System.Drawing.Point(0, 320);
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
            // ibtnEstudiantes
            // 
            this.ibtnEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnEstudiantes.FlatAppearance.BorderSize = 0;
            this.ibtnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEstudiantes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEstudiantes.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnEstudiantes.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.ibtnEstudiantes.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEstudiantes.IconSize = 32;
            this.ibtnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEstudiantes.Location = new System.Drawing.Point(0, 260);
            this.ibtnEstudiantes.Name = "ibtnEstudiantes";
            this.ibtnEstudiantes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnEstudiantes.Size = new System.Drawing.Size(220, 60);
            this.ibtnEstudiantes.TabIndex = 3;
            this.ibtnEstudiantes.Text = "Estudiantes";
            this.ibtnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEstudiantes.UseVisualStyleBackColor = true;
            this.ibtnEstudiantes.Click += new System.EventHandler(this.ibtnEstudiantes_Click);
            // 
            // ibtnMaestros
            // 
            this.ibtnMaestros.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnMaestros.FlatAppearance.BorderSize = 0;
            this.ibtnMaestros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMaestros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMaestros.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnMaestros.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.ibtnMaestros.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnMaestros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMaestros.IconSize = 32;
            this.ibtnMaestros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMaestros.Location = new System.Drawing.Point(0, 200);
            this.ibtnMaestros.Name = "ibtnMaestros";
            this.ibtnMaestros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnMaestros.Size = new System.Drawing.Size(220, 60);
            this.ibtnMaestros.TabIndex = 2;
            this.ibtnMaestros.Text = "Maestros";
            this.ibtnMaestros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMaestros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnMaestros.UseVisualStyleBackColor = true;
            this.ibtnMaestros.Click += new System.EventHandler(this.ibtnMaestros_Click);
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
            this.btnInicio.Location = new System.Drawing.Point(34, 23);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(137, 85);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
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
            // FormDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 670);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDirector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDirector";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildFormActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton ibtnCursos;
        private FontAwesome.Sharp.IconButton ibtnEstudiantes;
        private FontAwesome.Sharp.IconButton ibtnMaestros;
        private FontAwesome.Sharp.IconButton ibtnPerfil;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox iconChildFormActual;
        private System.Windows.Forms.Label lblChildFormActual;
    }
}