
namespace frmCentralTelefonica
{
    partial class FrmLlamador
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
            this.btnLlamar = new System.Windows.Forms.Button();
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.gbxPanel = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btnNumCero = new System.Windows.Forms.Button();
            this.btnAsterico = new System.Windows.Forms.Button();
            this.btnNumNueve = new System.Windows.Forms.Button();
            this.btnNumCinco = new System.Windows.Forms.Button();
            this.btnNumUno = new System.Windows.Forms.Button();
            this.btnNumOcho = new System.Windows.Forms.Button();
            this.btnNumDos = new System.Windows.Forms.Button();
            this.btnNumTres = new System.Windows.Forms.Button();
            this.btnNumSiete = new System.Windows.Forms.Button();
            this.btnNumCuatro = new System.Windows.Forms.Button();
            this.btnNumSeis = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.gbxPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(210, 76);
            this.btnLlamar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(137, 38);
            this.btnLlamar.TabIndex = 0;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNroDestino.Location = new System.Drawing.Point(10, 16);
            this.txtNroDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroDestino.MaxLength = 23;
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.ReadOnly = true;
            this.txtNroDestino.Size = new System.Drawing.Size(337, 36);
            this.txtNroDestino.TabIndex = 1;
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroDestino.TextChanged += new System.EventHandler(this.txtNroDestino_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(210, 118);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 38);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNroOrigen.Location = new System.Drawing.Point(210, 169);
            this.txtNroOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(138, 29);
            this.txtNroOrigen.TabIndex = 4;
            this.txtNroOrigen.Text = "Nro Origen";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(210, 203);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbFranja
            // 
            this.cmbFranja.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(10, 293);
            this.cmbFranja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(337, 33);
            this.cmbFranja.TabIndex = 6;
            this.cmbFranja.Text = "Franja";
            // 
            // gbxPanel
            // 
            this.gbxPanel.Controls.Add(this.groupBox1);
            this.gbxPanel.Controls.Add(this.btnNum9);
            this.gbxPanel.Controls.Add(this.btnNum5);
            this.gbxPanel.Controls.Add(this.btnNum1);
            this.gbxPanel.Controls.Add(this.btnNum8);
            this.gbxPanel.Controls.Add(this.btnNum2);
            this.gbxPanel.Controls.Add(this.btnNum3);
            this.gbxPanel.Controls.Add(this.btnNum7);
            this.gbxPanel.Controls.Add(this.btnNum4);
            this.gbxPanel.Controls.Add(this.btnNum6);
            this.gbxPanel.Location = new System.Drawing.Point(10, 62);
            this.gbxPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPanel.Name = "gbxPanel";
            this.gbxPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPanel.Size = new System.Drawing.Size(194, 198);
            this.gbxPanel.TabIndex = 12;
            this.gbxPanel.TabStop = false;
            this.gbxPanel.Text = "Panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNumeral);
            this.groupBox1.Controls.Add(this.btnNumCero);
            this.groupBox1.Controls.Add(this.btnAsterico);
            this.groupBox1.Controls.Add(this.btnNumNueve);
            this.groupBox1.Controls.Add(this.btnNumCinco);
            this.groupBox1.Controls.Add(this.btnNumUno);
            this.groupBox1.Controls.Add(this.btnNumOcho);
            this.groupBox1.Controls.Add(this.btnNumDos);
            this.groupBox1.Controls.Add(this.btnNumTres);
            this.groupBox1.Controls.Add(this.btnNumSiete);
            this.groupBox1.Controls.Add(this.btnNumCuatro);
            this.groupBox1.Controls.Add(this.btnNumSeis);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(194, 221);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(127, 156);
            this.btnNumeral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(47, 38);
            this.btnNumeral.TabIndex = 14;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // btnNumCero
            // 
            this.btnNumCero.Location = new System.Drawing.Point(74, 156);
            this.btnNumCero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumCero.Name = "btnNumCero";
            this.btnNumCero.Size = new System.Drawing.Size(47, 38);
            this.btnNumCero.TabIndex = 13;
            this.btnNumCero.Text = "0";
            this.btnNumCero.UseVisualStyleBackColor = true;
            this.btnNumCero.Click += new System.EventHandler(this.btnNumCero_Click);
            // 
            // btnAsterico
            // 
            this.btnAsterico.Location = new System.Drawing.Point(22, 156);
            this.btnAsterico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsterico.Name = "btnAsterico";
            this.btnAsterico.Size = new System.Drawing.Size(47, 38);
            this.btnAsterico.TabIndex = 12;
            this.btnAsterico.Text = "*";
            this.btnAsterico.UseVisualStyleBackColor = true;
            this.btnAsterico.Click += new System.EventHandler(this.btnAsterico_Click);
            // 
            // btnNumNueve
            // 
            this.btnNumNueve.Location = new System.Drawing.Point(127, 115);
            this.btnNumNueve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumNueve.Name = "btnNumNueve";
            this.btnNumNueve.Size = new System.Drawing.Size(47, 38);
            this.btnNumNueve.TabIndex = 11;
            this.btnNumNueve.Text = "9";
            this.btnNumNueve.UseVisualStyleBackColor = true;
            this.btnNumNueve.Click += new System.EventHandler(this.btnNumNueve_Click);
            // 
            // btnNumCinco
            // 
            this.btnNumCinco.Location = new System.Drawing.Point(74, 73);
            this.btnNumCinco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumCinco.Name = "btnNumCinco";
            this.btnNumCinco.Size = new System.Drawing.Size(47, 38);
            this.btnNumCinco.TabIndex = 7;
            this.btnNumCinco.Text = "5";
            this.btnNumCinco.UseVisualStyleBackColor = true;
            this.btnNumCinco.Click += new System.EventHandler(this.btnNumCinco_Click);
            // 
            // btnNumUno
            // 
            this.btnNumUno.Location = new System.Drawing.Point(22, 31);
            this.btnNumUno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumUno.Name = "btnNumUno";
            this.btnNumUno.Size = new System.Drawing.Size(47, 38);
            this.btnNumUno.TabIndex = 3;
            this.btnNumUno.Text = "1";
            this.btnNumUno.UseVisualStyleBackColor = true;
            this.btnNumUno.Click += new System.EventHandler(this.btnNumUno_Click);
            // 
            // btnNumOcho
            // 
            this.btnNumOcho.Location = new System.Drawing.Point(74, 115);
            this.btnNumOcho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumOcho.Name = "btnNumOcho";
            this.btnNumOcho.Size = new System.Drawing.Size(47, 38);
            this.btnNumOcho.TabIndex = 10;
            this.btnNumOcho.Text = "8";
            this.btnNumOcho.UseVisualStyleBackColor = true;
            this.btnNumOcho.Click += new System.EventHandler(this.btnNumOcho_Click);
            // 
            // btnNumDos
            // 
            this.btnNumDos.Location = new System.Drawing.Point(74, 31);
            this.btnNumDos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumDos.Name = "btnNumDos";
            this.btnNumDos.Size = new System.Drawing.Size(47, 38);
            this.btnNumDos.TabIndex = 4;
            this.btnNumDos.Text = "2";
            this.btnNumDos.UseVisualStyleBackColor = true;
            this.btnNumDos.Click += new System.EventHandler(this.btnNumDos_Click);
            // 
            // btnNumTres
            // 
            this.btnNumTres.Location = new System.Drawing.Point(127, 31);
            this.btnNumTres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumTres.Name = "btnNumTres";
            this.btnNumTres.Size = new System.Drawing.Size(47, 38);
            this.btnNumTres.TabIndex = 5;
            this.btnNumTres.Text = "3";
            this.btnNumTres.UseVisualStyleBackColor = true;
            this.btnNumTres.Click += new System.EventHandler(this.btnNumTres_Click);
            // 
            // btnNumSiete
            // 
            this.btnNumSiete.Location = new System.Drawing.Point(22, 115);
            this.btnNumSiete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumSiete.Name = "btnNumSiete";
            this.btnNumSiete.Size = new System.Drawing.Size(47, 38);
            this.btnNumSiete.TabIndex = 9;
            this.btnNumSiete.Text = "7";
            this.btnNumSiete.UseVisualStyleBackColor = true;
            this.btnNumSiete.Click += new System.EventHandler(this.btnNumSiete_Click);
            // 
            // btnNumCuatro
            // 
            this.btnNumCuatro.Location = new System.Drawing.Point(22, 73);
            this.btnNumCuatro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumCuatro.Name = "btnNumCuatro";
            this.btnNumCuatro.Size = new System.Drawing.Size(47, 38);
            this.btnNumCuatro.TabIndex = 6;
            this.btnNumCuatro.Text = "4";
            this.btnNumCuatro.UseVisualStyleBackColor = true;
            this.btnNumCuatro.Click += new System.EventHandler(this.btnNumCuatro_Click);
            // 
            // btnNumSeis
            // 
            this.btnNumSeis.Location = new System.Drawing.Point(127, 73);
            this.btnNumSeis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumSeis.Name = "btnNumSeis";
            this.btnNumSeis.Size = new System.Drawing.Size(47, 38);
            this.btnNumSeis.TabIndex = 8;
            this.btnNumSeis.Text = "6";
            this.btnNumSeis.UseVisualStyleBackColor = true;
            this.btnNumSeis.Click += new System.EventHandler(this.btnNumSeis_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(127, 115);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(47, 38);
            this.btnNum9.TabIndex = 11;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(74, 73);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(47, 38);
            this.btnNum5.TabIndex = 7;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(22, 31);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(47, 38);
            this.btnNum1.TabIndex = 3;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(74, 115);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(47, 38);
            this.btnNum8.TabIndex = 10;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(74, 31);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(47, 38);
            this.btnNum2.TabIndex = 4;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(127, 31);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(47, 38);
            this.btnNum3.TabIndex = 5;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(22, 115);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(47, 38);
            this.btnNum7.TabIndex = 9;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(22, 73);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(47, 38);
            this.btnNum4.TabIndex = 6;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(127, 73);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(47, 38);
            this.btnNum6.TabIndex = 8;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 332);
            this.Controls.Add(this.gbxPanel);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNroDestino);
            this.Controls.Add(this.btnLlamar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLlamador";
            this.Text = "Llamador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLlamador_FormClosing);
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.gbxPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.GroupBox gbxPanel;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btnNumCero;
        private System.Windows.Forms.Button btnAsterico;
        private System.Windows.Forms.Button btnNumNueve;
        private System.Windows.Forms.Button btnNumCinco;
        private System.Windows.Forms.Button btnNumUno;
        private System.Windows.Forms.Button btnNumOcho;
        private System.Windows.Forms.Button btnNumDos;
        private System.Windows.Forms.Button btnNumTres;
        private System.Windows.Forms.Button btnNumSiete;
        private System.Windows.Forms.Button btnNumCuatro;
        private System.Windows.Forms.Button btnNumSeis;
    }
}