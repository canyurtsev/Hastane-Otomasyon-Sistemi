using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public class Db
    {
        
        public static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HastaneDB;Integrated Security=True";
        
 
        private static string MasterConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";

        public static void DatabaseOlustur()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnectionString))
                {
                    con.Open();
                    string query = "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'HastaneDB') CREATE DATABASE HastaneDB";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı oluşturma hatası: " + ex.Message);
            }
        }

        public static void TablolariOlustur()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    
     
                    string queryHastalar = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Hastalar')
                    CREATE TABLE Hastalar (
                        HastaId INT IDENTITY PRIMARY KEY,
                        TCKimlik NVARCHAR(11),
                        Ad NVARCHAR(50),
                        Soyad NVARCHAR(50),
                        Telefon NVARCHAR(20),
                        Adres NVARCHAR(200),
                        DogumTarihi DATE
                    )";
                    new SqlCommand(queryHastalar, con).ExecuteNonQuery();

             
                    string queryDoktorlar = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Doktorlar')
                    CREATE TABLE Doktorlar (
                        DoktorId INT IDENTITY PRIMARY KEY,
                        Ad NVARCHAR(50),
                        Soyad NVARCHAR(50),
                        Brans NVARCHAR(50),
                        Telefon NVARCHAR(20)
                    )";
                    new SqlCommand(queryDoktorlar, con).ExecuteNonQuery();

              
                    string queryRandevular = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Randevular')
                    CREATE TABLE Randevular (
                        RandevuId INT IDENTITY PRIMARY KEY,
                        HastaId INT,
                        DoktorId INT,
                        RandevuTarihi DATETIME,
                        Sikayet NVARCHAR(300)
                    )";
                    new SqlCommand(queryRandevular, con).ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablo oluşturma hatası: " + ex.Message);
            }
        }

        public static DataTable Listele(string sorgu)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
            return dt;
        }

        public static void KomutCalistir(string sorgu, SqlParameter[] parametreler = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sorgu, con);
                    if (parametreler != null)
                    {
                        cmd.Parameters.AddRange(parametreler);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }
    }
}
