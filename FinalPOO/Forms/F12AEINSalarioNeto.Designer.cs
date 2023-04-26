
namespace FinalPOO.Forms
{
    partial class F12AEINSalarioNeto
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
            this.buttonVacaciones = new System.Windows.Forms.Button();
            this.buttonCesantias = new System.Windows.Forms.Button();
            this.buttonPrima = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVacaciones
            // 
            this.buttonVacaciones.BackColor = System.Drawing.Color.Transparent;
            this.buttonVacaciones.FlatAppearance.BorderSize = 0;
            this.buttonVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVacaciones.Location = new System.Drawing.Point(23, 363);
            this.buttonVacaciones.Name = "buttonVacaciones";
            this.buttonVacaciones.Size = new System.Drawing.Size(183, 40);
            this.buttonVacaciones.TabIndex = 38;
            this.buttonVacaciones.UseVisualStyleBackColor = false;
            this.buttonVacaciones.Click += new System.EventHandler(this.buttonVacaciones_Click);
            // 
            // buttonCesantias
            // 
            this.buttonCesantias.BackColor = System.Drawing.Color.Transparent;
            this.buttonCesantias.FlatAppearance.BorderSize = 0;
            this.buttonCesantias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCesantias.Location = new System.Drawing.Point(22, 301);
            this.buttonCesantias.Name = "buttonCesantias";
            this.buttonCesantias.Size = new System.Drawing.Size(182, 40);
            this.buttonCesantias.TabIndex = 37;
            this.buttonCesantias.UseVisualStyleBackColor = false;
            this.buttonCesantias.Click += new System.EventHandler(this.buttonCesantias_Click);
            // 
            // buttonPrima
            // 
            this.buttonPrima.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrima.FlatAppearance.BorderSize = 0;
            this.buttonPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrima.Location = new System.Drawing.Point(22, 237);
            this.buttonPrima.Name = "buttonPrima";
            this.buttonPrima.Size = new System.Drawing.Size(186, 40);
            this.buttonPrima.TabIndex = 36;
            this.buttonPrima.UseVisualStyleBackColor = false;
            this.buttonPrima.Click += new System.EventHandler(this.buttonPrima_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(747, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 40);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(690, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(562, 43);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(119, 40);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Location = new System.Drawing.Point(435, 43);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(119, 40);
            this.buttonGuardar.TabIndex = 32;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // F12AEINSalarioNeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalPOO.Properties.Resources.Screenshot_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVacaciones);
            this.Controls.Add(this.buttonCesantias);
            this.Controls.Add(this.buttonPrima);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.DoubleBuffered = true;
            this.Name = "F12AEINSalarioNeto";
            this.Text = "Agregar nuevo empleado - Informacion nominal - Salario neto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVacaciones;
        private System.Windows.Forms.Button buttonCesantias;
        private System.Windows.Forms.Button buttonPrima;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}