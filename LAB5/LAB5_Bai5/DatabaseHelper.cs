using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace LAB5_Bai5
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string UserEmail { get; set; }
        public string CreatedAt { get; set; }
    }

    internal class DatabaseHelper
    {
        private static readonly string DbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CulinaryDB.sqlite");
        private static readonly string connectionString = $"Data Source={DbFilePath};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(DbFilePath))
            {
                SQLiteConnection.CreateFile(DbFilePath);
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Dishes (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Name TEXT NOT NULL,
                                Image BLOB,
                                UserEmail TEXT,
                                CreatedAt TEXT
                              )";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void AddDish(string name, byte[] imageBytes, string email)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Dishes (Name, Image, UserEmail, CreatedAt) VALUES (@name, @img, @email, @date)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name ?? string.Empty);

                    // Use explicit parameter for binary data and allow null
                    var imgParam = new SQLiteParameter("@img", DbType.Binary);
                    imgParam.Value = (object)imageBytes ?? DBNull.Value;
                    cmd.Parameters.Add(imgParam);

                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? DBNull.Value : (object)email);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static Dish GetRandomDish()
        {
            Dish dish = null;
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Dishes ORDER BY RANDOM() LIMIT 1";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] imageData = null;
                            int imageOrdinal = reader.GetOrdinal("Image");
                            if (!reader.IsDBNull(imageOrdinal))
                            {
                                imageData = (byte[])reader[imageOrdinal];
                            }

                            dish = new Dish
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"]?.ToString(),
                                UserEmail = reader["UserEmail"]?.ToString(),
                                CreatedAt = reader["CreatedAt"]?.ToString(),
                                Image = imageData
                            };
                        }
                    }
                }
            }
            return dish;
        }
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public static System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
    }
}