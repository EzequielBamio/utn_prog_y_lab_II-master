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
    public partial class Form1 : Form
    {
        private PersonaDAO DAO;
        private List<Persona> listaPersonas;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            lblEstado.Text = "";
            this.DAO = new PersonaDAO();
            this.listaPersonas = new List<Persona>();
            this.listaPersonas = DAO.Leer();
            foreach (Persona item in this.listaPersonas) 
            {
                lstPersonas.Items.Add($"{item.Apellido} {item.Nombre}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona persona = this.listaPersonas[lstPersonas.SelectedIndex];

            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;

            lblEstado.Text = this.DAO.Modificar(persona, persona.Id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(txtNombre.Text, txtApellido.Text);
            lblEstado.Text = this.DAO.Guardar(persona);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona persona = this.listaPersonas[lstPersonas.SelectedIndex];

            lblEstado.Text = DAO.Borrar(persona.Id);
        }
    }
}
