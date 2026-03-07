using System;
using System.Data;
using System.Windows.Forms;

namespace SA_INDIVIDUAL
{
    public partial class Form1 : Form
    {
        ProdutoDAO db = new ProdutoDAO();

        public Form1()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = db.BuscarTodos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try {
                if (ValidarCampos()) {
                    db.Salvar(txtNome.Text, txtCodigo.Text, int.Parse(txtQtd.Text), decimal.Parse(txtPreco.Text));
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    LimparCampos();
                    AtualizarGrid();
                }
            } catch { MessageBox.Show("Erro: Verifique os valores numéricos."); }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0) {
                try {
                    if (ValidarCampos()) {
                        int id = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["Id"].Value);
                        db.Atualizar(id, txtNome.Text, txtCodigo.Text, int.Parse(txtQtd.Text), decimal.Parse(txtPreco.Text));
                        MessageBox.Show("Produto atualizado!");
                        AtualizarGrid();
                    }
                } catch { MessageBox.Show("Erro nos dados de atualização."); }
            } else { MessageBox.Show("Selecione um produto na tabela."); }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0) {
                int id = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["Id"].Value);
                db.Remover(id);
                MessageBox.Show("Produto removido!");
                AtualizarGrid();
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DataTable dt = db.BuscarTodos();
            int totalQtd = 0;
            decimal valorTotal = 0;

            foreach (DataRow row in dt.Rows) {
                int q = Convert.ToInt32(row["Quantidade"]);
                decimal p = Convert.ToDecimal(row["Preco"]);
                totalQtd += q;
                valorTotal += (q * p);
            }

            MessageBox.Show($"--- RELATÓRIO DE ESTOQUE ---\n\nTotal de Itens: {totalQtd}\nValor Total: R$ {valorTotal:F2}");
        }

        private bool ValidarCampos() {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtQtd.Text)) {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return false;
            }
            return true;
        }

        private void LimparCampos() {
            txtNome.Clear(); txtCodigo.Clear(); txtQtd.Clear(); txtPreco.Clear();
            txtNome.Focus();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = dgvProdutos.Rows[e.RowIndex];
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtQtd.Text = row.Cells["Quantidade"].Value.ToString();
                txtPreco.Text = row.Cells["Preco"].Value.ToString();
            }
        }
    }
}