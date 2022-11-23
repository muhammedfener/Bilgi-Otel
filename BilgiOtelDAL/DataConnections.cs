using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class DataConnections
    {
        public static string MsSQLConnectionString
        {
            get { return "Server=.;Database=MyBilgiHotel;Trusted_Connection=True;"; }
            set { MsSQLConnectionString = value; }
        }
    }

}
