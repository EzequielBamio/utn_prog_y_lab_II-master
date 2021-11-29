using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class frmPpal : Form
    {
        private EjercitoImperial ejercitoImperial;

        /// <summary>
        /// Constructor Estancia el ejercitoImperial y agregar un Soldado
        /// </summary>
        public frmPpal()
        {
            InitializeComponent();
            ejercitoImperial = new EjercitoImperial(10);
            Trooper trooper = new TrooperAsalto(Blaster.EC17);

            ejercitoImperial += trooper;
        }

        /// <summary>
        /// Agrega los items al combo box de Tipo y Blasters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVista_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Arena");
            cmbTipo.Items.Add("Asalto");
            cmbTipo.Items.Add("Explorador");

            cmbBlasters.DataSource = Enum.GetValues(typeof(Blaster));

        }

        /// <summary>
        /// Agrega un soldado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Trooper trooper = null;
            trooper = this.ValidarTipo(trooper);

            if (!(trooper is null)) 
            {
                ejercitoImperial += trooper;
                this.RefrescarEjercito();
            }
        }

        /// <summary>
        /// Quita un soldado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Trooper trooper = null;
            trooper = this.ValidarTipo(trooper);

            if (!(trooper is null))
            {
                ejercitoImperial -= trooper;
                this.RefrescarEjercito();
            }

        }
        
        /// <summary>
        /// Trae el valor seleccionado del comboBox del Blaster y lo guarda en una variable
        /// Si hay algo seleccionado en el comboBox del Tipo, valida que tipo de tooper es
        /// y lo estancia.
        /// Valida el checkbox esta seleccionado 
        /// </summary>
        /// <param name="trooper"></param>
        /// <returns>Trooper con la estancia seleccionada</returns>
        private Trooper ValidarTipo(Trooper trooper) 
        {
            Blaster blaster;
            Enum.TryParse<Blaster>(cmbBlasters.SelectedValue.ToString(), out blaster);

            if (cmbTipo.SelectedItem != null)
            {
                switch (cmbTipo.SelectedItem)
                {
                    case "Arena":
                        //trooper = new TrooperArena(Blaster.EC17);
                        trooper = new TrooperArena(blaster);
                        break;
                    case "Asalto":
                        //trooper = new TrooperAsalto(Blaster.E11);
                        trooper = new TrooperAsalto(blaster);
                        break;
                    case "Explorador":
                        trooper = new TrooperExplorador("Moto");
                        break;
                }

                //Valida el CheckBox
                if (ckbEsClon.Checked)
                {
                    trooper.EsClon = true;
                }
                else
                {
                    trooper.EsClon = false;
                }
            }

            return trooper;
        }

        /// <summary>
        /// Elimina todo lo que esta en el ListBox y muestra la lista de toopers actualizada
        /// </summary>
        private void RefrescarEjercito() 
        {
            lstEjercito.Items.Clear();
            foreach (Trooper trooper in ejercitoImperial.Troopers)
            {
                lstEjercito.Items.Add(trooper.InfoTrooper());
            }
        }

        

    }
}
