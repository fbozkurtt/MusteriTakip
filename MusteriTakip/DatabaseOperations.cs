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
        public static DataSet GetAllCustomers()
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
        public static Customer GetCustomerById(int id)
        {
            SQLiteDataAdapter da;
            DataSet ds;
            var cmd = new SQLiteCommand("Select Id, Name, Company, Notes, DateCreated From Customer where Id = @Id", con);
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            da = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Customer");
            var customer123 = ds.Tables[0].Rows[0];
            var customer = new Customer()
            {
                Id = id,
                Name = ds.Tables[0].Rows[0].ItemArray[1].ToString(),
                Company = ds.Tables[0].Rows[0].ItemArray[2].ToString(),
                Notes = ds.Tables[0].Rows[0].ItemArray[3].ToString(),
                DateCreated = ds.Tables[0].Rows[0].ItemArray[4].ToString(),
            };
            con.Close();
            return customer;
        }
        public static DataSet GetCustomersByName(string name)
        {
            SQLiteDataAdapter da;
            DataSet ds;
            name = name + "%";
            name = "%" + name;
            var cmd = new SQLiteCommand("Select Id, Name, Company, Notes From Customer where Name like @Name", con);
            cmd.Parameters.Add("@Name", DbType.String, name.Length).Value = name.ToUpper(new CultureInfo("tr-TR"));
            da = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Customer");
            con.Close();
            return ds;
        }
        public static void AddCustomer(string name, string company = "")
        {
            var dateCrated = DateTime.Now.ToString("dd.MM.yyyy HH:mm", new CultureInfo("tr-TR"));
            var cmd = new SQLiteCommand("INSERT INTO Customer (Name, Company, DateCreated) VALUES(@Name, @Company, @DateCreated); ", con);
            cmd.Parameters.Add("@Name", DbType.String, name.Length).Value = name.ToUpper(new CultureInfo("tr-TR"));
            cmd.Parameters.Add("@Company", DbType.String, company.Length).Value = company.ToUpper(new CultureInfo("tr-TR"));
            cmd.Parameters.Add("@DateCreated", DbType.String, dateCrated.Length).Value = dateCrated;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdateCustomerName(int id, string param)
        {
            var cmd = new SQLiteCommand("UPDATE Customer SET Name = @Param WHERE ID = @Id;", con);
            cmd.Parameters.Add("@Param", DbType.String, param.Length).Value = param.ToUpper(new CultureInfo("tr-TR"));
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdateCustomerCompany(int id, string param)
        {
            var cmd = new SQLiteCommand("UPDATE Customer SET Company = @Param WHERE ID = @Id;", con);
            cmd.Parameters.Add("@Param", DbType.String, param.Length).Value = param.ToUpper(new CultureInfo("tr-TR"));
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
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
    }
}
