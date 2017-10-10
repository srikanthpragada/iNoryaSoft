using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo.ef
{

    class CallStoredProc
    {
        static void Main(string[] args)
        {
            using (HRContext ctx = new HRContext())
            {
                ctx.Database.Log = Console.WriteLine;

                SqlParameter hs = new SqlParameter("@highest",  SqlDbType.Int);
                hs.Direction = ParameterDirection.Output;
                SqlParameter ls = new SqlParameter("@lowest", SqlDbType.Int);
                ls.Direction = ParameterDirection.Output;

                ctx.Database.ExecuteSqlCommand("SalaryRange @highest out, @lowest out", hs,ls);

                Console.WriteLine("Values : {0} {1}", hs.Value, ls.Value);




            }

        }
    }
}
