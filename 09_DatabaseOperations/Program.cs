using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.Net

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo bilgisini giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------");

            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-Q270QVE\\SQLEXPRESS;Initial Catalog=DBC#EgitimKampi;Integrated Security=true;TrustServerCertificate=true;");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * From Categories", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
               
            }
            sqlConnection.Close();

            Console.Read();
        }
    }
}
