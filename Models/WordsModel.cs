using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ExplanationTgBotGame.Models
{
    internal class WordsModel
    {

        public static List<string> GetList() {
            var Words = new List<string>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=DESKTOP-EQRMKJT\\SQLEXPRESS;Initial Catalog=ExplanationGame;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT TOP 100 Id, Word, Difficulty FROM Words ORDER BY newid()", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string word = reader["Word"].ToString();
                        Console.WriteLine(word);

                        if (!string.IsNullOrEmpty(word))
                        {
                            Words.Add(word);
                        }

                    }

                }
            }

            return Words;
        } 
    }
}
