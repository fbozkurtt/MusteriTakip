using MusteriTakip.Models;
using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;

namespace MusteriTakip
{
    public static class DatabaseOperations
    {
        public static SQLiteConnection con = new SQLiteConnection("Data Source=MusteriTakipDB.db;");
        static DatabaseOperations()
        {
            if (!System.IO.File.Exists("MusteriTakipDB.db"))
            {
                var cmdText = System.IO.File.ReadAllText("CreateDatabase.sql");
                SQLiteConnection.CreateFile("MusteriTakipDB.db");
                var cmd = new SQLiteCommand(cmdText, con);
                con.Open();
                cmd.ExecuteNonQuery();
                return;
            }
            con.Open();
        }
        public static DataSet GetAllCustomers()
        {
            SQLiteDataAdapter da;
            DataSet ds;
            da = new SQLiteDataAdapter("Select Id, Name, Company, Notes From Customer", con);
            ds = new DataSet();
            da.Fill(ds, "Customer");
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
            da.Fill(ds, "Customer");
            var customer = new Customer()
            {
                Id = id,
                Name = ds.Tables[0].Rows[0].ItemArray[1].ToString(),
                Company = ds.Tables[0].Rows[0].ItemArray[2].ToString(),
                Notes = ds.Tables[0].Rows[0].ItemArray[3].ToString(),
                DateCreated = ds.Tables[0].Rows[0].ItemArray[4].ToString(),
            };
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
            da.Fill(ds, "Customer");
            return ds;
        }
        public static void AddCustomer(string name, string company)
        {
            SQLiteCommand cmd;
            if (String.IsNullOrEmpty(name))
            {
                return;
            }
            var dateCrated = DateTime.Now.ToString("dd.MM.yyyy HH:mm", new CultureInfo("tr-TR"));
            cmd = new SQLiteCommand("INSERT INTO Customer (Name, Company, DateCreated) VALUES(@Name, @Company, @DateCreated); ", con);
            cmd.Parameters.Add("@Name", DbType.String, name.Length).Value = name.ToUpper(new CultureInfo("tr-TR"));
            if (String.IsNullOrEmpty(company))
            {
                cmd.Parameters.Add("@Company", DbType.String).Value = null;
            }
            else
            {
                cmd.Parameters.Add("@Company", DbType.String, company.Length).Value = company.ToUpper(new CultureInfo("tr-TR"));
            }
            cmd.Parameters.Add("@DateCreated", DbType.String, dateCrated.Length).Value = dateCrated;
            cmd.ExecuteNonQuery();
        }
        public static void DeleteCustomer(int id)
        {
            var cmd = new SQLiteCommand(@"DELETE FROM Customer WHERE Id = @Id;
DELETE FROM Operation WHERE CustomerId = @Id", con);
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }
        public static void AddOperation(string description, int customerId, double? charge)
        {
            SQLiteCommand cmd;
            var dateCrated = DateTime.Now.ToString("dd.MM.yyyy HH:mm", new CultureInfo("tr-TR"));
            cmd = new SQLiteCommand("INSERT INTO Operation (Description, Charge, CustomerId, DateCreated) VALUES(@Description, @Charge, @CustomerId, @DateCreated); ", con);
            cmd.Parameters.Add("@Description", DbType.String, description.Length).Value = description;
            if (!charge.HasValue)
            {
                cmd.Parameters.Add("@Charge", DbType.Double).Value = null;
            }
            else
            {
                cmd.Parameters.Add("@Charge", DbType.Double).Value = charge;
            }
            cmd.Parameters.Add("@CustomerId", DbType.Int32).Value = customerId;
            cmd.Parameters.Add("@DateCreated", DbType.String, dateCrated.Length).Value = dateCrated;
            cmd.ExecuteNonQuery();
        }
        public static void DeleteOperation(int id)
        {
            var cmd = new SQLiteCommand("DELETE FROM Operation WHERE Id = @Id; ", con);
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }
        public static DataSet GetAllOperationsOfCustomer(int customerId)
        {
            SQLiteDataAdapter da;
            DataSet ds;
            var cmd = new SQLiteCommand("Select Id, Description, Charge, DateCreated From Operation where CustomerId = @CustomerId", con);
            cmd.Parameters.Add("@CustomerId", DbType.Int32).Value = customerId;
            da = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Operation");
            return ds;
        }
        public static void UpdateCustomerName(int id, string param)
        {
            var cmd = new SQLiteCommand("UPDATE Customer SET Name = @Param WHERE ID = @Id;", con);
            cmd.Parameters.Add("@Param", DbType.String, param.Length).Value = param.ToUpper(new CultureInfo("tr-TR"));
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }
        public static void UpdateCustomerCompany(int id, string param)
        {
            SQLiteCommand cmd;
            if (String.IsNullOrEmpty(param))
            {
                cmd = new SQLiteCommand("UPDATE Customer SET Company = NULL WHERE ID = @Id;", con);
            }
            else
            {
                cmd = new SQLiteCommand("UPDATE Customer SET Company = @Param WHERE ID = @Id;", con);
                cmd.Parameters.Add("@Param", DbType.String, param.Length).Value = param.ToUpper(new CultureInfo("tr-TR"));
            }
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }
        public static void UpdateCustomerNotes(int id, string param)
        {
            SQLiteCommand cmd;
            if (String.IsNullOrEmpty(param))
            {
                cmd = new SQLiteCommand("UPDATE Customer SET Notes = NULL WHERE ID = @Id;", con);
            }
            else
            {
                cmd = new SQLiteCommand("UPDATE Customer SET Notes = @Param WHERE ID = @Id;", con);
                cmd.Parameters.Add("@Param", DbType.String, param.Length).Value = param;
            }
            cmd.Parameters.Add("@Id", DbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }
    }
}
