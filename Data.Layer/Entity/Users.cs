using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Entity
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string UserAddress { get; set; }
        public string UserPhone { get; set; }
        public int UserType { get; set; }
    }

    public enum UserTypeEnum
    {
        Organizer,
        Customer,
        Admin
    }
}
