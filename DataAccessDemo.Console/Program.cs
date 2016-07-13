using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Dapper;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataAccessDemo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var readContacts = new List<Contact>();

            #region "ADO.NET"

            //using (
            //    var dbConnection =
            //        new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString))
            //{
            //    var dbCommand = new SqlCommand("select Id, FirstName, LastName, Email, Phone from dbo.Contact", dbConnection);
            //    dbConnection.Open();
            //    SqlDataReader myDataReader = dbCommand.ExecuteReader();

            //    while (myDataReader.Read())
            //    {
            //        //entity mapping
            //        var readContact = new Contact
            //        {
            //            FirstName = myDataReader["FirstName"].ToString(),
            //            LastName = myDataReader["LastName"].ToString(),
            //            Email = myDataReader["Email"].ToString(),
            //            Phone = myDataReader["Phone"].ToString()
            //        };

            //        readContacts.Add(readContact);
            //    }

            //}
            #endregion

            #region "Dapper"

            //using (var dbConnection =
            //    new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString))
            //{
            //    dbConnection.Open();

            //    IEnumerable<Contact> readDapperContacts = dbConnection.Query<Contact>("select Id, FirstName, LastName, Email, Phone from dbo.Contact",
            //            null, null, false, null, CommandType.Text);

            //    readContacts = readDapperContacts.ToList();
            //}

            #endregion

            #region "Entity Framework"

            readContacts = new ContactEdm().Contacts.ToList();

            #endregion


            foreach (Contact currentContact in readContacts)
            {
                currentContact.Output();
            }

            System.Console.ReadLine();

        }
    }
}
