
namespace FinalPOO.Forms
{
    partial class F16VEInformacionNominal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonInformacionNominal = new System.Windows.Forms.Button();
            this.buttonInformacionPersonalDetallada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(687, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(744, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 40);
            this.button2.TabIndex = 43;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInformacionNominal
            // 
            this.buttonInformacionNominal.BackColor = System.Drawing.Color.Transparent;
            this.buttonInformacionNominal.FlatAppearance.BorderSize = 0;
            this.buttonInformacionNominal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformacionNominal.Location = new System.Drawing.Point(148, 103);
            this.buttonInformacionNominal.Name = "buttonInformacionNominal";
            this.buttonInformacionNominal.Size = new System.Drawing.Size(308, 40);
            this.buttonInformacionNominal.TabIndex = 44;
            this.buttonInformacionNominal.UseVisualStyleBackColor = false;
            this.buttonInformacionNominal.Click += new System.EventHandler(this.buttonInformacionNominal_Click);
            // 
            // buttonInformacionPersonalDetallada
            // 
            this.buttonInformacionPersonalDetallada.BackColor = System.Drawing.Color.Transparent;
            this.buttonInformacionPersonalDetallada.FlatAppearance.BorderSize = 0;
            this.buttonInformacionPersonalDetallada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformacionPersonalDetallada.Location = new System.Drawing.Point(476, 103);
            this.buttonInformacionPersonalDetallada.Name = "buttonInformacionPersonalDetallada";
            this.buttonInformacionPersonalDetallada.Size = new System.Drawing.Size(308, 40);
            this.buttonInformacionPersonalDetallada.TabIndex = 45;
            this.buttonInformacionPersonalDetallada.UseVisualStyleBackColor = false;
            this.buttonInformacionPersonalDetallada.Click += new System.EventHandler(this.buttonInformacionPersonalDetallada_Click);
            // 
            // F16VEInformacionNominal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalPOO.Properties.Resources.Screenshot_33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInformacionPersonalDetallada);
            this.Controls.Add(this.buttonInformacionNominal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "F16VEInformacionNominal";
            this.Text = "Informacion Nominal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonInformacionNominal;
        private System.Windows.Forms.Button buttonInformacionPersonalDetallada;
    }
}