using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_Pedidos
{
    public partial class Cadastro : Form
    {

        private MySqlConnection con;
        private MySqlDataAdapter da;
        private DataTable dtProdutos;
        public Cadastro()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=adriana;Uid=root;Pwd=Joao2003;";
            con = new MySqlConnection(connectionString);

            txtBolinhas.TextChanged += (s, e) => atualização();
            txtCoxinhas.TextChanged += (s, e) => atualização();
            txtConcretes.TextChanged += (s, e) => atualização();
            txtRissoles.TextChanged += (s, e) => atualização();
            txtTrouxinhas.TextChanged += (s, e) => atualização();
            txtKibes.TextChanged += (s, e) => atualização();
            txtEmpadas.TextChanged += (s, e) => atualização();
            txtEsfihas.TextChanged += (s, e) => atualização();
            rbBranca.CheckedChanged += (s, e) => atualização();
            rbChocolate.CheckedChanged += (s, e) => atualização();
            txtBeijinho.TextChanged += (s, e) => atualização();
            txtBrigadeiro.TextChanged += (s, e) => atualização();
            txtBicho.TextChanged += (s, e) => atualização();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
           
        }
        private decimal atualização()
        {
            // Quantidade de itens
            int qtdBolinhas = int.TryParse(txtBolinhas.Text, out int bolinhas) ? bolinhas : 0;
            int qtdCoxinhas = int.TryParse(txtCoxinhas.Text, out int coxinhas) ? coxinhas : 0;
            int qtdConcretes = int.TryParse(txtConcretes.Text, out int concretes) ? concretes : 0;
            int qtdRissoles = int.TryParse(txtRissoles.Text, out int rissoles) ? rissoles : 0;
            int qtdTrouxinhas = int.TryParse(txtTrouxinhas.Text, out int trouxinhas) ? trouxinhas : 0;
            int qtdKibes = int.TryParse(txtKibes.Text, out int kibes) ? kibes : 0;
            int qtdEmpadas = int.TryParse(txtEmpadas.Text, out int empadas) ? empadas : 0;
            int qtdEsfihas = int.TryParse(txtEsfihas.Text, out int esfihas) ? esfihas : 0;
            int qtdBeijinho = int.TryParse(txtBeijinho.Text, out int beijinho) ? beijinho : 0;
            int qtdBrigadeiro = int.TryParse(txtBrigadeiro.Text, out int brigadeiro) ? brigadeiro : 0;
            int qtdBicho = int.TryParse(txtBicho.Text, out int bicho) ? bicho : 0;

            // Totais
            int qtdTotalSalgados = qtdBolinhas + qtdCoxinhas + qtdConcretes + qtdRissoles + qtdTrouxinhas + qtdKibes + qtdEmpadas + qtdEsfihas;
            int qtdTotalDoces = qtdBeijinho + qtdBrigadeiro + qtdBicho;

            lbSalgadosqtd.Text = qtdTotalSalgados.ToString();
            lbQtdoce.Text = qtdTotalDoces.ToString();

            // Preço unitário dos itens
            decimal precoBolinhas = 0.45m, precoCoxinha = 0.45m, precoConcretes = 0.45m;
            decimal precoRissoles = 0.45m, precoTrouxinhas = 0.45m, precoKibes = 0.45m;
            decimal precoEmpadas = 2.50m, precoEsfihas = 3.00m, precoBeijinho = 3.00m;
            decimal precoBrigadeiro = 3.00m, precoBicho = 3.00m;

            // Calculando valores dos itens
            decimal totalGastoSalgados = (qtdBolinhas * precoBolinhas) + (qtdCoxinhas * precoCoxinha) +
                                         (qtdConcretes * precoConcretes) + (qtdRissoles * precoRissoles) +
                                         (qtdTrouxinhas * precoTrouxinhas) + (qtdKibes * precoKibes) +
                                         (qtdEmpadas * precoEmpadas) + (qtdEsfihas * precoEsfihas);
            lbSalgadostotal.Text = totalGastoSalgados.ToString("F2");

            decimal totalGastodoces = (qtdBeijinho * precoBeijinho) + (qtdBrigadeiro * precoBrigadeiro) + (qtdBicho * precoBicho);
            lbValorDoce.Text = totalGastodoces.ToString("F2");

            // Cálculo do bolo
            decimal boloin = rbBranca.Checked ? 50.00m : rbChocolate.Checked ? 40.00m : 0;
            lbQtdBolo.Text = boloin > 0 ? "1" : "0";
            lbValorBolo.Text = boloin.ToString("F2");

            // Total
            decimal total = totalGastodoces + totalGastoSalgados + boloin;
            lbTotal.Text = total.ToString("F2");
            return total;
        }

        // Classe PedidoItem para armazenar cada item do pedido, incluindo campos de bolo
        public class Item
        {
            public string Nome { get; set; }
            public string Tipo { get; set; }
            public int Quantidade { get; set; }
            public decimal PrecoUnitario { get; set; }
            public string Formato { get; set; }
            public string Massa { get; set; }
            public string Recheio { get; set; }
            public decimal Tamanho { get; set; }
            public string Decoracao { get; set; }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void LimparCampos()
        {
            txtTelefone.Text = "";
            txtNome.Text = "";
            txtData.Text = "";
            txtHora.Text = "";
            txtAdicional.Text = "";
            txtRecheio.Text = "";
            txtDecoracao.Text = "";
            txtBolinhas.Text = "";
            txtCoxinhas.Text = "";
            txtConcretes.Text = "";
            txtRissoles.Text = "";
            txtTrouxinhas.Text = "";
            txtKibes.Text = "";
            txtEmpadas.Text = "";
            txtEsfihas.Text = "";
            txtBeijinho.Text = "";
            txtBrigadeiro.Text = "";
            txtBicho.Text = "";
            txtTamanho.Text = "";
            slPagamento.SelectedIndex = -1;
            rbRedondo.Checked = false;
            rbQuadrado.Checked = false;
            rbBranca.Checked = false;
            rbChocolate.Checked = false;
        }
        private List<Item> ObterItens()
        {
            var itens = new List<Item>();
            int qtdBolinhas = int.TryParse(txtBolinhas.Text, out int bolinhas) ? bolinhas : 0;
            int qtdCoxinhas = int.TryParse(txtCoxinhas.Text, out int coxinhas) ? coxinhas : 0;
            int qtdConcretes = int.TryParse(txtConcretes.Text, out int concretes) ? concretes : 0;
            int qtdRissoles = int.TryParse(txtRissoles.Text, out int rissoles) ? rissoles : 0;
            int qtdTrouxinhas = int.TryParse(txtTrouxinhas.Text, out int trouxinhas) ? trouxinhas : 0;
            int qtdKibes = int.TryParse(txtKibes.Text, out int kibes) ? kibes : 0;
            int qtdEmpadas = int.TryParse(txtEmpadas.Text, out int empadas) ? empadas : 0;
            int qtdEsfihas = int.TryParse(txtEsfihas.Text, out int esfihas) ? esfihas : 0;
            int qtdBeijinho = int.TryParse(txtBeijinho.Text, out int beijinho) ? beijinho : 0;
            int qtdBrigadeiro = int.TryParse(txtBrigadeiro.Text, out int brigadeiro) ? brigadeiro : 0;
            int qtdBicho = int.TryParse(txtBicho.Text, out int bicho) ? bicho : 0;
            string formatoBolo = rbRedondo.Checked ? "Redondo" : (rbQuadrado.Checked ? "Quadrado" : "");
            string massaBolo = rbBranca.Checked ? "Branca" : (rbChocolate.Checked ? "Chocolate" : "");
            string recheioBolo = txtRecheio.Text;
            string decoracaoBolo = txtDecoracao.Text;
            decimal tamanhoBolo = decimal.TryParse(txtTamanho.Text, out decimal tamanho) ? tamanho : 0;

            if (rbRedondo.Checked || rbQuadrado.Checked)
            {
                itens.Add(new Item
                {
                    Nome = "Bolo",
                    Tipo = "Bolo",
                    Quantidade = 1,
                    PrecoUnitario = rbBranca.Checked ? 50.00m : 40.00m,
                    Formato = formatoBolo,
                    Massa = massaBolo,
                    Recheio = recheioBolo,
                    Tamanho = tamanhoBolo,
                    Decoracao = txtDecoracao.Text
                });
            }
            if (qtdBolinhas > 0) itens.Add(new Item { Nome = "Bolinha", Tipo = "salgado", Quantidade = qtdBolinhas });
            if (qtdCoxinhas > 0) itens.Add(new Item { Nome = "Coxinha", Tipo = "salgado", Quantidade = qtdCoxinhas});
            if (qtdConcretes > 0) itens.Add(new Item { Nome = "Concretes", Tipo = "salgado", Quantidade = qtdConcretes });
            if (qtdRissoles > 0) itens.Add(new Item { Nome = "Rissoles", Tipo = "salgado", Quantidade = qtdRissoles });
            if (qtdTrouxinhas > 0) itens.Add(new Item { Nome = "Trouxinhas", Tipo = "salgado", Quantidade = qtdTrouxinhas });
            if (qtdEmpadas > 0) itens.Add(new Item { Nome = "Empada", Tipo = "salgado", Quantidade = qtdEmpadas });
            if (qtdEsfihas > 0) itens.Add(new Item { Nome = "Esfiha", Tipo = "salgado", Quantidade = qtdEsfihas });

            if (qtdBeijinho > 0) itens.Add(new Item { Nome = "Beijinho", Tipo = "doce", Quantidade = qtdBeijinho });
            if (qtdBrigadeiro > 0) itens.Add(new Item { Nome = "Brigadeiro", Tipo = "doce", Quantidade = qtdBrigadeiro });
            if (qtdBicho > 0) itens.Add(new Item { Nome = "Bicho de Pé", Tipo = "doce", Quantidade = qtdBicho });



            return itens;
        }

            private void button1_Click(object sender, EventArgs e)
        {
            string telefone = txtTelefone.Text, nome = txtNome.Text;
            string dataTexto = txtData.Text, horaTexto = txtHora.Text;
            int status = 4;
            string pagamento = slPagamento.SelectedItem?.ToString() ?? "";
            string observacao = txtAdicional.Text;
            decimal totalPedido = atualização();

            // Lista de itens
            List<Item> itens = ObterItens();

            if (DateTime.TryParse(dataTexto, out DateTime data) && TimeSpan.TryParse(horaTexto, out TimeSpan hora))
            {
                if (!string.IsNullOrEmpty(telefone) || !string.IsNullOrEmpty(nome) || !string.IsNullOrEmpty(pagamento))
                {
                    CadastrarPedido(telefone, nome, data, hora, status, pagamento, observacao, itens, totalPedido);
                    LimparCampos();

                }
                else
                {
                    MessageBox.Show("Por favor, insira todos os dados do cliente!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data e hora válidas.");
            }

          


            //aqui btton
        }


        private void CadastrarPedido(string telefone, string nome, DateTime data, TimeSpan hora, int status, string pagamento, string observacao, List<Item> itens, decimal atualização)
        {
            int idCliente = CadastrarCliente(nome, telefone);
            int idStatus = status; // O ID do status deve corresponder aos valores na tabela Status

            try
            {
                con.Open();

                // Iniciando uma transação para garantir que o pedido e seus itens sejam cadastrados de forma atômica
                using (var transaction = con.BeginTransaction())
                {
                    // Inserindo pedido
                    string queryPedido = "INSERT INTO Pedidos (id_cliente, data, hora, status, valor, pagamento, telefone, observacao) " +
                                         "VALUES (@id_cliente, @data, @hora, @status, @valor, @pagamento, @telefone, @observacao)";
                    int idPedido;

                    using (MySqlCommand cmd = new MySqlCommand(queryPedido, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@hora", hora);
                        cmd.Parameters.AddWithValue("@status", idStatus);
                        cmd.Parameters.AddWithValue("@valor", atualização);
                        cmd.Parameters.AddWithValue("@pagamento", pagamento);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@observacao", observacao);
                        cmd.ExecuteNonQuery();

                        idPedido = (int)cmd.LastInsertedId; // Obtendo o ID do pedido recém-inserido
                    }

                    // Inserindo itens do pedido
                    string queryItem = "INSERT INTO Pedido_Itens (id_pedido, nome_item, tipo_item, quantidade, preco_unitario, formato, massa, recheio, tamanho, decoracao) " +
                                       "VALUES (@id_pedido, @nome_item, @tipo_item, @quantidade, @preco_unitario, @formato, @massa, @recheio, @tamanho, @decoracao)";

                    foreach (var item in itens)
                    {
                        using (MySqlCommand cmdItem = new MySqlCommand(queryItem, con, transaction))
                        {
                            cmdItem.Parameters.AddWithValue("@id_pedido", idPedido);
                            cmdItem.Parameters.AddWithValue("@nome_item", item.Nome);
                            cmdItem.Parameters.AddWithValue("@tipo_item", item.Tipo);
                            cmdItem.Parameters.AddWithValue("@quantidade", item.Quantidade);
                            cmdItem.Parameters.AddWithValue("@preco_unitario", item.PrecoUnitario);
                            cmdItem.Parameters.AddWithValue("@formato", item.Formato ?? (object)DBNull.Value);
                            cmdItem.Parameters.AddWithValue("@massa", item.Massa ?? (object)DBNull.Value);
                            cmdItem.Parameters.AddWithValue("@recheio", item.Recheio ?? (object)DBNull.Value);
                            cmdItem.Parameters.AddWithValue("@tamanho", item.Tamanho > 0 ? item.Tamanho : (object)DBNull.Value);
                            cmdItem.Parameters.AddWithValue("@decoracao", item.Decoracao ?? (object)DBNull.Value);

                            // Executa a inserção do item
                            int rowsAffected = cmdItem.ExecuteNonQuery();

                            // Verifica se a inserção foi bem-sucedida
                            if (rowsAffected == 0)
                            {
                                throw new Exception("Falha ao inserir o item: " + item.Nome);
                            }
                        }
                    }

                    // Confirma a transação após a inserção bem-sucedida do pedido e de todos os itens
                    transaction.Commit();
                    MessageBox.Show("Pedido cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar pedido: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão após o uso
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        


    }
        private int CadastrarCliente(string nome, string telefone)
        {
            int idCliente;

            string queryCliente = "INSERT INTO Clientes (nome, telefone) VALUES (@nome, @telefone) " +
                                  "ON DUPLICATE KEY UPDATE id_cliente = LAST_INSERT_ID(id_cliente)";

            // Verifique se a conexão está fechada antes de abrir
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(queryCliente, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@telefone", telefone);

                    // Executa o comando para inserção ou atualização do cliente
                    cmd.ExecuteNonQuery();

                    // Obtém o ID do cliente inserido ou atualizado
                    idCliente = (int)cmd.LastInsertedId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
                idCliente = -1; // Retorna -1 em caso de erro
            }
            finally
            {
                // Fechar a conexão após o uso
                con.Close();
            }

            return idCliente;
        }

       

            private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void lbSalgadostotal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            VisualizarCompleto visualizarCompleto = new VisualizarCompleto();
            visualizarCompleto.ShowDialog();
            this.Show();
        }
    }

    //aqui maximo}

}
