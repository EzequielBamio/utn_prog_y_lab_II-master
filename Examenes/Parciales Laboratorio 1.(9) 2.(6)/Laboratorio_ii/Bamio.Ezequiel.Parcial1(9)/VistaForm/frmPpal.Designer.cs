
namespace VistaForm
{
    partial class frmPpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPpal));
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.picStormtrooperHelmet = new System.Windows.Forms.PictureBox();
            this.lstEjercito = new System.Windows.Forms.ListBox();
            this.cmbBlasters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbEsClon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStormtrooperHelmet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(11, 451);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(227, 49);
            this.btnQuitar.TabIndex = 0;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 396);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(227, 49);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 13);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(13, 37);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(226, 28);
            this.cmbTipo.TabIndex = 4;
            // 
            // picStormtrooperHelmet
            // 
            this.picStormtrooperHelmet.Image = global::VistaForm.Properties.Resources.stormtrooper;
            this.picStormtrooperHelmet.Location = new System.Drawing.Point(57, 254);
            this.picStormtrooperHelmet.Name = "picStormtrooperHelmet";
            this.picStormtrooperHelmet.Size = new System.Drawing.Size(128, 128);
            this.picStormtrooperHelmet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStormtrooperHelmet.TabIndex = 5;
            this.picStormtrooperHelmet.TabStop = false;
            // 
            // lstEjercito
            // 
            this.lstEjercito.FormattingEnabled = true;
            this.lstEjercito.ItemHeight = 20;
            this.lstEjercito.Location = new System.Drawing.Point(245, 12);
            this.lstEjercito.Name = "lstEjercito";
            this.lstEjercito.Size = new System.Drawing.Size(686, 484);
            this.lstEjercito.TabIndex = 6;
            // 
            // cmbBlasters
            // 
            this.cmbBlasters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlasters.FormattingEnabled = true;
            this.cmbBlasters.Location = new System.Drawing.Point(12, 98);
            this.cmbBlasters.Name = "cmbBlasters";
            this.cmbBlasters.Size = new System.Drawing.Size(226, 28);
            this.cmbBlasters.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Blasters";
            // 
            // ckbEsClon
            // 
            this.ckbEsClon.AutoSize = true;
            this.ckbEsClon.Location = new System.Drawing.Point(11, 144);
            this.ckbEsClon.Name = "ckbEsClon";
            this.ckbEsClon.Size = new System.Drawing.Size(77, 24);
            this.ckbEsClon.TabIndex = 10;
            this.ckbEsClon.Text = "Es clon";
            this.ckbEsClon.UseVisualStyleBackColor = true;
            // 
            // frmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 512);
            this.Controls.Add(this.ckbEsClon);
            this.Controls.Add(this.cmbBlasters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEjercito);
            this.Controls.Add(this.picStormtrooperHelmet);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos a la fabrica de troopers del Lado Oscuro";
            this.Load += new System.EventHandler(this.FrmVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStormtrooperHelmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.PictureBox picStormtrooperHelmet;
        private System.Windows.Forms.ListBox lstEjercito;
        private System.Windows.Forms.ComboBox cmbBlasters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbEsClon;
    }
}

