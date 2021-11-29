
namespace Ejercicio_23
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBloqued = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPesos = new System.Windows.Forms.TextBox();
            this.txtEuroPesos = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtCantidadEuro = new System.Windows.Forms.TextBox();
            this.txtDolarPesos = new System.Windows.Forms.TextBox();
            this.txtCantidadDolar = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtCantidadPesos = new System.Windows.Forms.TextBox();
            this.txtPesosDolar = new System.Windows.Forms.TextBox();
            this.txtPesosEuro = new System.Windows.Forms.TextBox();
            this.LblEuro = new System.Windows.Forms.Label();
            this.LblDolar = new System.Windows.Forms.Label();
            this.LblPeso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBloqued
            // 
            this.btnBloqued.ImageIndex = 1;
            this.btnBloqued.ImageList = this.imgList;
            this.btnBloqued.Location = new System.Drawing.Point(171, 8);
            this.btnBloqued.Margin = new System.Windows.Forms.Padding(0);
            this.btnBloqued.Name = "btnBloqued";
            this.btnBloqued.Size = new System.Drawing.Size(75, 30);
            this.btnBloqued.TabIndex = 0;
            this.btnBloqued.UseVisualStyleBackColor = true;
            this.btnBloqued.Click += new System.EventHandler(this.btnBloqued_Click);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "bloqueado.png");
            this.imgList.Images.SetKeyName(1, "bloqueado (1).png");
            // 
            // btnEuro
            // 
            this.btnEuro.Location = new System.Drawing.Point(171, 77);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(75, 23);
            this.btnEuro.TabIndex = 1;
            this.btnEuro.Text = "->";
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(171, 106);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(75, 23);
            this.btnDolar.TabIndex = 2;
            this.btnDolar.Text = "->";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(171, 136);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(75, 23);
            this.btnPeso.TabIndex = 3;
            this.btnPeso.Text = "->";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(65, 136);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 23);
            this.txtPesos.TabIndex = 4;
            this.txtPesos.Text = "100";
            this.txtPesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesos_KeyPress);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(65, 78);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 23);
            this.txtEuro.TabIndex = 5;
            this.txtEuro.Text = "100";
            this.txtEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEuro_KeyPress);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(65, 107);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 23);
            this.txtDolar.TabIndex = 6;
            this.txtDolar.Text = "100";
            this.txtDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolar_KeyPress);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(263, 13);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionEuro.TabIndex = 7;
            this.txtCotizacionEuro.TextChanged += new System.EventHandler(this.txtCotizacionEuro_TextChanged);
            this.txtCotizacionEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCotizacionEuro_KeyPress);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Enabled = false;
            this.txtCotizacionDolar.Location = new System.Drawing.Point(369, 13);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionDolar.TabIndex = 8;
            // 
            // txtCotizacionPesos
            // 
            this.txtCotizacionPesos.Location = new System.Drawing.Point(475, 13);
            this.txtCotizacionPesos.Name = "txtCotizacionPesos";
            this.txtCotizacionPesos.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionPesos.TabIndex = 9;
            this.txtCotizacionPesos.TextChanged += new System.EventHandler(this.txtCotizacionPesos_TextChanged);
            this.txtCotizacionPesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCotizacionPesos_KeyPress);
            // 
            // txtEuroPesos
            // 
            this.txtEuroPesos.Location = new System.Drawing.Point(475, 77);
            this.txtEuroPesos.Name = "txtEuroPesos";
            this.txtEuroPesos.ReadOnly = true;
            this.txtEuroPesos.Size = new System.Drawing.Size(100, 23);
            this.txtEuroPesos.TabIndex = 12;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.Location = new System.Drawing.Point(369, 77);
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.ReadOnly = true;
            this.txtEuroDolar.Size = new System.Drawing.Size(100, 23);
            this.txtEuroDolar.TabIndex = 11;
            // 
            // txtCantidadEuro
            // 
            this.txtCantidadEuro.Location = new System.Drawing.Point(263, 77);
            this.txtCantidadEuro.Name = "txtCantidadEuro";
            this.txtCantidadEuro.ReadOnly = true;
            this.txtCantidadEuro.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadEuro.TabIndex = 10;
            // 
            // txtDolarPesos
            // 
            this.txtDolarPesos.Location = new System.Drawing.Point(475, 107);
            this.txtDolarPesos.Name = "txtDolarPesos";
            this.txtDolarPesos.ReadOnly = true;
            this.txtDolarPesos.Size = new System.Drawing.Size(100, 23);
            this.txtDolarPesos.TabIndex = 15;
            // 
            // txtCantidadDolar
            // 
            this.txtCantidadDolar.Location = new System.Drawing.Point(369, 107);
            this.txtCantidadDolar.Name = "txtCantidadDolar";
            this.txtCantidadDolar.ReadOnly = true;
            this.txtCantidadDolar.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadDolar.TabIndex = 14;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Location = new System.Drawing.Point(263, 107);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.ReadOnly = true;
            this.txtDolarEuro.Size = new System.Drawing.Size(100, 23);
            this.txtDolarEuro.TabIndex = 13;
            // 
            // txtCantidadPesos
            // 
            this.txtCantidadPesos.Location = new System.Drawing.Point(475, 137);
            this.txtCantidadPesos.Name = "txtCantidadPesos";
            this.txtCantidadPesos.ReadOnly = true;
            this.txtCantidadPesos.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadPesos.TabIndex = 18;
            // 
            // txtPesosDolar
            // 
            this.txtPesosDolar.Location = new System.Drawing.Point(369, 137);
            this.txtPesosDolar.Name = "txtPesosDolar";
            this.txtPesosDolar.ReadOnly = true;
            this.txtPesosDolar.Size = new System.Drawing.Size(100, 23);
            this.txtPesosDolar.TabIndex = 17;
            // 
            // txtPesosEuro
            // 
            this.txtPesosEuro.Location = new System.Drawing.Point(263, 137);
            this.txtPesosEuro.Name = "txtPesosEuro";
            this.txtPesosEuro.ReadOnly = true;
            this.txtPesosEuro.Size = new System.Drawing.Size(100, 23);
            this.txtPesosEuro.TabIndex = 16;
            // 
            // LblEuro
            // 
            this.LblEuro.AutoSize = true;
            this.LblEuro.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEuro.Location = new System.Drawing.Point(263, 56);
            this.LblEuro.Name = "LblEuro";
            this.LblEuro.Size = new System.Drawing.Size(38, 17);
            this.LblEuro.TabIndex = 22;
            this.LblEuro.Text = "Euro";
            // 
            // LblDolar
            // 
            this.LblDolar.AutoSize = true;
            this.LblDolar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDolar.Location = new System.Drawing.Point(369, 57);
            this.LblDolar.Name = "LblDolar";
            this.LblDolar.Size = new System.Drawing.Size(42, 17);
            this.LblDolar.TabIndex = 26;
            this.LblDolar.Text = "Dolar";
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPeso.Location = new System.Drawing.Point(475, 57);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(40, 17);
            this.LblPeso.TabIndex = 27;
            this.LblPeso.Text = "Peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Euro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(99, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cotizacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(590, 202);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.LblDolar);
            this.Controls.Add(this.LblEuro);
            this.Controls.Add(this.txtCantidadPesos);
            this.Controls.Add(this.txtPesosDolar);
            this.Controls.Add(this.txtPesosEuro);
            this.Controls.Add(this.txtDolarPesos);
            this.Controls.Add(this.txtCantidadDolar);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtEuroPesos);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtCantidadEuro);
            this.Controls.Add(this.txtCotizacionPesos);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnBloqued);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBloqued;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionPesos;
        private System.Windows.Forms.TextBox txtEuroPesos;
        private System.Windows.Forms.TextBox txtEuroDolar;
        private System.Windows.Forms.TextBox txtCantidadEuro;
        private System.Windows.Forms.TextBox txtDolarPesos;
        private System.Windows.Forms.TextBox txtCantidadDolar;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtCantidadPesos;
        private System.Windows.Forms.TextBox txtPesosDolar;
        private System.Windows.Forms.TextBox txtPesosEuro;
        private System.Windows.Forms.Label LblEuro;
        private System.Windows.Forms.Label LblDolar;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imgList;
    }
}

