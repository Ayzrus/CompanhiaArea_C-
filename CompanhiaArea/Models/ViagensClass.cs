using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanhiaArea.Models
{
    internal class ViagensClass
    {

        #region Constantes

        public const string Table = "viagens";

        #endregion Constantes

        #region Propriedades

        public int Id { get; set; }
        public int N_Voo { get; set; }
        public int Id_Passageiro { get; set; }
        public int Lugar { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todos os Viagens da base de dados.
        /// </summary>
        public static List<ViagensClass> GetAvioes()
        {
            var Avioes = new List<ViagensClass>();
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
        /// Apaga uma Viagem na base de dados.
        /// </summary>
        public static void ApagarViagem(ViagensClass Viagens)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE Id = @Id";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id", Viagens.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Faz o mapeamento de todos os campos da tabela Viagens
        /// </summary>
        private static ViagensClass MapFromReader(MySqlDataReader reader)
        {
            var Avioes = new ViagensClass
            {
                Id = reader.Cast<int>("Id"),
                N_Voo = reader.Cast<int>("N_Voo"),
                Id_Passageiro = reader.Cast<int>("Id_Passageiro"),
                Lugar = reader.Cast<int>("Lugar"),
            };
            return Avioes;
        }

        #endregion Métodos Estáticos

    }
}
