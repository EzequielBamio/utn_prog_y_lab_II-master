
namespace Ejercicio_24
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnF = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtFaAFa = new System.Windows.Forms.TextBox();
            this.txtFaACe = new System.Windows.Forms.TextBox();
            this.txtFaAKe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCeAKe = new System.Windows.Forms.TextBox();
            this.txtCeACe = new System.Windows.Forms.TextBox();
            this.txtCeAFa = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.txtKeAKe = new System.Windows.Forms.TextBox();
            this.txtKeACe = new System.Windows.Forms.TextBox();
            this.txtKeAFa = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.btnK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(224, 48);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 23);
            this.btnF.TabIndex = 0;
            this.btnF.Text = "->";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(10, 52);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(63, 15);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(118, 49);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 23);
            this.txtF.TabIndex = 2;
            this.txtF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtF_KeyPress);
            // 
            // txtFaAFa
            // 
            this.txtFaAFa.Enabled = false;
            this.txtFaAFa.Location = new System.Drawing.Point(305, 48);
            this.txtFaAFa.Name = "txtFaAFa";
            this.txtFaAFa.Size = new System.Drawing.Size(100, 23);
            this.txtFaAFa.TabIndex = 3;
            // 
            // txtFaACe
            // 
            this.txtFaACe.Enabled = false;
            this.txtFaACe.Location = new System.Drawing.Point(411, 48);
            this.txtFaACe.Name = "txtFaACe";
            this.txtFaACe.Size = new System.Drawing.Size(100, 23);
            this.txtFaACe.TabIndex = 4;
            // 
            // txtFaAKe
            // 
            this.txtFaAKe.Enabled = false;
            this.txtFaAKe.Location = new System.Drawing.Point(516, 48);
            this.txtFaAKe.Name = "txtFaAKe";
            this.txtFaAKe.Size = new System.Drawing.Size(100, 23);
            this.txtFaAKe.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fahrenheit";
            // 
            // txtCeAKe
            // 
            this.txtCeAKe.Enabled = false;
            this.txtCeAKe.Location = new System.Drawing.Point(516, 77);
            this.txtCeAKe.Name = "txtCeAKe";
            this.txtCeAKe.Size = new System.Drawing.Size(100, 23);
            this.txtCeAKe.TabIndex = 12;
            // 
            // txtCeACe
            // 
            this.txtCeACe.Enabled = false;
            this.txtCeACe.Location = new System.Drawing.Point(411, 77);
            this.txtCeACe.Name = "txtCeACe";
            this.txtCeACe.Size = new System.Drawing.Size(100, 23);
            this.txtCeACe.TabIndex = 11;
            // 
            // txtCeAFa
            // 
            this.txtCeAFa.Enabled = false;
            this.txtCeAFa.Location = new System.Drawing.Point(305, 77);
            this.txtCeAFa.Name = "txtCeAFa";
            this.txtCeAFa.Size = new System.Drawing.Size(100, 23);
            this.txtCeAFa.TabIndex = 10;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(118, 78);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 23);
            this.txtC.TabIndex = 9;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(10, 81);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(44, 15);
            this.lblCelsius.TabIndex = 8;
            this.lblCelsius.Text = "Celsius";
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(224, 77);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "->";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtKeAKe
            // 
            this.txtKeAKe.Enabled = false;
            this.txtKeAKe.Location = new System.Drawing.Point(516, 106);
            this.txtKeAKe.Name = "txtKeAKe";
            this.txtKeAKe.Size = new System.Drawing.Size(100, 23);
            this.txtKeAKe.TabIndex = 18;
            // 
            // txtKeACe
            // 
            this.txtKeACe.Enabled = false;
            this.txtKeACe.Location = new System.Drawing.Point(411, 106);
            this.txtKeACe.Name = "txtKeACe";
            this.txtKeACe.Size = new System.Drawing.Size(100, 23);
            this.txtKeACe.TabIndex = 17;
            // 
            // txtKeAFa
            // 
            this.txtKeAFa.Enabled = false;
            this.txtKeAFa.Location = new System.Drawing.Point(305, 106);
            this.txtKeAFa.Name = "txtKeAFa";
            this.txtKeAFa.Size = new System.Drawing.Size(100, 23);
            this.txtKeAFa.TabIndex = 16;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(118, 107);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 23);
            this.txtK.TabIndex = 15;
            this.txtK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK_KeyPress);
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(10, 110);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(39, 15);
            this.lblKelvin.TabIndex = 14;
            this.lblKelvin.Text = "Kelvin";
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(224, 106);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(75, 23);
            this.btnK.TabIndex = 13;
            this.btnK.Text = "->";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 148);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKeAKe);
            this.Controls.Add(this.txtKeACe);
            this.Controls.Add(this.txtKeAFa);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.txtCeAKe);
            this.Controls.Add(this.txtCeACe);
            this.Controls.Add(this.txtCeAFa);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFaAKe);
            this.Controls.Add(this.txtFaACe);
            this.Controls.Add(this.txtFaAFa);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnF);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtFaAFa;
        private System.Windows.Forms.TextBox txtFaACe;
        private System.Windows.Forms.TextBox txtFaAKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCeAKe;
        private System.Windows.Forms.TextBox txtCeACe;
        private System.Windows.Forms.TextBox txtCeAFa;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.TextBox txtKeAKe;
        private System.Windows.Forms.TextBox txtKeACe;
        private System.Windows.Forms.TextBox txtKeAFa;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

