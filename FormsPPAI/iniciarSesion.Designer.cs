﻿
namespace Dashbord
{
    partial class iniciarSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iniciarSesion));
            this.panelIniciarSesion = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pibGobCbaIniciarSesion = new System.Windows.Forms.PictureBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panelIniciarSesion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibGobCbaIniciarSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIniciarSesion
            // 
            this.panelIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.panelIniciarSesion.Controls.Add(this.panel2);
            this.panelIniciarSesion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.panelIniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.panelIniciarSesion.Name = "panelIniciarSesion";
            this.panelIniciarSesion.Size = new System.Drawing.Size(176, 542);
            this.panelIniciarSesion.TabIndex = 1;
            this.panelIniciarSesion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pibGobCbaIniciarSesion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 99);
            this.panel2.TabIndex = 0;
            // 
            // pibGobCbaIniciarSesion
            // 
            this.pibGobCbaIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("pibGobCbaIniciarSesion.Image")));
            this.pibGobCbaIniciarSesion.Location = new System.Drawing.Point(-2, -2);
            this.pibGobCbaIniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.pibGobCbaIniciarSesion.Name = "pibGobCbaIniciarSesion";
            this.pibGobCbaIniciarSesion.Size = new System.Drawing.Size(178, 101);
            this.pibGobCbaIniciarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibGobCbaIniciarSesion.TabIndex = 0;
            this.pibGobCbaIniciarSesion.TabStop = false;
            this.pibGobCbaIniciarSesion.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(141)))));
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Roboto Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.txtNombreUsuario.Location = new System.Drawing.Point(350, 179);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(227, 20);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Roboto Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.lblIniciarSesion.Location = new System.Drawing.Point(318, 75);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(285, 43);
            this.lblIniciarSesion.TabIndex = 4;
            this.lblIniciarSesion.Text = "Iniciar Sesión";
            this.lblIniciarSesion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(346, 155);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(180, 21);
            this.lblNombreUsuario.TabIndex = 5;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            this.lblNombreUsuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.lblPassword.Location = new System.Drawing.Point(346, 243);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(110, 21);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Contraseña";
            this.lblPassword.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Roboto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.btnIniciarSesion.Location = new System.Drawing.Point(393, 329);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(133, 32);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(141)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Roboto Mono", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.txtPassword.Location = new System.Drawing.Point(350, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseForm.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.btnCloseForm.Location = new System.Drawing.Point(751, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(43, 40);
            this.btnCloseForm.TabIndex = 21;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            // 
            // iniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(790, 542);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.panelIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "iniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelIniciarSesion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibGobCbaIniciarSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIniciarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pibGobCbaIniciarSesion;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCloseForm;
    }
}

