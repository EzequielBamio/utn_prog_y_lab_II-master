using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;
namespace BD
{
    public class GestorBaseDeDatos : IBaseDatos<Reporte>
    {
        private string cadenaConexion;
        public GestorBaseDeDatos()
        {
            this.cadenaConexion = "Data Source = .\\SQLEXPRESS; Initial Catalog = Fabrica; Integrated Security = TRUE";
        }
        /// <summary>
        /// Borra un Reporte en la base de datos
        /// </summary>
        /// <param name="id">Id del reporte a eliminar</param>
        public void Borrar(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.cadenaConexion))
            {
                try
                {
                    sqlConnection.Open();

                    string command = "DELETE FROM Reportes where ReporteId = @id";

                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("id", id);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// Guardar un reporte a la base de datos
        /// </summary>
        /// <param name="reporte">Reporte que se va a guardar en la base de datos</param>
        public void Guardar(Reporte reporte)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.cadenaConexion))
            {
                try
                {
                    sqlConnection.Open();
                    string command = "INSERT INTO Reportes(cantidadPedidos, cantidadEntregados, cantidadNoEntregados, totalVenta, fecha) VALUES (@cantidadPedidos, @cantidadEntregados, @cantidadNoEntregados, @totalVenta, @fecha)";

                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("cantidadPedidos", reporte.CantidadPedidos);
                    sqlCommand.Parameters.AddWithValue("cantidadEntregados", reporte.CantidadEntregados);
                    sqlCommand.Parameters.AddWithValue("cantidadNoEntregados", reporte.CantidadNoEntregados);
                    sqlCommand.Parameters.AddWithValue("totalVenta", reporte.TotalVenta);
                    sqlCommand.Parameters.AddWithValue("fecha", reporte.Fecha);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// Lee todos  los reportes de la base de datos
        /// </summary>
        /// <returns>Una lista de reportes</returns>
        public List<Reporte> Leer()
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.cadenaConexion))
            {
                try
                {
                    sqlConnection.Open();

                    string command = "SELECT * FROM Reportes";

                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    List<Reporte> reportes = new List<Reporte>();
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["ReporteId"].ToString());
                        int cantidadPedidos = int.Parse(reader["cantidadPedidos"].ToString());
                        int cantidadEntregados = int.Parse(reader["cantidadEntregados"].ToString());
                        int cantidadNoEntregados = int.Parse(reader["cantidadNoEntregados"].ToString());
                        int totalVenta = int.Parse(reader["totalVenta"].ToString());
                        string fecha = reader["fecha"].ToString();

                        Reporte reporte = new Reporte(cantidadPedidos, cantidadEntregados, cantidadNoEntregados, totalVenta, fecha);
                        reporte.Id = id;
                        reportes.Add(reporte);
                    }

                    return reportes;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// Lee un reporte de la base de datos 
        /// </summary>
        /// <param name="id">Id del reporte</param>
        /// <returns>El reporte de la base de datos</returns>
        public Reporte Leer(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    sqlConnection.Open();

                    string command = "SELECT * FROM Reportes where ReporteId = @id";

                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("id", id);

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    Reporte reporte = new Reporte();
                    while (reader.Read())
                    {
                        int cantidadPedidos = int.Parse(reader["cantidadPedidos"].ToString());
                        int cantidadEntregados = int.Parse(reader["cantidadEntregados"].ToString());
                        int cantidadNoEntregados = int.Parse(reader["cantidadNoEntregados"].ToString());
                        int totalVenta = int.Parse(reader["totalVenta"].ToString());
                        string fecha = reader["fecha"].ToString();


                        reporte = new Reporte(cantidadPedidos, cantidadEntregados, cantidadNoEntregados, totalVenta, fecha);

                        reporte.Id = id;
                    }

                    return reporte;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

      
    }
}
