using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanhiaArea.Models
{
    internal class TripulantesClass
    {
        #region Constantes

        public const string Table = "tripulantes";

        #endregion Constantes

        #region Propridades

        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Funcao { get; set; }
        public float Horas { get; set; }
        public int Id_Pessoa { get; set; }
        public string Nome { get; set; }
        public string Contacto { get; set; }

        #endregion Propridades

        #region Métodos Estáticos


        /// <summary>
        /// Obtém a tripulação de um Voo.
        /// </summary>

        public static List<TripulantesClass> GetTripulantesVoo(VoosClass Voo)
        {
            var tripulantes = new List<TripulantesClass>();
            using (var connection = new Connection())
            {
                var query = "SELECT T.*, P.Nome, P.Contacto FROM voo V " +
                            "LEFT JOIN opera O ON O.N_Voo = V.Numero_Voo " +
                            "LEFT JOIN tripulantes T ON T.Id = O.Id_Tripulacao " +
                            "LEFT JOIN pessoas P ON P.Id = T.Id_Pessoa " +
                            "WHERE V.Numero_Voo = @IdVoo";

                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@IdVoo", Voo.Numero_Voo);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tripulantes.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return tripulantes;
        }


        /// <summary>
        /// Faz o mapeamento de todos os campos da tabela Tripulantes
        /// </summary>
        private static TripulantesClass MapFromReader(MySqlDataReader reader)
        {
            var tripulantes = new TripulantesClass
            {
                Id = reader.Cast<int>("Id"),
                Categoria = reader.Cast<string>("Categoria"),
                Funcao = reader.Cast<string>("Funcao"),
                Horas = reader.Cast<float>("Horas"),
                Id_Pessoa = reader.Cast<int>("Id_Pessoa"),
                Nome = reader.Cast<string>("Nome"),
                Contacto = reader.Cast<string>("Contacto"),
            };
            return tripulantes;
        }

        #endregion Métodos Estáticos

    }
}
