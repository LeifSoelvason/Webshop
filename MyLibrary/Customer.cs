using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MyLibrary
{
    public class Customer
{
        
        public string Firstname { get; set; }

        public string Lastname { get; set; }


        public DateTime Date { get; set; }



        //CRUD


        //CREATE

        public List<Customer>New_Customer(string Firstname, string Lastname, string Username, string Password )
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Customer>("dbo.spCustomer_Add @Firstname, @Lastname, @Username, @Password ", new { Firstname = Firstname, Lastname = Lastname, Username = Username, Password = Password }).ToList();
                return output;
            }
        }


        //READ

        public List<Customer> GetCustomerList()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Customer>("dbo.sp_GetCustomerList").ToList();
                return output;
            }
        }

        public List<Customer> GetCustomerByLastname(string Lastname)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Customer>("dbo.spCustomer_GetByLastname @Lastname", new { Lastname = Lastname }).ToList();
                return output;
            }
        }

        //Update

        public List<Customer> Update(int CustomerID, string Firstname, string Lastname, string Username, string Password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Customer>("dbo.spCustomer_Update @CustomerID,@Firstname,@Lastname,@Username,@Password", new { CustomerID = CustomerID, Firstname = Firstname, Lastname = Lastname, Username = Username, Password = Password }).ToList();
                return output;
            }
        }

        //Delete

        public List<Customer> Delete(int CustomerID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Customer>("dbo.spCustomer_Delete @CustomerID", new { CustomerID = CustomerID }).ToList();
                return output;
            }
        }

    }
}