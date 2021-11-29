using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDB
    {
        private SqlConnection slqConnection;
        private SqlCommand sqlCommand;
        private string connectionString;

        public PersonaDB() 
        {
            this.connectionString = "Data Sourcer = .\\SQLEXPRESS; Initial Catalog = Persona; Integrated Security = True";
            this.slqConnection = new SqlConnection();
        }

        public void 
    }
}
