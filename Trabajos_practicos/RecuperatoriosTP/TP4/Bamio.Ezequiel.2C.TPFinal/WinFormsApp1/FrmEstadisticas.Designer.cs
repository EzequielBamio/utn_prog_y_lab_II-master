
namespace VistaForm
{
    partial class FrmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvMeses = new System.Windows.Forms.DataGridView();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbAnalisis = new System.Windows.Forms.RichTextBox();
            this.btnEnvases = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnFabrica = new System.Windows.Forms.Button();
            this.cmbFiltrarMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Image = global::VistaForm.Properties.Resources.Close;
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 43);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvMeses
            // 
            this.dgvMeses.AllowUserToAddRows = false;
            this.dgvMeses.AllowUserToDeleteRows = false;
            this.dgvMeses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvMeses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMeses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMeses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mes,
            this.ventas,
            this.crecimiento,
            this.porcentaje});
            this.dgvMeses.Location = new System.Drawing.Point(6, 226);
            this.dgvMeses.Name = "dgvMeses";
            this.dgvMeses.ReadOnly = true;
            this.dgvMeses.RowTemplate.Height = 25;
            this.dgvMeses.Size = new System.Drawing.Size(618, 208);
            this.dgvMeses.TabIndex = 38;
            // 
            // mes
            // 
            this.mes.HeaderText = "Dia";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // ventas
            // 
            this.ventas.HeaderText = "Ventas";
            this.ventas.Name = "ventas";
            this.ventas.ReadOnly = true;
            // 
            // crecimiento
            // 
            this.crecimiento.HeaderText = "Crecimiento";
            this.crecimiento.Name = "crecimiento";
            this.crecimiento.ReadOnly = true;
            // 
            // porcentaje
            // 
            this.porcentaje.HeaderText = "% Frente al dia anterior";
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.ReadOnly = true;
            // 
            // rtbAnalisis
            // 
            this.rtbAnalisis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.rtbAnalisis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbAnalisis.ForeColor = System.Drawing.Color.White;
            this.rtbAnalisis.Location = new System.Drawing.Point(630, 46);
            this.rtbAnalisis.Name = "rtbAnalisis";
            this.rtbAnalisis.ReadOnly = true;
            this.rtbAnalisis.Size = new System.Drawing.Size(361, 388);
            this.rtbAnalisis.TabIndex = 46;
            this.rtbAnalisis.Text = "";
            // 
            // btnEnvases
            // 
            this.btnEnvases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEnvases.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEnvases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEnvases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnvases.ForeColor = System.Drawing.Color.Silver;
            this.btnEnvases.Location = new System.Drawing.Point(524, 91);
            this.btnEnvases.Name = "btnEnvases";
            this.btnEnvases.Size = new System.Drawing.Size(100, 39);
            this.btnEnvases.TabIndex = 47;
            this.btnEnvases.Text = "Envases";
            this.btnEnvases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnvases.UseVisualStyleBackColor = false;
            this.btnEnvases.Click += new System.EventHandler(this.btnEnvases_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEstado.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstado.ForeColor = System.Drawing.Color.Silver;
            this.btnEstado.Location = new System.Drawing.Point(524, 136);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(100, 39);
            this.btnEstado.TabIndex = 49;
            this.btnEstado.Text = "Estados";
            this.btnEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.ForeColor = System.Drawing.Color.Silver;
            this.btnProductos.Location = new System.Drawing.Point(524, 46);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(100, 39);
            this.btnProductos.TabIndex = 50;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnFabrica
            // 
            this.btnFabrica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnFabrica.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFabrica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnFabrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFabrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFabrica.ForeColor = System.Drawing.Color.Silver;
            this.btnFabrica.Location = new System.Drawing.Point(524, 181);
            this.btnFabrica.Name = "btnFabrica";
            this.btnFabrica.Size = new System.Drawing.Size(100, 39);
            this.btnFabrica.TabIndex = 51;
            this.btnFabrica.Text = "Fabrica";
            this.btnFabrica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFabrica.UseVisualStyleBackColor = false;
            this.btnFabrica.Click += new System.EventHandler(this.btnFabrica_Click);
            // 
            // cmbFiltrarMes
            // 
            this.cmbFiltrarMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarMes.FormattingEnabled = true;
            this.cmbFiltrarMes.Location = new System.Drawing.Point(6, 49);
            this.cmbFiltrarMes.Name = "cmbFiltrarMes";
            this.cmbFiltrarMes.Size = new System.Drawing.Size(143, 23);
            this.cmbFiltrarMes.TabIndex = 52;
            this.cmbFiltrarMes.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarMes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(508, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(630, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "* Son datos actuales, no se filtran";
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1018, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltrarMes);
            this.Controls.Add(this.btnFabrica);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnEnvases);
            this.Controls.Add(this.rtbAnalisis);
            this.Controls.Add(this.dgvMeses);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvMeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn crecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje;
        private System.Windows.Forms.RichTextBox rtbAnalisis;
        private System.Windows.Forms.Button btnEnvases;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnFabrica;
        private System.Windows.Forms.ComboBox cmbFiltrarMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}