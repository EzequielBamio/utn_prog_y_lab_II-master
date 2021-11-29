
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblComprado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProductoGaseosa = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProductoCervezas = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEnvaseBotella = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEnvaseLata = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEstadoAldia = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblEstadoDeudores = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDineroRecaudado = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockGaseosa = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStockCervezas = new System.Windows.Forms.Label();
            this.pgbLunes = new System.Windows.Forms.ProgressBar();
            this.pgbMartes = new System.Windows.Forms.ProgressBar();
            this.pgbMiercoles = new System.Windows.Forms.ProgressBar();
            this.pgbJueves = new System.Windows.Forms.ProgressBar();
            this.pgbViernes = new System.Windows.Forms.ProgressBar();
            this.pgbSabado = new System.Windows.Forms.ProgressBar();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblLunes = new System.Windows.Forms.Label();
            this.lblMartes = new System.Windows.Forms.Label();
            this.lblMiercoles = new System.Windows.Forms.Label();
            this.lblJueves = new System.Windows.Forms.Label();
            this.lblViernes = new System.Windows.Forms.Label();
            this.lblSabado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblMasculino = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblFemenino = new System.Windows.Forms.Label();
            this.cdoFiltrar = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDineroCaja = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
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
            // lblComprado
            // 
            this.lblComprado.AutoSize = true;
            this.lblComprado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComprado.ForeColor = System.Drawing.Color.White;
            this.lblComprado.Location = new System.Drawing.Point(12, 197);
            this.lblComprado.Name = "lblComprado";
            this.lblComprado.Size = new System.Drawing.Size(124, 15);
            this.lblComprado.TabIndex = 2;
            this.lblComprado.Text = "Dia con mayor ventas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblProductoGaseosa);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblProductoCervezas);
            this.panel2.Location = new System.Drawing.Point(15, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 72);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(120, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cervezas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gaseosas";
            // 
            // lblProductoGaseosa
            // 
            this.lblProductoGaseosa.AutoSize = true;
            this.lblProductoGaseosa.BackColor = System.Drawing.Color.Transparent;
            this.lblProductoGaseosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductoGaseosa.ForeColor = System.Drawing.Color.White;
            this.lblProductoGaseosa.Location = new System.Drawing.Point(23, 40);
            this.lblProductoGaseosa.Name = "lblProductoGaseosa";
            this.lblProductoGaseosa.Size = new System.Drawing.Size(32, 20);
            this.lblProductoGaseosa.TabIndex = 3;
            this.lblProductoGaseosa.Text = "0%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tipo de Producto mas vendido";
            // 
            // lblProductoCervezas
            // 
            this.lblProductoCervezas.AutoSize = true;
            this.lblProductoCervezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductoCervezas.ForeColor = System.Drawing.Color.White;
            this.lblProductoCervezas.Location = new System.Drawing.Point(140, 40);
            this.lblProductoCervezas.Name = "lblProductoCervezas";
            this.lblProductoCervezas.Size = new System.Drawing.Size(32, 20);
            this.lblProductoCervezas.TabIndex = 0;
            this.lblProductoCervezas.Text = "0%";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblEnvaseBotella);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lblEnvaseLata);
            this.panel4.Location = new System.Drawing.Point(219, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 72);
            this.panel4.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(134, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Lata";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Botella";
            // 
            // lblEnvaseBotella
            // 
            this.lblEnvaseBotella.AutoSize = true;
            this.lblEnvaseBotella.BackColor = System.Drawing.Color.Transparent;
            this.lblEnvaseBotella.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnvaseBotella.ForeColor = System.Drawing.Color.White;
            this.lblEnvaseBotella.Location = new System.Drawing.Point(23, 40);
            this.lblEnvaseBotella.Name = "lblEnvaseBotella";
            this.lblEnvaseBotella.Size = new System.Drawing.Size(32, 20);
            this.lblEnvaseBotella.TabIndex = 3;
            this.lblEnvaseBotella.Text = "0%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tipo de Envase mas vendido";
            // 
            // lblEnvaseLata
            // 
            this.lblEnvaseLata.AutoSize = true;
            this.lblEnvaseLata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnvaseLata.ForeColor = System.Drawing.Color.White;
            this.lblEnvaseLata.Location = new System.Drawing.Point(140, 40);
            this.lblEnvaseLata.Name = "lblEnvaseLata";
            this.lblEnvaseLata.Size = new System.Drawing.Size(32, 20);
            this.lblEnvaseLata.TabIndex = 0;
            this.lblEnvaseLata.Text = "0%";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.lblEstadoAldia);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.lblEstadoDeudores);
            this.panel5.Location = new System.Drawing.Point(420, 416);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(198, 72);
            this.panel5.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(122, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Deudores";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(14, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 4;
            this.label18.Text = "Al dia";
            // 
            // lblEstadoAldia
            // 
            this.lblEstadoAldia.AutoSize = true;
            this.lblEstadoAldia.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoAldia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoAldia.ForeColor = System.Drawing.Color.White;
            this.lblEstadoAldia.Location = new System.Drawing.Point(23, 40);
            this.lblEstadoAldia.Name = "lblEstadoAldia";
            this.lblEstadoAldia.Size = new System.Drawing.Size(32, 20);
            this.lblEstadoAldia.TabIndex = 3;
            this.lblEstadoAldia.Text = "0%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(71, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 15);
            this.label20.TabIndex = 2;
            this.label20.Text = "Estado";
            // 
            // lblEstadoDeudores
            // 
            this.lblEstadoDeudores.AutoSize = true;
            this.lblEstadoDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoDeudores.ForeColor = System.Drawing.Color.White;
            this.lblEstadoDeudores.Location = new System.Drawing.Point(143, 40);
            this.lblEstadoDeudores.Name = "lblEstadoDeudores";
            this.lblEstadoDeudores.Size = new System.Drawing.Size(32, 20);
            this.lblEstadoDeudores.TabIndex = 0;
            this.lblEstadoDeudores.Text = "0%";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lblDineroRecaudado);
            this.panel6.Location = new System.Drawing.Point(420, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 72);
            this.panel6.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dinero de las ventas";
            // 
            // lblDineroRecaudado
            // 
            this.lblDineroRecaudado.AutoSize = true;
            this.lblDineroRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDineroRecaudado.ForeColor = System.Drawing.Color.White;
            this.lblDineroRecaudado.Location = new System.Drawing.Point(38, 25);
            this.lblDineroRecaudado.Name = "lblDineroRecaudado";
            this.lblDineroRecaudado.Size = new System.Drawing.Size(27, 20);
            this.lblDineroRecaudado.TabIndex = 0;
            this.lblDineroRecaudado.Text = "$0";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente,
            this.cProductos,
            this.dinero});
            this.dgvClientes.Location = new System.Drawing.Point(348, 212);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(472, 177);
            this.dgvClientes.TabIndex = 4;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // cProductos
            // 
            this.cProductos.HeaderText = "Cantidad de Productos";
            this.cProductos.Name = "cProductos";
            this.cProductos.ReadOnly = true;
            // 
            // dinero
            // 
            this.dinero.HeaderText = "Dinero Total";
            this.dinero.Name = "dinero";
            this.dinero.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblStockGaseosa);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblStockCervezas);
            this.panel3.Location = new System.Drawing.Point(15, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 72);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cervezas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gaseosas";
            // 
            // lblStockGaseosa
            // 
            this.lblStockGaseosa.AutoSize = true;
            this.lblStockGaseosa.BackColor = System.Drawing.Color.Transparent;
            this.lblStockGaseosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStockGaseosa.ForeColor = System.Drawing.Color.White;
            this.lblStockGaseosa.Location = new System.Drawing.Point(23, 40);
            this.lblStockGaseosa.Name = "lblStockGaseosa";
            this.lblStockGaseosa.Size = new System.Drawing.Size(18, 20);
            this.lblStockGaseosa.TabIndex = 3;
            this.lblStockGaseosa.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(38, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Producto en stock";
            // 
            // lblStockCervezas
            // 
            this.lblStockCervezas.AutoSize = true;
            this.lblStockCervezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStockCervezas.ForeColor = System.Drawing.Color.White;
            this.lblStockCervezas.Location = new System.Drawing.Point(140, 40);
            this.lblStockCervezas.Name = "lblStockCervezas";
            this.lblStockCervezas.Size = new System.Drawing.Size(18, 20);
            this.lblStockCervezas.TabIndex = 0;
            this.lblStockCervezas.Text = "0";
            // 
            // pgbLunes
            // 
            this.pgbLunes.Location = new System.Drawing.Point(100, 220);
            this.pgbLunes.Name = "pgbLunes";
            this.pgbLunes.Size = new System.Drawing.Size(180, 23);
            this.pgbLunes.TabIndex = 19;
            // 
            // pgbMartes
            // 
            this.pgbMartes.Location = new System.Drawing.Point(100, 249);
            this.pgbMartes.Name = "pgbMartes";
            this.pgbMartes.Size = new System.Drawing.Size(180, 23);
            this.pgbMartes.TabIndex = 20;
            // 
            // pgbMiercoles
            // 
            this.pgbMiercoles.Location = new System.Drawing.Point(100, 278);
            this.pgbMiercoles.Name = "pgbMiercoles";
            this.pgbMiercoles.Size = new System.Drawing.Size(180, 23);
            this.pgbMiercoles.TabIndex = 21;
            // 
            // pgbJueves
            // 
            this.pgbJueves.Location = new System.Drawing.Point(100, 307);
            this.pgbJueves.Name = "pgbJueves";
            this.pgbJueves.Size = new System.Drawing.Size(180, 23);
            this.pgbJueves.TabIndex = 22;
            // 
            // pgbViernes
            // 
            this.pgbViernes.Location = new System.Drawing.Point(100, 336);
            this.pgbViernes.Name = "pgbViernes";
            this.pgbViernes.Size = new System.Drawing.Size(180, 23);
            this.pgbViernes.TabIndex = 23;
            // 
            // pgbSabado
            // 
            this.pgbSabado.Location = new System.Drawing.Point(100, 365);
            this.pgbSabado.Name = "pgbSabado";
            this.pgbSabado.Size = new System.Drawing.Size(180, 23);
            this.pgbSabado.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(12, 221);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "Lunes";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(12, 250);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 20);
            this.label24.TabIndex = 25;
            this.label24.Text = "Martes";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(12, 279);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 20);
            this.label25.TabIndex = 26;
            this.label25.Text = "Miercoles";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(12, 366);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 20);
            this.label26.TabIndex = 27;
            this.label26.Text = "Sabado";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(12, 308);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 20);
            this.label27.TabIndex = 28;
            this.label27.Text = "Jueves";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(12, 337);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 20);
            this.label28.TabIndex = 29;
            this.label28.Text = "Viernes";
            // 
            // lblLunes
            // 
            this.lblLunes.AutoSize = true;
            this.lblLunes.BackColor = System.Drawing.Color.Transparent;
            this.lblLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLunes.ForeColor = System.Drawing.Color.White;
            this.lblLunes.Location = new System.Drawing.Point(286, 221);
            this.lblLunes.Name = "lblLunes";
            this.lblLunes.Size = new System.Drawing.Size(32, 20);
            this.lblLunes.TabIndex = 6;
            this.lblLunes.Text = "0%";
            // 
            // lblMartes
            // 
            this.lblMartes.AutoSize = true;
            this.lblMartes.BackColor = System.Drawing.Color.Transparent;
            this.lblMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMartes.ForeColor = System.Drawing.Color.White;
            this.lblMartes.Location = new System.Drawing.Point(286, 249);
            this.lblMartes.Name = "lblMartes";
            this.lblMartes.Size = new System.Drawing.Size(32, 20);
            this.lblMartes.TabIndex = 30;
            this.lblMartes.Text = "0%";
            // 
            // lblMiercoles
            // 
            this.lblMiercoles.AutoSize = true;
            this.lblMiercoles.BackColor = System.Drawing.Color.Transparent;
            this.lblMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMiercoles.ForeColor = System.Drawing.Color.White;
            this.lblMiercoles.Location = new System.Drawing.Point(286, 278);
            this.lblMiercoles.Name = "lblMiercoles";
            this.lblMiercoles.Size = new System.Drawing.Size(32, 20);
            this.lblMiercoles.TabIndex = 31;
            this.lblMiercoles.Text = "0%";
            // 
            // lblJueves
            // 
            this.lblJueves.AutoSize = true;
            this.lblJueves.BackColor = System.Drawing.Color.Transparent;
            this.lblJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJueves.ForeColor = System.Drawing.Color.White;
            this.lblJueves.Location = new System.Drawing.Point(286, 307);
            this.lblJueves.Name = "lblJueves";
            this.lblJueves.Size = new System.Drawing.Size(32, 20);
            this.lblJueves.TabIndex = 32;
            this.lblJueves.Text = "0%";
            // 
            // lblViernes
            // 
            this.lblViernes.AutoSize = true;
            this.lblViernes.BackColor = System.Drawing.Color.Transparent;
            this.lblViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViernes.ForeColor = System.Drawing.Color.White;
            this.lblViernes.Location = new System.Drawing.Point(286, 336);
            this.lblViernes.Name = "lblViernes";
            this.lblViernes.Size = new System.Drawing.Size(32, 20);
            this.lblViernes.TabIndex = 33;
            this.lblViernes.Text = "0%";
            // 
            // lblSabado
            // 
            this.lblSabado.AutoSize = true;
            this.lblSabado.BackColor = System.Drawing.Color.Transparent;
            this.lblSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSabado.ForeColor = System.Drawing.Color.White;
            this.lblSabado.Location = new System.Drawing.Point(286, 365);
            this.lblSabado.Name = "lblSabado";
            this.lblSabado.Size = new System.Drawing.Size(32, 20);
            this.lblSabado.TabIndex = 34;
            this.lblSabado.Text = "0%";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.lblMasculino);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.lblFemenino);
            this.panel1.Location = new System.Drawing.Point(219, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 72);
            this.panel1.TabIndex = 8;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(126, 25);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(52, 15);
            this.label35.TabIndex = 5;
            this.label35.Text = "Mujeres";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(6, 25);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(58, 15);
            this.label36.TabIndex = 4;
            this.label36.Text = "Hombres";
            // 
            // lblMasculino
            // 
            this.lblMasculino.AutoSize = true;
            this.lblMasculino.BackColor = System.Drawing.Color.Transparent;
            this.lblMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMasculino.ForeColor = System.Drawing.Color.White;
            this.lblMasculino.Location = new System.Drawing.Point(23, 40);
            this.lblMasculino.Name = "lblMasculino";
            this.lblMasculino.Size = new System.Drawing.Size(32, 20);
            this.lblMasculino.TabIndex = 3;
            this.lblMasculino.Text = "0%";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(65, 3);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(51, 15);
            this.label38.TabIndex = 2;
            this.label38.Text = "Clientes";
            // 
            // lblFemenino
            // 
            this.lblFemenino.AutoSize = true;
            this.lblFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFemenino.ForeColor = System.Drawing.Color.White;
            this.lblFemenino.Location = new System.Drawing.Point(143, 40);
            this.lblFemenino.Name = "lblFemenino";
            this.lblFemenino.Size = new System.Drawing.Size(32, 20);
            this.lblFemenino.TabIndex = 0;
            this.lblFemenino.Text = "0%";
            // 
            // cdoFiltrar
            // 
            this.cdoFiltrar.Location = new System.Drawing.Point(628, 18);
            this.cdoFiltrar.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.cdoFiltrar.Name = "cdoFiltrar";
            this.cdoFiltrar.TabIndex = 36;
            this.cdoFiltrar.MouseCaptureChanged += new System.EventHandler(this.cdoFiltrar_MouseCaptureChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Actual";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.lblDineroCaja);
            this.panel7.Location = new System.Drawing.Point(624, 416);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(196, 72);
            this.panel7.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dinero total de la fabrica";
            // 
            // lblDineroCaja
            // 
            this.lblDineroCaja.AutoSize = true;
            this.lblDineroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDineroCaja.ForeColor = System.Drawing.Color.White;
            this.lblDineroCaja.Location = new System.Drawing.Point(41, 22);
            this.lblDineroCaja.Name = "lblDineroCaja";
            this.lblDineroCaja.Size = new System.Drawing.Size(27, 20);
            this.lblDineroCaja.TabIndex = 0;
            this.lblDineroCaja.Text = "$0";
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(838, 528);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cdoFiltrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblComprado);
            this.Controls.Add(this.lblSabado);
            this.Controls.Add(this.lblViernes);
            this.Controls.Add(this.lblJueves);
            this.Controls.Add(this.lblMiercoles);
            this.Controls.Add(this.lblMartes);
            this.Controls.Add(this.lblLunes);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pgbSabado);
            this.Controls.Add(this.pgbViernes);
            this.Controls.Add(this.pgbJueves);
            this.Controls.Add(this.pgbMiercoles);
            this.Controls.Add(this.pgbMartes);
            this.Controls.Add(this.pgbLunes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEstadisticas";
            this.Text = "FrmEstadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblComprado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProductoGaseosa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProductoCervezas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEnvaseBotella;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEnvaseLata;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEstadoAldia;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblEstadoDeudores;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDineroRecaudado;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStockGaseosa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStockCervezas;
        private System.Windows.Forms.ProgressBar pgbLunes;
        private System.Windows.Forms.ProgressBar pgbMartes;
        private System.Windows.Forms.ProgressBar pgbMiercoles;
        private System.Windows.Forms.ProgressBar pgbJueves;
        private System.Windows.Forms.ProgressBar pgbViernes;
        private System.Windows.Forms.ProgressBar pgbSabado;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblLunes;
        private System.Windows.Forms.Label lblMartes;
        private System.Windows.Forms.Label lblMiercoles;
        private System.Windows.Forms.Label lblJueves;
        private System.Windows.Forms.Label lblViernes;
        private System.Windows.Forms.Label lblSabado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblMasculino;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblFemenino;
        private System.Windows.Forms.MonthCalendar cdoFiltrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinero;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDineroCaja;
    }
}