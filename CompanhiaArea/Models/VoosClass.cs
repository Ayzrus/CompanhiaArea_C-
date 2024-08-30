using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanhiaArea.Models
{
    internal class VoosClass
    {

        #region Constantes

        public const string Table = "voo";

        #endregion Constantes

        #region Propriedades

        public int Numero_Voo { get; set; }
        public DateTime Data { get; set; }
        public int Origem { get; set; }
        public int Destino { get; set; }
        public int N_Aviao { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Obtém todos os Voo da base de dados.
        /// </summary>
        public static List<VoosClass> GetVoos()
        {
            var Voos = new List<VoosClass>();
            using (var connection = new Connection())
            {
                var query = $"SELECT * FROM {Table}";

                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Voos.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return Voos;
        }

        /// <summary>
        /// Insere um novo Voo na base de dados.
        /// </summary>
        public static void InserirVoo(VoosClass Voo)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Numero_Voo, Data, Origem, Destino, N_Aviao) VALUES (@Numero_Voo, @Data, @Origem, @Destino, @N_Aviao)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Numero_Voo", Voo.Numero_Voo);
                    command.Parameters.AddWithValue("@Data", Voo.Data);
                    command.Parameters.AddWithValue("@Origem", Voo.Origem);
                    command.Parameters.AddWithValue("@Destino", Voo.Destino);
                    command.Parameters.AddWithValue("@N_Aviao", Voo.N_Aviao);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Faz o mapeamento de todos os campos da tabela Voos
        /// </summary>
        private static VoosClass MapFromReader(MySqlDataReader reader)
        {
            var Voos = new VoosClass
            {
                Numero_Voo = reader.Cast<int>("Numero_Voo"),
                Data = reader.Cast<DateTime>("Data"),
                Origem = reader.Cast<int>("Origem"),
                Destino = reader.Cast<int>("Destino"),
                N_Aviao = reader.Cast<int>("N_Aviao"),
            };
            return Voos;
        }

        #endregion Métodos Estáticos

    }
}
