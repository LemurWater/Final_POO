﻿
namespace FinalPOO.Forms
{
    partial class F20VEINCesantias
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
            this.buttonVacaciones = new System.Windows.Forms.Button();
            this.buttonPrima = new System.Windows.Forms.Button();
            this.buttonSalarioNeto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(746, 47);
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
            this.button1.Location = new System.Drawing.Point(689, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVacaciones
            // 
            this.buttonVacaciones.BackColor = System.Drawing.Color.Transparent;
            this.buttonVacaciones.FlatAppearance.BorderSize = 0;
            this.buttonVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVacaciones.Location = new System.Drawing.Point(147, 362);
            this.buttonVacaciones.Name = "buttonVacaciones";
            this.buttonVacaciones.Size = new System.Drawing.Size(155, 40);
            this.buttonVacaciones.TabIndex = 52;
            this.buttonVacaciones.UseVisualStyleBackColor = false;
            this.buttonVacaciones.Click += new System.EventHandler(this.buttonVacaciones_Click);
            // 
            // buttonPrima
            // 
            this.buttonPrima.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrima.FlatAppearance.BorderSize = 0;
            this.buttonPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrima.Location = new System.Drawing.Point(146, 301);
            this.buttonPrima.Name = "buttonPrima";
            this.buttonPrima.Size = new System.Drawing.Size(155, 40);
            this.buttonPrima.TabIndex = 51;
            this.buttonPrima.UseVisualStyleBackColor = false;
            this.buttonPrima.Click += new System.EventHandler(this.buttonPrima_Click);
            // 
            // buttonSalarioNeto
            // 
            this.buttonSalarioNeto.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalarioNeto.FlatAppearance.BorderSize = 0;
            this.buttonSalarioNeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalarioNeto.Location = new System.Drawing.Point(147, 238);
            this.buttonSalarioNeto.Name = "buttonSalarioNeto";
            this.buttonSalarioNeto.Size = new System.Drawing.Size(155, 40);
            this.buttonSalarioNeto.TabIndex = 50;
            this.buttonSalarioNeto.UseVisualStyleBackColor = false;
            this.buttonSalarioNeto.Click += new System.EventHandler(this.buttonSalarioNeto_Click);
            // 
            // F20VEINCesantias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalPOO.Properties.Resources.Screenshot_42;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVacaciones);
            this.Controls.Add(this.buttonPrima);
            this.Controls.Add(this.buttonSalarioNeto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "F20VEINCesantias";
            this.Text = "Informacion Nominal - Cesantias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVacaciones;
        private System.Windows.Forms.Button buttonPrima;
        private System.Windows.Forms.Button buttonSalarioNeto;
    }
}