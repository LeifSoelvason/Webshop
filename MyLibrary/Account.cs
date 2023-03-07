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
    public class Account
    {
       public int CustomerID { get; set; }

       public int AccountID { get; set; }

       public string Accountname { get; set; }

       public string Firstname { get; set; }

       public string Lastname { get; set; }

       public DateTime Date { get; set; }



        //CRUD


        //CREATE

        public List<Account> New_Account(int CustomerID, string Accountname, string Firstname, string Lastname)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Account>("dbo.spAccount_Add @CustomerID,@Accountname,@Firstname,@Lastname", new { CustomerID = CustomerID,Accountname = Accountname, Firstname = Firstname, Lastname = Lastname}).ToList();
                return output;
            }
        }

        

        //READ

        public List<Account> GetAccountList()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Account>("dbo.sp_GetAccountList").ToList();
                return output;
            }
        }

        
        public List<Account> GetAccountByLastname(string Lastname)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Account>("dbo.spAccount_GetByLastname @Lastname", new { Lastname = Lastname }).ToList();
                return output;
            }
        }

        
          
        //Update

        public List<Account> Update(int AccountID, string Accountname, string Firstname, string Lastname)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Account>("dbo.spAccount_Update @AccountID,@Accountname,@Firstname,@Lastname", new { AccountID = AccountID,Accountname = Accountname, Firstname = Firstname, Lastname = Lastname}).ToList();
                return output;
            }
        }

        
         
        //Delete

        public List<Account> Delete(int AccountID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Webshop_DB")))
            {
                var output = connection.Query<Account>("dbo.spAccount_Delete @AccountID", new { AccountID = AccountID }).ToList();
                return output;
            }
        }
       
    }
}



