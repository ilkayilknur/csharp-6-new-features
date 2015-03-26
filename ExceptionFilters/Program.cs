using System.Data.SqlClient;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;");
            //Before C# 6.0
            try
            {
                conn.Open();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.ErrorCode < 999)
                {
                    throw;
                }
            }

            //After C# 6.0
            try
            {
                conn.Open();
            }
            catch (SqlException sqlEx) when (sqlEx.ErrorCode > 999)
            {

            }
        }
    }
}
