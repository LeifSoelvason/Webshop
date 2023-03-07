using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MyLibrary
{
    public class Validation
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public List<Validation> PasswordValidation(string Username, string Password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Validation>("dbo.sp_ValidateCustomer @Username,@Password", new { Username = Username, Password = Password }).ToList();
                return output;
            }
        }
    }
}