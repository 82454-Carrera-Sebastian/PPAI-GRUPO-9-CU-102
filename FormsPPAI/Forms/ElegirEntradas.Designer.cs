﻿
namespace Dashbord {
	partial class ElegirEntradas {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirEntradas));
			this.lblVentaEntradas = new System.Windows.Forms.Label();
			this.panelRV = new System.Windows.Forms.Panel();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.pibUsuario = new System.Windows.Forms.PictureBox();
			this.lblCargo = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblNroEntradas = new System.Windows.Forms.Label();
			this.btnCloseForm = new System.Windows.Forms.Button();
			this.txtNroEntradas = new System.Windows.Forms.MaskedTextBox();
			this.lblMaximo = new System.Windows.Forms.Label();
			this.panelRV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pibUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// lblVentaEntradas
			// 
			this.lblVentaEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
			this.lblVentaEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVentaEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblVentaEntradas.Location = new System.Drawing.Point(295, 66);
			this.lblVentaEntradas.Name = "lblVentaEntradas";
			this.lblVentaEntradas.Size = new System.Drawing.Size(406, 72);
			this.lblVentaEntradas.TabIndex = 3;
			this.lblVentaEntradas.Text = "Venta de Entradas";
			this.lblVentaEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelRV
			// 
			this.panelRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
			this.panelRV.Controls.Add(this.btnCerrarSesion);
			this.panelRV.Controls.Add(this.pibUsuario);
			this.panelRV.Controls.Add(this.lblCargo);
			this.panelRV.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelRV.Location = new System.Drawing.Point(0, 0);
			this.panelRV.Name = "panelRV";
			this.panelRV.Size = new System.Drawing.Size(200, 542);
			this.panelRV.TabIndex = 4;
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnCerrarSesion.Location = new System.Drawing.Point(43, 428);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(114, 58);
			this.btnCerrarSesion.TabIndex = 4;
			this.btnCerrarSesion.Text = "Cerrar Sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			// 
			// pibUsuario
			// 
			this.pibUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pibUsuario.Image")));
			this.pibUsuario.Location = new System.Drawing.Point(0, 12);
			this.pibUsuario.Name = "pibUsuario";
			this.pibUsuario.Size = new System.Drawing.Size(200, 97);
			this.pibUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pibUsuario.TabIndex = 3;
			this.pibUsuario.TabStop = false;
			// 
			// lblCargo
			// 
			this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblCargo.Location = new System.Drawing.Point(3, 112);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(197, 61);
			this.lblCargo.TabIndex = 2;
			this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnAceptar.Location = new System.Drawing.Point(421, 328);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(151, 41);
			this.btnAceptar.TabIndex = 14;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lblNroEntradas
			// 
			this.lblNroEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNroEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblNroEntradas.Location = new System.Drawing.Point(304, 173);
			this.lblNroEntradas.Name = "lblNroEntradas";
			this.lblNroEntradas.Size = new System.Drawing.Size(397, 28);
			this.lblNroEntradas.TabIndex = 15;
			this.lblNroEntradas.Text = "Numero de Entradas a Emitir:";
			this.lblNroEntradas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnCloseForm.Location = new System.Drawing.Point(750, 0);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(43, 40);
			this.btnCloseForm.TabIndex = 21;
			this.btnCloseForm.Text = "X";
			this.btnCloseForm.UseVisualStyleBackColor = false;
			this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
			// 
			// txtNroEntradas
			// 
			this.txtNroEntradas.Location = new System.Drawing.Point(421, 232);
			this.txtNroEntradas.Mask = "00000";
			this.txtNroEntradas.Name = "txtNroEntradas";
			this.txtNroEntradas.Size = new System.Drawing.Size(151, 20);
			this.txtNroEntradas.TabIndex = 22;
			this.txtNroEntradas.ValidatingType = typeof(int);
			// 
			// lblMaximo
			// 
			this.lblMaximo.AutoSize = true;
			this.lblMaximo.ForeColor = System.Drawing.Color.Red;
			this.lblMaximo.Location = new System.Drawing.Point(421, 259);
			this.lblMaximo.Name = "lblMaximo";
			this.lblMaximo.Size = new System.Drawing.Size(0, 13);
			this.lblMaximo.TabIndex = 23;
			// 
			// ElegirEntradas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(790, 542);
			this.Controls.Add(this.lblMaximo);
			this.Controls.Add(this.txtNroEntradas);
			this.Controls.Add(this.btnCloseForm);
			this.Controls.Add(this.lblNroEntradas);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.panelRV);
			this.Controls.Add(this.lblVentaEntradas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ElegirEntradas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.ElegirEntradas_Load);
			this.panelRV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pibUsuario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblVentaEntradas;
		private System.Windows.Forms.Panel panelRV;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.PictureBox pibUsuario;
		private System.Windows.Forms.Label lblCargo;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblNroEntradas;
		private System.Windows.Forms.Button btnCloseForm;
		private System.Windows.Forms.MaskedTextBox txtNroEntradas;
		private System.Windows.Forms.Label lblMaximo;
	}
}