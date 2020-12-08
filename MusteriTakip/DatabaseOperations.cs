using MusteriTakip.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip
{
    public static class DatabaseOperations
    {
        public static SQLiteConnection con = new SQLiteConnection("Data Source=MusteriTakipDB.db;");
        public static DataSet GetCustomers()
        {
            SQLiteDataAdapter da;
            DataSet ds;
            da = new SQLiteDataAdapter("Select Id, Name, Company, Notes From Customer", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Customer");
            con.Close();
            return ds;
        }
        public static void AddCustomer(Customer customer)
        {

            var cmd = new SQLiteCommand("INSERT INTO Customer (Name, Company) VALUES(@Name, @Company); ", con);
            cmd.Parameters.Add("@Name", DbType.String, customer.Name.Length).Value = customer.Name.ToUpper(new CultureInfo("tr-TR"));
            cmd.Parameters.Add("@Company", DbType.String, customer.Company.Length).Value = customer.Company.ToUpper(new CultureInfo("tr-TR"));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdateCustomerNotes(int id, string param)
        {
            var cmd = new SQLiteCommand("UPDATE Customer SET Notes = @Param WHERE ID = @Id;", con);
            cmd.Parameters.Add("@Param", DbType.String, param.Length).Value = param;
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdateCustomerName(int id, string param)
        {
            var cmd = new SQLiteCommand("UPDATE Customer SET Name = @Param WHERE ID = @Id;", con);
            cmd.Parameters.Add("@Param", DbType.String, param.Length).Value = param;
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdateCustomerCompany(int id, string param)
        {
            var cmd = new SQLiteCommand("UPDATE Customer SET Company = @Param WHERE ID = @Id;", con);
            cmd.Parameters.Add("@Param", DbType.String, param.Length).Value = param;
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
