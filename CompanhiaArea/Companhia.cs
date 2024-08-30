using CompanhiaArea.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CompanhiaArea
{
    public partial class Companhia : Form
    {
        public Companhia()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        #region Aeroportos

        /// <summary>
        /// Carrega todos os aeroportos de acordo com a base de dados
        /// </summary>

        private void CarregarAeroportos()
        {
            try
            {
                var listaAeroportos = AeroportosClass.GetAeroportos();

                dataGridViewAero.DataSource = listaAeroportos;

                foreach (DataGridViewColumn coluna in dataGridViewAero.Columns)
                {
                    coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Aeroportos: " + ex.Message);
            }
        }

        /// <summary>
        /// Regista um aeroporto na base de dados
        /// </summary>

        private void RegistarAero_Click(object sender, EventArgs e)
        {
            string codigo = CodigoBox.Text;

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Por favor, insira o Codigo do Aeroporto.");
                return;
            }

            string nome = NomeBox.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, insira o Nome do Aeroporto.");
                return;
            }

            string latitude = LatitudeBox.Text;

            if (string.IsNullOrWhiteSpace(latitude))
            {
                MessageBox.Show("Por favor, insira a Latitude do Aeroporto.");
                return;
            }

            string longitude = LongitudeBox.Text;

            if (string.IsNullOrWhiteSpace(longitude))
            {
                MessageBox.Show("Por favor, insira a Longitude do Aeroporto.");
                return;
            }

            string local = LocalBox.Text;

            if (string.IsNullOrWhiteSpace(local))
            {
                MessageBox.Show("Por favor, insira o Local do Aeroporto.");
                return;
            }

            string pais = LocalBox.Text;

            if (string.IsNullOrWhiteSpace(pais))
            {
                MessageBox.Show("Por favor, insira o País do Aeroporto.");
                return;
            }

            AeroportosClass novoAeroporto = new()
            {
                Codigo = int.Parse(codigo),
                Nome = nome,
                Latitude = float.Parse(latitude),
                Longitude = float.Parse(longitude),
                Local = local,
                Pais = pais,
            };

            try
            {
                AeroportosClass.InserirAeroporto(novoAeroporto);
                MessageBox.Show("Aeroporto criado com sucesso!");
                CarregarAeroportos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o Aeroporto: " + ex.Message);
            }

        }

        #endregion Aeroportos

        #region Voos
        /// <summary>
        /// Carrega todos os Voos de acordo com a base de dados
        /// </summary>
        private void CarregarVoos()
        {
            try
            {
                var listaVoos = VoosClass.GetVoos();

                var listaVoos2 = VoosClass.GetVoos();

                comboBoxVooTri.DataSource = listaVoos2;
                comboBoxVooTri.DisplayMember = "Numero_Voo";
                comboBoxVooTri.ValueMember = "Numero_Voo";

                dataGridViewVoos.DataSource = listaVoos;

                foreach (DataGridViewColumn coluna in dataGridViewVoos.Columns)
                {
                    coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                var listaAero = AeroportosClass.GetAeroportos();

                var listaAero2 = AeroportosClass.GetAeroportos();

                var listaAviao = AvioesClass.GetAvioes();

                comboBoxOrigem.DataSource = listaAero;
                comboBoxOrigem.DisplayMember = "Nome";
                comboBoxOrigem.ValueMember = "Codigo";

                comboBoxDestino.DataSource = listaAero2;
                comboBoxDestino.DisplayMember = "Nome";
                comboBoxDestino.ValueMember = "Codigo";

                comboBoxNumAviao.DataSource = listaAviao;
                comboBoxNumAviao.DisplayMember = "Numero_Aviao";
                comboBoxNumAviao.ValueMember = "Numero_Aviao";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Voos: " + ex.Message);
            }
        }

        /// <summary>
        /// Regista um Voo na base de dados
        /// </summary>
        private void RegistarVoo_Click(object sender, EventArgs e)
        {

            string nVoo = textBoxNVoo.Text;

            if (string.IsNullOrWhiteSpace(nVoo))
            {
                MessageBox.Show("Por favor, insira o Número do Voo.");
                return;
            }

            string data = dateTimePickerData.Text;

            if (string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show("Por favor, insira uma data do Voo.");
                return;
            }

            string origem = comboBoxOrigem.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(origem))
            {
                MessageBox.Show("Por favor, insira a origem do Voo.");
                return;
            }

            string destino = comboBoxDestino.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(destino))
            {
                MessageBox.Show("Por favor, insira a Longitude do Aeroporto.");
                return;
            }

            string nAviao = comboBoxNumAviao.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(nAviao))
            {
                MessageBox.Show("Por favor, insira o Número do Voo.");
                return;
            }

            VoosClass novoVoo = new()
            {
                Numero_Voo = int.Parse(nVoo),
                Data = DateTime.Parse(data),
                Origem = int.Parse(origem),
                Destino = int.Parse(destino),
                N_Aviao = int.Parse(nAviao),
            };

            try
            {
                VoosClass.InserirVoo(novoVoo);
                MessageBox.Show("Voo criado com sucesso!");
                CarregarVoos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o Voo: " + ex.Message);
            }

        }

        private void comboBoxVooTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nVoo = int.Parse(comboBoxVooTri.SelectedValue.ToString());

            VoosClass novoVoo = new()
            {
                Numero_Voo = nVoo,
            };

            try
            {
                List<TripulantesClass> tripulantes = TripulantesClass.GetTripulantesVoo(novoVoo);
                dataGridViewVooTr.DataSource = tripulantes;
                foreach (DataGridViewColumn coluna in dataGridViewVooTr.Columns)
                {
                    coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Tripulantes: " + ex.Message);
            }

        }

        #endregion Voos

        #region Passageiros



        #endregion Passageiros

        #region Viagens

        /// <summary>
        /// Carrega todos os Viagens de acordo com a base de dados
        /// </summary>
        private void CarregarViagens()
        {
            try
            {
                var listaViagens = ViagensClass.GetAvioes();

                dataGridViewViagens.DataSource = listaViagens;

                foreach (DataGridViewColumn coluna in dataGridViewViagens.Columns)
                {
                    coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Viagens: " + ex.Message);
            }
        }

        /// <summary>
        /// Apagar uma viagem pelo Id
        /// </summary>

        private void Apagar_Click(object sender, EventArgs e)
        {

            string id = textBoxId.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, insira o Id da Viagem.");
                return;
            }

            ViagensClass apagarViagem = new()
            {
                Id = int.Parse(id),
            };

            try
            {
                ViagensClass.ApagarViagem(apagarViagem);
                MessageBox.Show("Viagem apagada com sucesso!");
                CarregarViagens();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar a Viagem: " + ex.Message);
            }
        }

        #endregion Viagens

        private void Companhia_Load(object sender, EventArgs e)
        {
            CarregarAeroportos();
            CarregarVoos();
            CarregarViagens();
        }
    }
}
