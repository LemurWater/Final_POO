﻿
namespace FinalPOO.Forms
{
    partial class F22VEINInformacionPersonalDetallada
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonResidencia = new System.Windows.Forms.Button();
            this.buttonInformacionAcademica = new System.Windows.Forms.Button();
            this.buttonInformacionBasica = new System.Windows.Forms.Button();
            this.buttonPatrimonio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(744, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 40);
            this.button2.TabIndex = 45;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(687, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonResidencia
            // 
            this.buttonResidencia.BackColor = System.Drawing.Color.Transparent;
            this.buttonResidencia.FlatAppearance.BorderSize = 0;
            this.buttonResidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResidencia.Location = new System.Drawing.Point(220, 321);
            this.buttonResidencia.Name = "buttonResidencia";
            this.buttonResidencia.Size = new System.Drawing.Size(169, 40);
            this.buttonResidencia.TabIndex = 52;
            this.buttonResidencia.UseVisualStyleBackColor = false;
            this.buttonResidencia.Click += new System.EventHandler(this.buttonResidencia_Click);
            // 
            // buttonInformacionAcademica
            // 
            this.buttonInformacionAcademica.BackColor = System.Drawing.Color.Transparent;
            this.buttonInformacionAcademica.FlatAppearance.BorderSize = 0;
            this.buttonInformacionAcademica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformacionAcademica.Location = new System.Drawing.Point(227, 270);
            this.buttonInformacionAcademica.Name = "buttonInformacionAcademica";
            this.buttonInformacionAcademica.Size = new System.Drawing.Size(155, 40);
            this.buttonInformacionAcademica.TabIndex = 51;
            this.buttonInformacionAcademica.UseVisualStyleBackColor = false;
            this.buttonInformacionAcademica.Click += new System.EventHandler(this.buttonInformacionAcademica_Click);
            // 
            // buttonInformacionBasica
            // 
            this.buttonInformacionBasica.BackColor = System.Drawing.Color.Transparent;
            this.buttonInformacionBasica.FlatAppearance.BorderSize = 0;
            this.buttonInformacionBasica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformacionBasica.Location = new System.Drawing.Point(229, 219);
            this.buttonInformacionBasica.Name = "buttonInformacionBasica";
            this.buttonInformacionBasica.Size = new System.Drawing.Size(155, 40);
            this.buttonInformacionBasica.TabIndex = 50;
            this.buttonInformacionBasica.UseVisualStyleBackColor = false;
            this.buttonInformacionBasica.Click += new System.EventHandler(this.buttonInformacionBasica_Click);
            // 
            // buttonPatrimonio
            // 
            this.buttonPatrimonio.BackColor = System.Drawing.Color.Transparent;
            this.buttonPatrimonio.FlatAppearance.BorderSize = 0;
            this.buttonPatrimonio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatrimonio.Location = new System.Drawing.Point(221, 370);
            this.buttonPatrimonio.Name = "buttonPatrimonio";
            this.buttonPatrimonio.Size = new System.Drawing.Size(169, 40);
            this.buttonPatrimonio.TabIndex = 53;
            this.buttonPatrimonio.UseVisualStyleBackColor = false;
            this.buttonPatrimonio.Click += new System.EventHandler(this.buttonPatrimonio_Click);
            // 
            // F22VEINInformacionPersonalDetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalPOO.Properties.Resources.Screenshot_35;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPatrimonio);
            this.Controls.Add(this.buttonResidencia);
            this.Controls.Add(this.buttonInformacionAcademica);
            this.Controls.Add(this.buttonInformacionBasica);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "F22VEINInformacionPersonalDetallada";
            this.Text = "Informacion personal detallada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonResidencia;
        private System.Windows.Forms.Button buttonInformacionAcademica;
        private System.Windows.Forms.Button buttonInformacionBasica;
        private System.Windows.Forms.Button buttonPatrimonio;
    }
}