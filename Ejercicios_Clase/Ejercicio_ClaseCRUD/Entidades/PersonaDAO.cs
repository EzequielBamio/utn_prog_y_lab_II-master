using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDAO
    {
        private SqlConnection sqlConnection;
        private string connectionString;
        private SqlCommand sqlCommand;

        public PersonaDAO() 
        {
            this.connectionString = "Data Source = .\\SQLEXPRESS; Initial Catalog = Empresa; Integrated Security = TRUE";
            
        }

        public string Guardar(Persona persona) 
        {
            string rtn = string.Empty;
            using (this.sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "INSERT INTO Personas(nombre, apellido) VALUES (@nombre, @apellido)";

                this.sqlCommand = new SqlCommand(command, this.sqlConnection);
                this.sqlCommand.Parameters.AddWithValue("nombre", persona.Nombre);
                this.sqlCommand.Parameters.AddWithValue("apellido", persona.Apellido);

                this.sqlConnection.Open();
                this.sqlCommand.ExecuteNonQuery();

                rtn = "Se guardo correctamente!";
            }

            return rtn;
        }
        public string Modificar(Persona persona, int id) 
        {
            string rtn = string.Empty;

            using (this.sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "UPDATE Personas SET nombre = @nombre, apellido = @apellido where id = @id";

                this.sqlCommand = new SqlCommand(command, this.sqlConnection);
                this.sqlCommand.Parameters.AddWithValue("id", id);
                this.sqlCommand.Parameters.AddWithValue("nombre", persona.Nombre);
                this.sqlCommand.Parameters.AddWithValue("apellido", persona.Apellido);

                this.sqlConnection.Open();
                this.sqlCommand.ExecuteNonQuery();
                rtn = "Se modifico correctamente!";
            }
            return rtn;
        }
        public string Borrar(int id) 
        {
            string rtn = string.Empty;
            using (this.sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "DELETE FROM Personas where id = @id";

                this.sqlCommand = new SqlCommand(command, this.sqlConnection);
                this.sqlCommand.Parameters.AddWithValue("id", id);

                this.sqlConnection.Open();
                this.sqlCommand.ExecuteNonQuery();
                rtn = "Se borro correctamente!";
            }
            return rtn;
        }
        public List<Persona> Leer() 
        {
            using (this.sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Personas";

                this.sqlCommand = new SqlCommand(command, this.sqlConnection);

                this.sqlConnection.Open();
                SqlDataReader reader = this.sqlCommand.ExecuteReader();
                List<Persona> listaPersonas = new List<Persona>();
                while (reader.Read())
                {
                    int idPersona = int.Parse(reader["id"].ToString());
                    string nombre = reader["nombre"].ToString();
                    string apellido = reader["apellido"].ToString();


                    listaPersonas.Add(new Persona(idPersona, nombre, apellido));
                }
                return listaPersonas;
            }
        }
    
        public Persona LeerID(int id) 
        {
            using (this.sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Personas where id = @id";

                this.sqlCommand = new SqlCommand(command, this.sqlConnection);
                this.sqlCommand.Parameters.AddWithValue("id", id);
                this.sqlConnection.Open();
                SqlDataReader reader = this.sqlCommand.ExecuteReader();
                Persona persona = null;
                while (reader.Read()) 
                {
                    int idPersona = int.Parse(reader["id"].ToString());
                    string nombre = reader["nombre"].ToString();
                    string apellido = reader["apellido"].ToString();


                    persona = new Persona(idPersona, nombre, apellido);
                }
                return persona;
            }
        }
    }
}
