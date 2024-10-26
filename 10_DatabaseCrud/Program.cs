using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crud -> Create, Read, Update, Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-Q270QVE\\SQLEXPRESS;Initial Catalog=DBC#EgitimKampi;Integrated Security=true;TrustServerCertificate=true;");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();            
            //sqlConnection.Open();
            //SqlCommand command = new SqlCommand("Insert Into Categories (Name) Values (@p1)", sqlConnection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //sqlConnection.Close();
            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //sqlConnection.Open();
            //SqlCommand insertCommand = new SqlCommand("Insert Into Products (Name, Price, Status) Values (@productName, @productPrice, @productStatus)", sqlConnection);
            //insertCommand.Parameters.AddWithValue("@productName", productName);
            //insertCommand.Parameters.AddWithValue("@productPrice", productPrice);
            //insertCommand.Parameters.AddWithValue("@productStatus", true);
            //insertCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            //Console.WriteLine("Ürün başarıyla eklendi");

            #endregion

            #region Ürün Listeleme İşlemi

            //sqlConnection.Open();
            //SqlCommand command = new SqlCommand("Select * From Products", sqlConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //sqlConnection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //sqlConnection.Open();
            //SqlCommand command = new SqlCommand("Delete From Products Where Id = @id", sqlConnection);
            //command.Parameters.AddWithValue("@id", productId);
            //command.ExecuteNonQuery();
            //sqlConnection.Close();
            //Console.WriteLine("Ürün başarıyla silindi");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update Products Set Name = @name, Price=@price Where Id = @id", sqlConnection);
            command.Parameters.AddWithValue("@id", productId);
            command.Parameters.AddWithValue("@name", productName);
            command.Parameters.AddWithValue("@price", productPrice);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("Ürün başarıyla güncellendi");

            #endregion


            Console.Read();
        }
    }
}
