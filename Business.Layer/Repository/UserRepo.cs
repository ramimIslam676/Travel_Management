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

        public DataTable GetAllUsers()
        {
            DataTable dataTable;
            var sql = "SELECT * FROM Users";
            var cmd = dataAccess.GetCommand(sql);
            dataTable = dataAccess.Execute(cmd);
            return dataTable;
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

        public bool UpdateUser(Users u)
        {
            var sql = @"UPDATE Users SET user_name = @name, user_email = @email, 
                        user_pass = @pass, user_phn = @phn, user_address = @addr, 
                        user_type = @type WHERE user_id = @id";
            var cmd = dataAccess.GetCommand(sql);
            cmd.Parameters.AddWithValue("@name", u.UserName);
            cmd.Parameters.AddWithValue("@email", u.UserEmail);
            cmd.Parameters.AddWithValue("@pass", u.UserPass);
            cmd.Parameters.AddWithValue("@phn", u.UserPhone);
            cmd.Parameters.AddWithValue("@addr", u.UserAddress);
            cmd.Parameters.AddWithValue("@type", ((UserTypeEnum)u.UserType).ToString());
            cmd.Parameters.AddWithValue("@id", u.UserId);
            int rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected > 0;
        }
    }
}
