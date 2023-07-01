using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Tarea4
{
    public class Class1
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=EjemploTarea4;Integrated Security=true;");

        public bool Ok()
        {
            try
            {
                
                connection.Open();
            }catch
            {
                return false;
            }
            return true;
            }
    }

}
