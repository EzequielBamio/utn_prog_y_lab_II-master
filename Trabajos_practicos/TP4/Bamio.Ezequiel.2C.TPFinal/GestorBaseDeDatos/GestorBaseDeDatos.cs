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

                    string command = "DELETE FROM Reportes where id = @id";

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
                    string command = "INSERT INTO Reportes(id, totalPedidos, totalPagos, totalNoPagos, recaudado, fecha) VALUES (@id, @totalPedidos, @totalPagos, @totalNoPagos, @recaudado, @fecha)";

                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("id", reporte.Id);
                    sqlCommand.Parameters.AddWithValue("totalPedidos", reporte.TotalPedidos);
                    sqlCommand.Parameters.AddWithValue("totalPagos", reporte.TotalPagos);
                    sqlCommand.Parameters.AddWithValue("totalNoPagos", reporte.TotalNoPagos);
                    sqlCommand.Parameters.AddWithValue("recaudado", reporte.Reacudado);
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
                        int id = int.Parse(reader["id"].ToString());
                        int totalPedidos = int.Parse(reader["totalPedidos"].ToString());
                        int totalPagos = int.Parse(reader["totalPagos"].ToString());
                        int totalNoPagos = int.Parse(reader["totalNoPagos"].ToString());
                        int recaudado = int.Parse(reader["recaudado"].ToString());
                        string fecha = reader["fecha"].ToString();

                        Reporte reporte = new Reporte(totalPedidos, totalPagos, totalNoPagos, recaudado, fecha);
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

                    string command = "SELECT * FROM Reportes where id = @id";

                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("id", id);

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    Reporte reporte = null;
                    while (reader.Read())
                    {
                        int totalPedidos = int.Parse(reader["totalPedidos"].ToString());
                        int totalPagos = int.Parse(reader["totalPagos"].ToString());
                        int totalNoPagos = int.Parse(reader["totalNoPagos"].ToString());
                        int recaudado = int.Parse(reader["recaudado"].ToString());
                        string fecha = reader["fecha"].ToString();


                        reporte = new Reporte(totalPedidos, totalPagos, totalNoPagos, recaudado, fecha);
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
