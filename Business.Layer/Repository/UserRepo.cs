using Data.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Repository
{
    public class UserRepo
    {
        MySqlDataAccess dataAccess;
        public UserRepo()
        {
            dataAccess = new MySqlDataAccess();

        }

        public bool IsUserValidForLogin(string phoneNumber, string password)
        {
            DataTable dataTable;
            var sql = "SELECT * FROM Users WHERE user_phn = @PHN AND user_pass = @PW";
            var cmd = dataAccess.GetCommand(sql);
            cmd.Parameters.AddWithValue("@PHN", phoneNumber);
            cmd.Parameters.AddWithValue("@PW", password);
            dataTable = dataAccess.Execute(cmd);

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
