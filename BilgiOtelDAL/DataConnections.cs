using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;

namespace BilgiOtelDAL
{
    public static class DataConnections
    {
        //private static string ConnectionString = ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString;

        public static string Get_MsSQLConnectionString
        {
            //get { return "Server=.;Database=MyBilgiHotel;Trusted_Connection=True"; }
            get { return "Server=104.214.220.187;Database=MyBilgiHotel;User Id=MFener;Password=Bilgiotel1234.;"; }
        }
        
        /*public static string Set_MsSQLConnectionString
        {
            set
            {
                try
                {
                    var test = new SqlConnection(value);
                    test.Open();
                    test.Close();

                    ConnectionString = value;
                }
                catch
                {
                    throw new Exception("Kaydedilmek İstenen Sunucuya Bağlanılamadı!");
                }
            }
        }*/
    }
}
