using Data.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Repository
{
    public class PaymentRepo
    {
        MySqlDataAccess dataAccess;
        public PaymentRepo()
        {
            dataAccess = new MySqlDataAccess();
        }

        public DataTable GetAllPayments()
        {
            DataTable dataTable;
            var sql = "SELECT * FROM Payment";
            var cmd = dataAccess.GetCommand(sql);
            dataTable = dataAccess.Execute(cmd);
            return dataTable;
        }
    }
}
