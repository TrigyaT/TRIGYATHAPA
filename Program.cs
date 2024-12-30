using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;// this must be imported

namespace AdoBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            display();
            update();
        }

        static void display()
        {
            string connectionString = "Data Source=TRIGYA-PC\\SQLEXPRESS;Initial Catalog=HamroStoreDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Products", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                    Console.WriteLine(sdr.GetInt32(0));
                    Console.WriteLine(sdr.GetString(1));
                    Console.WriteLine(sdr.GetString(2));
                    Console.WriteLine(sdr.GetInt32(3));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { con.Close(); }

        }
        static void insert()
        {
            string connectionString = "Data Source=TRIGYA-PC\\SQLEXPRESS;Initial Catalog=HamroStoreDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                string name, description;
                int price = 0;
                Console.WriteLine("enter product name: ");
                name = Console.ReadLine();
                Console.WriteLine("enter product description: ");
                description = Console.ReadLine();
                price = Int32.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand($"insert into Products(Name,Description,Price)values('{name}','{description}',{price})", con);
                cmd.ExecuteNonQuery();


                Console.WriteLine("inserted successfully........................");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        static void update()
        {
            string connectionString = "Data Source=TRIGYA-PC\\SQLEXPRESS;Initial Catalog=HamroStoreDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                Console.WriteLine("Enter product ID to update: ");
                int id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter new product name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter new product description: ");
                string description = Console.ReadLine();

                Console.WriteLine("Enter new product price: ");
                int price = Int32.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand($"update Products set Name='{name}', Description='{description}', Price={price} where Id={id}", con);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Updated successfully...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
