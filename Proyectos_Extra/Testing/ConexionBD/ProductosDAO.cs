using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace ConexionBD
{
    public class ProductosDAO
    {
        private SqlConnection sqlConnection;
        private string connectionString;

        public ProductosDAO()
        {
            this.connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog =ProductosDB; Integrated Security = True";
            this.sqlConnection = new SqlConnection(this.connectionString);
        }

        public void InsertarProducto(Producto producto)
        {
            try
            {
                string command = "INSERT INTO Productos(codigo, nombre, precio, descripcion)" + "VALUES(@codigo, @nombre, @precio, @descripcion)";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("descripcion", producto.Descripcion);


                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open) 
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public void EditarProducto(Producto producto, int id)
        {
            try
            {
                string command = "UPDATE Productos SET nombre = @nombre, codigo = @codigo, precio = @precio, descripcion = @descripcion where id = @id";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("descripcion", producto.Descripcion);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public void EliminarProducto(int id)
        {
            try
            {
                string command = "Delete from Productos where id = @id";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);


                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public List<Producto> ListarProductos() 
        {
            using (SqlConnection sqlConnectionLocal = new SqlConnection(this.connectionString)) 
            {
                string command = "Select * from Productos";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnectionLocal);
                sqlConnectionLocal.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter();
               
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<Producto> productos = new List<Producto>();
                while (reader.Read()) 
                {
                    int id = (int)reader["id"];
                    
                    productos.Add(ListarProducto(id));
                }

                return productos;
                
            }
        }
        public Producto ListarProducto(int id)
        {
            using (SqlConnection sqlConnectionLocal = new SqlConnection(this.connectionString))
            {
                string command = "Select * from Productos where id = @id";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnectionLocal);

                sqlCommand.Parameters.AddWithValue("id", id);
                sqlConnectionLocal.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                Producto producto = null;
                while (reader.Read())
                {
                    int idProducto = (int)reader["id"];
                    float precio = (float)Convert.ToDouble(reader["precio"]);
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigo"];
                    string descripcion = null;
                    if (reader["descripcion"] != DBNull.Value)
                    {
                        descripcion = (string)reader["descripcion"];
                    }

                    producto = new Producto(idProducto, nombre, descripcion, codigo, precio);
                }

                return producto;

            }
        }

    }
}
