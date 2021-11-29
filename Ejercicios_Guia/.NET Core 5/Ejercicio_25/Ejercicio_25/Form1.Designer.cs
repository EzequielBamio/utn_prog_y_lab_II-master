
namespace Ejercicio_25
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
            this.btnBinADec = new System.Windows.Forms.Button();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.lblBinADec = new System.Windows.Forms.Label();
            this.txtBinADec = new System.Windows.Forms.TextBox();
            this.txtDecABin = new System.Windows.Forms.TextBox();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnDecABin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBinADec
            // 
            this.btnBinADec.Location = new System.Drawing.Point(240, 25);
            this.btnBinADec.Name = "btnBinADec";
            this.btnBinADec.Size = new System.Drawing.Size(75, 23);
            this.btnBinADec.TabIndex = 0;
            this.btnBinADec.Text = "->";
            this.btnBinADec.UseVisualStyleBackColor = true;
            this.btnBinADec.Click += new System.EventHandler(this.btnBinADec_Click);
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(134, 25);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 23);
            this.txtBinario.TabIndex = 1;
            this.txtBinario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinario_KeyPress);
            // 
            // lblBinADec
            // 
            this.lblBinADec.AutoSize = true;
            this.lblBinADec.Location = new System.Drawing.Point(29, 29);
            this.lblBinADec.Name = "lblBinADec";
            this.lblBinADec.Size = new System.Drawing.Size(99, 15);
            this.lblBinADec.TabIndex = 2;
            this.lblBinADec.Text = "Binario a Decimal";
            // 
            // txtBinADec
            // 
            this.txtBinADec.Enabled = false;
            this.txtBinADec.Location = new System.Drawing.Point(321, 25);
            this.txtBinADec.Name = "txtBinADec";
            this.txtBinADec.Size = new System.Drawing.Size(100, 23);
            this.txtBinADec.TabIndex = 3;
            // 
            // txtDecABin
            // 
            this.txtDecABin.Enabled = false;
            this.txtDecABin.Location = new System.Drawing.Point(321, 60);
            this.txtDecABin.Name = "txtDecABin";
            this.txtDecABin.Size = new System.Drawing.Size(100, 23);
            this.txtDecABin.TabIndex = 7;
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(29, 64);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(99, 15);
            this.lblDecimal.TabIndex = 6;
            this.lblDecimal.Text = "Decimal a Binario";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(134, 60);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 23);
            this.txtDecimal.TabIndex = 5;
            this.txtDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // btnDecABin
            // 
            this.btnDecABin.Location = new System.Drawing.Point(240, 60);
            this.btnDecABin.Name = "btnDecABin";
            this.btnDecABin.Size = new System.Drawing.Size(75, 23);
            this.btnDecABin.TabIndex = 4;
            this.btnDecABin.Text = "->";
            this.btnDecABin.UseVisualStyleBackColor = true;
            this.btnDecABin.Click += new System.EventHandler(this.btnDecABin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 117);
            this.Controls.Add(this.txtDecABin);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.btnDecABin);
            this.Controls.Add(this.txtBinADec);
            this.Controls.Add(this.lblBinADec);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.btnBinADec);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinADec;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Label lblBinADec;
        private System.Windows.Forms.TextBox txtBinADec;
        private System.Windows.Forms.TextBox txtDecABin;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnDecABin;
    }
}

