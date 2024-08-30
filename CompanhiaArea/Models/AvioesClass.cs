using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanhiaArea.Models
{
    internal class AvioesClass
    {

        #region Constantes

        public const string Table = "avioes";

        #endregion Constantes

        #region Propriedades

        public int Numero_Aviao { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Horas_Total { get; set; }
        public float Horas_Revisao { get; set; }
        public int Capacidade { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todos os Avioes da base de dados.
        /// </summary>
        public static List<AvioesClass> GetAvioes()
        {
            var Avioes = new List<AvioesClass>();
            using (var connection = new Connection())
            {
                var query = $"SELECT * FROM {Table}";

                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Avioes.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return Avioes;
        }

        /// <summary>
        /// Faz o mapeamento de todos os campos da tabela Avioes
        /// </summary>
        private static AvioesClass MapFromReader(MySqlDataReader reader)
        {
            var Avioes = new AvioesClass
            {
                Numero_Aviao = reader.Cast<int>("Numero_Aviao"),
                Marca = reader.Cast<string>("Marca"),
                Modelo = reader.Cast<string>("Modelo"),
                Horas_Total = reader.Cast<float>("Horas_Total"),
                Horas_Revisao = reader.Cast<float>("Horas_Revisao"),
                Capacidade = reader.Cast<int>("Capacidade"),
            };
            return Avioes;
        }

        #endregion Métodos Estáticos

    }

}