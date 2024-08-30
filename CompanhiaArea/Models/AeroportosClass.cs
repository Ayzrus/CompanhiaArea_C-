using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanhiaArea.Models
{
    internal class AeroportosClass
    {

        #region Constantes

        public const string Table = "Aeroportos";

        #endregion Constantes

        #region Propriedades

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Local { get; set; }
        public string Pais { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todos os Aeroportos da base de dados.
        /// </summary>
        public static List<AeroportosClass> GetAeroportos()
        {
            var Aeroportos = new List<AeroportosClass>();
            using (var connection = new Connection())
            {
                var query = $"SELECT * FROM {Table}";

                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Aeroportos.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return Aeroportos;
        }

        /// <summary>
        /// Insere um novo Aeroporto na base de dados.
        /// </summary>
        public static void InserirAeroporto(AeroportosClass Aeroporto)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Codigo, Nome, Latitude, Longitude, Local, Pais) VALUES (@Codigo, @Nome, @Latitude, @Longitude, @Local, @Pais)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Codigo", Aeroporto.Codigo);
                    command.Parameters.AddWithValue("@Nome", Aeroporto.Nome);
                    command.Parameters.AddWithValue("@Latitude", Aeroporto.Latitude);
                    command.Parameters.AddWithValue("@Longitude", Aeroporto.Longitude);
                    command.Parameters.AddWithValue("@Local", Aeroporto.Local);
                    command.Parameters.AddWithValue("@Pais", Aeroporto.Pais);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Faz o mapeamento de todos os campos da tabela Aeroportos
        /// </summary>
        private static AeroportosClass MapFromReader(MySqlDataReader reader)
        {
            var Aeroportoss = new AeroportosClass
            {
                Codigo = reader.Cast<int>("codigo"),
                Nome = reader.Cast<string>("Nome"),
                Latitude = reader.Cast<float>("Latitude"),
                Longitude = reader.Cast<float>("Longitude"),
                Local = reader.Cast<string>("Local"),
                Pais = reader.Cast<string>("Pais"),
            };
            return Aeroportoss;
        }

        #endregion Métodos Estáticos

    }
}
