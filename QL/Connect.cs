
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;


namespace QL
{
 
   public class Connect

    {
        private static Connect instace;

        private string connSTr = @"Data Source=HIENKMAP\SQLEXPRESS;Initial Catalog=QLBCMB;Integrated Security=True";
        public static Connect Instace
        {
            get
            {
                if (instace == null)
                    instace = new Connect();
                return Connect.instace;
            }
            private set
            {
                Connect.instace = value;

            }

        }
        public DataTable excutequery(string Query)
        {
            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(connSTr);
            conn.Open();
            SqlCommand command = new SqlCommand(Query, conn);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            conn.Close();
            return data;
    }
    }
    
}