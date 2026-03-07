namespace SA_INDIVIDUAL
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.txtNome = new TextBox();
            this.txtCodigo = new TextBox();
            this.txtQtd = new TextBox();
            this.txtPreco = new TextBox();
            this.btnCadastrar = new Button();
            this.btnAtualizar = new Button();
            this.btnRemover = new Button();
            this.btnRelatorio = new Button();
            this.dgvProdutos = new DataGridView();

            // Configuração dos Inputs
            this.txtNome.Location = new System.Drawing.Point(20, 20);
            this.txtNome.PlaceholderText = "Nome";
            this.txtCodigo.Location = new System.Drawing.Point(20, 55);
            this.txtCodigo.PlaceholderText = "Código";
            this.txtQtd.Location = new System.Drawing.Point(20, 90);
            this.txtQtd.PlaceholderText = "Quantidade";
            this.txtPreco.Location = new System.Drawing.Point(20, 125);
            this.txtPreco.PlaceholderText = "Preço";

            // Estilo dos Botões conforme solicitado (Colorido)
            ConfigurarBotao(btnCadastrar, "CADASTRAR", System.Drawing.Color.Green, 170);
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

            ConfigurarBotao(btnAtualizar, "ATUALIZAR", System.Drawing.Color.Orange, 215);
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            ConfigurarBotao(btnRemover, "REMOVER", System.Drawing.Color.Red, 260);
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            ConfigurarBotao(btnRelatorio, "RELATÓRIO", System.Drawing.Color.Blue, 305);
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);

            // DataGridView
            this.dgvProdutos.Location = new System.Drawing.Point(220, 20);
            this.dgvProdutos.Size = new System.Drawing.Size(540, 350);
            this.dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.CellClick += new DataGridViewCellEventHandler(this.dgvProdutos_CellClick);

            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Text = "Controle de Estoque Indústria 4.0";
            this.Controls.AddRange(new Control[] { txtNome, txtCodigo, txtQtd, txtPreco, btnCadastrar, btnAtualizar, btnRemover, btnRelatorio, dgvProdutos });
        }

        private void ConfigurarBotao(Button b, string t, System.Drawing.Color c, int y) {
            b.Text = t; b.BackColor = c; b.ForeColor = System.Drawing.Color.White;
            b.FlatStyle = FlatStyle.Flat; b.Location = new System.Drawing.Point(20, y);
            b.Size = new System.Drawing.Size(180, 40);
        }

        private TextBox txtNome, txtCodigo, txtQtd, txtPreco;
        private Button btnCadastrar, btnAtualizar, btnRemover, btnRelatorio;
        private DataGridView dgvProdutos;
    }
}