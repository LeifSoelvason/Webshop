using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MyLibrary
{
    public class Address
    {
        
        public int AddressID { get; set; }

        public string Streetname { get; set; }

        public int Streetnumber { get; set; }

        public int Postalcode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }   

        public int CustomerID { get; set; }



        //CRUD


        //CREATE

        public List<Address> New_Address(string Streetname, int Streetnumber, int Postalcode, string City, string Country, int CustomerID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Address>("dbo.spAddress_Add @Streetname,@Streetnumber,@Postalcode,@City,@Country,@CustomerID", new { Streetname = Streetname, Streetnumber = Streetnumber, Postalcode = Postalcode, City = City, Country = Country, CustomerID = CustomerID}).ToList();
                return output;
            }
        }



        //READ

        public List<Address> GetAddressList()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Address>("dbo.sp_GetAddressList").ToList();
                return output;
            }
        }


        public List<Address> GetAddressByCustomerID(int CustomerID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Address>("dbo.spAddress_GetByCustomerID @CustomerID", new { CustomerID = CustomerID }).ToList();
                return output;
            }
        }



        //Update

        public List<Address> Update(string Streetname, int Streetnumber, int Postalcode, string City, string Country, int CustomerID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Address>("dbo.spAddress_Update @Streetname,@Streetnumber,@Postalcode,@City,@Country,@CustomerID", new { Streetname = Streetname, Streetnumber = Streetnumber, Postalcode = Postalcode, City = City, Country = Country, CustomerID = CustomerID }).ToList();
                return output;
            }
        }



        //Delete

        public List<Address> Delete(int AddressID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Address>("dbo.spAccount_Delete @AccountID", new { AddressID = AddressID }).ToList();
                return output;
            }
        }
    }
}
