using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_Pedidos
{
    public partial class VisualizarCompleto : Form
    {
        private MySqlConnection con;
        private MySqlDataAdapter da;
        private DataTable dtProdutos;

        public VisualizarCompleto()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=adriana;Uid=root;Pwd=Joao2003;";
            con = new MySqlConnection(connectionString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void VisualizarCompleto_Load(object sender, EventArgs e)
        {
            try
            {
                // Verifica se a conexão está fechada e a abre se necessário
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT p.id_pedido AS Código, c.nome AS cliente, c.telefone, p.data as data_entrega, p.hora as hora_entrega, s.descricao AS status, p.observacao, i.nome_item as item , i.quantidade, i.formato, i.massa, i.recheio, i.tamanho, i.decoracao,  p.valor, p.pagamento FROM Pedidos p JOIN Clientes c ON p.id_cliente = c.id_cliente JOIN Status s ON p.status = s.id_status LEFT JOIN Pedido_Itens i ON p.id_pedido = i.id_pedido;";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar dados: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão após o uso
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.id_pedido AS Código, c.nome AS cliente, c.telefone, p.data as data_entrega, p.hora as hora_entrega, s.descricao AS status, p.observacao, i.nome_item as item , i.quantidade, i.formato, i.massa, i.recheio, i.tamanho, i.decoracao,  p.valor as valor_total, p.pagamento FROM Pedidos p JOIN Clientes c ON p.id_cliente = c.id_cliente JOIN Status s ON p.status = s.id_status LEFT JOIN Pedido_Itens i ON p.id_pedido = i.id_pedido;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnPedidosHoje_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.id_pedido AS Código, c.nome AS cliente, c.telefone, p.data as data_entrega, p.hora as hora_entrega, s.descricao AS status, p.observacao, i.nome_item as item , i.quantidade, i.formato, i.massa, i.recheio, i.tamanho, i.decoracao,  p.valor as valor_total, p.pagamento FROM Pedidos p JOIN Clientes c ON p.id_cliente = c.id_cliente JOIN Status s ON p.status = s.id_status LEFT JOIN Pedido_Itens i ON p.id_pedido = i.id_pedido WHERE p.data = CURDATE();";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnFazer_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.id_pedido AS Código, c.nome AS cliente, c.telefone, p.data as data_entrega, p.hora as hora_entrega, s.descricao AS status, p.observacao, i.nome_item as item , i.quantidade, i.formato, i.massa, i.recheio, i.tamanho, i.decoracao,  p.valor as valor_total, p.pagamento FROM Pedidos p JOIN Clientes c ON p.id_cliente = c.id_cliente JOIN Status s ON p.status = s.id_status LEFT JOIN Pedido_Itens i ON p.id_pedido = i.id_pedido WHERE s.id_status = 4;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnAndamento_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.id_pedido AS Código, c.nome AS cliente, c.telefone, p.data as data_entrega, p.hora as hora_entrega, s.descricao AS status, p.observacao, i.nome_item as item , i.quantidade, i.formato, i.massa, i.recheio, i.tamanho, i.decoracao,  p.valor as valor_total, p.pagamento FROM Pedidos p JOIN Clientes c ON p.id_cliente = c.id_cliente JOIN Status s ON p.status = s.id_status LEFT JOIN Pedido_Itens i ON p.id_pedido = i.id_pedido WHERE s.id_status = 5;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnConcluido_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.id_pedido AS Código, c.nome AS cliente, c.telefone, p.data as data_entrega, p.hora as hora_entrega, s.descricao AS status, p.observacao, i.nome_item as item , i.quantidade, i.formato, i.massa, i.recheio, i.tamanho, i.decoracao,  p.valor as valor_total, p.pagamento FROM Pedidos p JOIN Clientes c ON p.id_cliente = c.id_cliente JOIN Status s ON p.status = s.id_status LEFT JOIN Pedido_Itens i ON p.id_pedido = i.id_pedido WHERE s.id_status = 6;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnCancelado_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.id_pedido AS Código, c.nome AS cliente, c.telefone, p.data as data_entrega, p.hora as hora_entrega, s.descricao AS status, p.observacao, i.nome_item as item , i.quantidade, i.formato, i.massa, i.recheio, i.tamanho, i.decoracao,  p.valor as valor_total, p.pagamento FROM Pedidos p JOIN Clientes c ON p.id_cliente = c.id_cliente JOIN Status s ON p.status = s.id_status LEFT JOIN Pedido_Itens i ON p.id_pedido = i.id_pedido WHERE s.id_status = 7;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int codigo;
            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("Por favor, insira um código válido.");
                return;
            }

            // Define o novo status com base na seleção no ComboBox
            int novoStatus = (cbStatus.SelectedIndex == 0) ? 4 : (cbStatus.SelectedIndex == 1) ? 5 : (cbStatus.SelectedIndex == 2) ? 6 : 7;

            // String de conexão (use o banco de dados correto aqui)
            string connectionString = "Server=localhost;Database=adriana;Uid=root;Pwd=Joao2003;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        string query = "UPDATE Pedidos SET status = @novoStatus WHERE id_pedido = @codigo";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@novoStatus", novoStatus);
                            cmd.Parameters.AddWithValue("@codigo", codigo);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Status atualizado com sucesso!");
                                string querys = "SELECT p.id_pedido AS Código, c.nome AS cliente, c.telefone, p.data as data_entrega, p.hora as hora_entrega, s.descricao AS status, p.observacao, i.nome_item as item , i.quantidade, i.formato, i.massa, i.recheio, i.tamanho, i.decoracao,  p.valor, p.pagamento FROM Pedidos p JOIN Clientes c ON p.id_cliente = c.id_cliente JOIN Status s ON p.status = s.id_status LEFT JOIN Pedido_Itens i ON p.id_pedido = i.id_pedido;";
                                using (MySqlDataAdapter adapter = new MySqlDataAdapter(querys, con))
                                {

                                    DataTable table = new DataTable();
                                    adapter.Fill(table);
                                    dataGridView1.DataSource = table;
                                }
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Código do pedido não encontrado.");
                            }
                        }
                    }
                }
                catch (MySqlException ex) when (ex.Number == 1451)
                {
                    MessageBox.Show("Erro ao atualizar o status: A operação viola uma restrição de chave estrangeira. Certifique-se de que o status existe na tabela `Status`.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o status: " + ex.Message);
                }
            }


        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            Principal principal = new Principal();
            principal.ShowDialog();
        }
    }
}
