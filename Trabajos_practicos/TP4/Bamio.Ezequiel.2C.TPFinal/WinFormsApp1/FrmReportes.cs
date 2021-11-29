using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD;
namespace VistaForm
{
    public partial class FrmReportes : Form
    {
        private GestorBaseDeDatos gestorBD;
        public FrmReportes()
        {
            InitializeComponent();
            gestorBD = new GestorBaseDeDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Lee los todos los reportes de la base de datos y los muestra en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reportes_Load(object sender, EventArgs e)
        {
            try 
            { 
            dgvReportes.DataSource = gestorBD.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Al hacer doble clic se elimina el reporte en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReportes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int id;

            if (i != -1)
            {
                try
                {
                    id = (int)dgvReportes.Rows[i].Cells[5].Value;

                    if (MessageBox.Show("Seguro desea eliminar este reporte?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
                    {
                        try
                        {
                            gestorBD.Borrar(id);
                            dgvReportes.DataSource = gestorBD.Leer();
                            MessageBox.Show("El reporte se elimino correctamente!", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
