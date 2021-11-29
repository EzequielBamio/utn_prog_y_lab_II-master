
namespace VistaForm
{
    partial class FrmEntregarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntregarPedidos));
            this.picCamion = new System.Windows.Forms.PictureBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.pgbEntregas = new System.Windows.Forms.ProgressBar();
            this.btnReniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFacturas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // picCamion
            // 
            this.picCamion.Image = global::VistaForm.Properties.Resources.Truck;
            this.picCamion.Location = new System.Drawing.Point(0, 12);
            this.picCamion.Name = "picCamion";
            this.picCamion.Size = new System.Drawing.Size(441, 264);
            this.picCamion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion.TabIndex = 0;
            this.picCamion.TabStop = false;
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(393, 344);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(205, 44);
            this.btnEstado.TabIndex = 1;
            this.btnEstado.Text = "Empezar";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // pgbEntregas
            // 
            this.pgbEntregas.Location = new System.Drawing.Point(393, 282);
            this.pgbEntregas.Maximum = 402;
            this.pgbEntregas.Name = "pgbEntregas";
            this.pgbEntregas.Size = new System.Drawing.Size(205, 23);
            this.pgbEntregas.TabIndex = 2;
            // 
            // btnReniciar
            // 
            this.btnReniciar.Enabled = false;
            this.btnReniciar.Location = new System.Drawing.Point(393, 394);
            this.btnReniciar.Name = "btnReniciar";
            this.btnReniciar.Size = new System.Drawing.Size(205, 44);
            this.btnReniciar.TabIndex = 4;
            this.btnReniciar.Text = "Hacer otra entrega";
            this.btnReniciar.UseVisualStyleBackColor = true;
            this.btnReniciar.Click += new System.EventHandler(this.btnReniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Facturas no pagas";
            // 
            // lstFacturas
            // 
            this.lstFacturas.FormattingEnabled = true;
            this.lstFacturas.ItemHeight = 15;
            this.lstFacturas.Location = new System.Drawing.Point(12, 344);
            this.lstFacturas.Name = "lstFacturas";
            this.lstFacturas.Size = new System.Drawing.Size(375, 94);
            this.lstFacturas.TabIndex = 7;
            // 
            // FrmEntregarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.lstFacturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReniciar);
            this.Controls.Add(this.pgbEntregas);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.picCamion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntregarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregar pedidos";
            this.Load += new System.EventHandler(this.FrmEntregarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCamion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCamion;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.ProgressBar pgbEntregas;
        private System.Windows.Forms.Button btnReniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFacturas;
    }
}