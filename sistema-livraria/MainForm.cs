using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Livraria
{
    public partial class MainForm : Form
    {
        string connString = "Server=127.0.0.1;Database=livraria;Uid=root;Pwd=1234;";

        public MainForm()
        {
            InitializeComponent();
            
        }
        

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblISBN_Click(object sender, EventArgs e)
        {

        }

        private void lblEdicao_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblAutor_Click(object sender, EventArgs e)
        {

        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtISBN.Text = "";
            txtAutor.Text = "";
            txtNacionalidade.Text = "";
            txtEditora.Text = "";
            txtAno.Text = "";
            txtEdicao.Text = "";
            txtPreco.Text = "";
            cmbGenero.SelectedIndex = -1;

            // LIMPA
            gridAutores.DataSource = null;
            gridAutores.Rows.Clear();
            gridAutores.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validação
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtEditora.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text) ||
                string.IsNullOrWhiteSpace(txtEdicao.Text))
            {
                MessageBox.Show("Preencha todos os campos do livro antes de salvar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gridAutores.Rows.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um autor antes de salvar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = "server=127.0.0.1;database=livraria;uid=root;pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                int idLivro = 0;
                int idEdicao = 0;

                // Cadastrar livro
                using (MySqlCommand cmd = new MySqlCommand("sp_cadastrar_livro", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_isbn", txtISBN.Text);
                    cmd.Parameters.AddWithValue("p_nome", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("p_genero", cmbGenero.Text);
                    cmd.Parameters.Add(new MySqlParameter("p_id_livro", MySqlDbType.Int32));
                    cmd.Parameters["p_id_livro"].Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    idLivro = Convert.ToInt32(cmd.Parameters["p_id_livro"].Value);
                }

                // Cadastrar edição
                using (MySqlCommand cmd = new MySqlCommand("sp_cadastrar_edicao", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_editora", txtEditora.Text);
                    cmd.Parameters.AddWithValue("p_ano", Convert.ToInt32(txtAno.Text));
                    cmd.Parameters.AddWithValue("p_num_edicao", Convert.ToInt32(txtEdicao.Text));

                    // preço
                    cmd.Parameters.AddWithValue("p_preco", Convert.ToDecimal(txtPreco.Text));

                    cmd.Parameters.AddWithValue("p_id_livro", idLivro);

                    
                    MySqlParameter pIdEdicao = new MySqlParameter("p_id_edicao", MySqlDbType.Int32);
                    pIdEdicao.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pIdEdicao);

                    cmd.ExecuteNonQuery();

                    idEdicao = Convert.ToInt32(cmd.Parameters["p_id_edicao"].Value);
                }

                // Cadastrar todos os autores do grid
                foreach (DataGridViewRow row in gridAutores.Rows)
                {
                    string nomeAutor = row.Cells["NomeAutor"].Value.ToString();
                    string nacaoAutor = row.Cells["Nacionalidade"].Value.ToString();

                    int idAutor = 0;

                    // Cadastrar autor
                    using (MySqlCommand cmd = new MySqlCommand("sp_cadastrar_autor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_nome", nomeAutor);
                        cmd.Parameters.AddWithValue("p_nacao", nacaoAutor);

                        cmd.Parameters.Add(new MySqlParameter("p_id_autor", MySqlDbType.Int32));
                        cmd.Parameters["p_id_autor"].Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        idAutor = Convert.ToInt32(cmd.Parameters["p_id_autor"].Value);
                    }

                    // Associar livro + autor
                    using (MySqlCommand cmd = new MySqlCommand("sp_associar_autor_livro", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_id_livro", idLivro);
                        cmd.Parameters.AddWithValue("p_id_autor", idAutor);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Livro e autores cadastrados com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionarAtor_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrWhiteSpace(txtAutor.Text) ||
                    string.IsNullOrWhiteSpace(txtNacionalidade.Text))
                {
                    MessageBox.Show("Preencha o nome e a nacionalidade do autor.");
                    return;
                }

                // Adiciona no grid
                gridAutores.Rows.Add(txtAutor.Text, txtNacionalidade.Text);

                // Limpa os campos
                txtAutor.Text = "";
                txtNacionalidade.Text = "";
                txtAutor.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Add("Romance");
            cmbGenero.Items.Add("Ficção");
            cmbGenero.Items.Add("Fantasia");
            cmbGenero.Items.Add("Terror");
            cmbGenero.Items.Add("Suspense");
            cmbGenero.Items.Add("Drama");
            cmbGenero.Items.Add("Aventura");
            cmbGenero.Items.Add("Biografia");
            cmbGenero.Items.Add("Infantil");

            cmbTipoConsulta.Items.Add("Título");
            cmbTipoConsulta.Items.Add("Autor");
            cmbTipoConsulta.Items.Add("Gênero");
            cmbTipoConsulta.Items.Add("Editora");
            cmbTipoConsulta.Items.Add("Ano");
        }

        private void cmbTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoConsulta.Text)
            {
                case "Título":   
                    lblValorConsulta.Text = "Digite o título do livro:";
                    break;

                case "Autor":
                    lblValorConsulta.Text = "Digite o nome do autor:";
                    break;

                case "Gênero":
                    lblValorConsulta.Text = "Digite o gênero:";
                    break;

                case "Editora":
                    lblValorConsulta.Text = "Digite a editora:";
                    break;

                case "Ano":
                    lblValorConsulta.Text = "Digite o ano:";
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridResultados.DataSource = null;

            if (cmbTipoConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de consulta.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValorConsulta.Text))
            {
                MessageBox.Show("Digite um valor para buscar.");
                return;
            }

            string connStr = "server=127.0.0.1;database=livraria;uid=root;pwd=1234;";
            string sql = "";

            switch (cmbTipoConsulta.Text)
            {
                case "Título":
                    sql = @"SELECT 
                l.nome AS `Livro`,
                l.genero AS `Genero`,
                e.editora AS `Editora`,
                e.ano AS `Ano`,
                e.preco AS `Preco`,
                a.nome AS `Autor`
            FROM tb_livro l
            JOIN tb_edicoes e ON e.id_livro = l.id
            JOIN tb_lista li ON li.id_livro = l.id
            JOIN tb_autor a ON a.id = li.id_autor
            WHERE l.nome LIKE CONCAT('%', @valor, '%')";
                    break;

                case "Autor":
                    sql = @"SELECT 
                l.nome AS `Livro`,
                l.genero AS `Genero`,
                e.editora AS `Editora`,
                e.ano AS `Ano`,
                e.preco AS `Preco`,
                a.nome AS `Autor`
            FROM tb_livro l
            JOIN tb_edicoes e ON e.id_livro = l.id
            JOIN tb_lista li ON li.id_livro = l.id
            JOIN tb_autor a ON a.id = li.id_autor
            WHERE a.nome LIKE CONCAT('%', @valor, '%')";
                    break;

                case "Gênero":
                    sql = @"SELECT 
                l.nome AS `Livro`,
                l.genero AS `Genero`,
                e.editora AS `Editora`,
                e.ano AS `Ano`,
                e.preco AS `Preco`,
                a.nome AS `Autor`
            FROM tb_livro l
            JOIN tb_edicoes e ON e.id_livro = l.id
            JOIN tb_lista li ON li.id_livro = l.id
            JOIN tb_autor a ON a.id = li.id_autor
            WHERE l.genero LIKE CONCAT('%', @valor, '%')";
                    break;

                case "Editora":
                    sql = @"SELECT 
                l.nome AS `Livro`,
                l.genero AS `Genero`,
                e.editora AS `Editora`,
                e.ano AS `Ano`,
                e.preco AS `Preco`,
                a.nome AS `Autor`
            FROM tb_livro l
            JOIN tb_edicoes e ON e.id_livro = l.id
            JOIN tb_lista li ON li.id_livro = l.id
            JOIN tb_autor a ON a.id = li.id_autor
            WHERE e.editora LIKE CONCAT('%', @valor, '%')";
                    break;

                case "Ano":
                    sql = @"SELECT 
                l.nome AS `Livro`,
                l.genero AS `Genero`,
                e.editora AS `Editora`,
                e.ano AS `Ano`,
                e.preco AS `Preco`,
                a.nome AS `Autor`
            FROM tb_livro l
            JOIN tb_edicoes e ON e.id_livro = l.id
            JOIN tb_lista li ON li.id_livro = l.id
            JOIN tb_autor a ON a.id = li.id_autor
            WHERE e.ano = @valor";
                    break;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@valor", txtValorConsulta.Text);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gridResultados.DataSource = dt;
                    gridResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    gridResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    gridResultados.AllowUserToResizeColumns = true;
                }
            }
        }
        private void txtEditora_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTipoBusca_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridAlteracoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBuscaAlteracao_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Remove máscaras anteriores
            txtValorBuscaAlteracao.KeyPress -= MascaraPreco;
            txtValorBuscaAlteracao.KeyPress -= MascaraAno;
            txtValorBuscaAlteracao.KeyPress -= MascaraISBN;
            txtValorBuscaAlteracao.KeyPress -= MascaraTextoLivre;

            switch (cmbBuscaAlteracao.Text)
            {
                case "Título":
                    lblValorBuscaAlteracao.Text = "Digite o título:";
                    txtValorBuscaAlteracao.KeyPress += MascaraTextoLivre;
                    break;

                case "Autor":
                    lblValorBuscaAlteracao.Text = "Digite o autor:";
                    txtValorBuscaAlteracao.KeyPress += MascaraTextoLivre;
                    break;

                case "Editora":
                    lblValorBuscaAlteracao.Text = "Digite a editora:";
                    txtValorBuscaAlteracao.KeyPress += MascaraTextoLivre;
                    break;

                case "ISBN":
                    lblValorBuscaAlteracao.Text = "Digite o ISBN:";
                    txtValorBuscaAlteracao.KeyPress += MascaraISBN;
                    break;

                case "Preço":
                    lblValorBuscaAlteracao.Text = "Digite o preço para busca:";
                    txtValorBuscaAlteracao.KeyPress += MascaraPreco;
                    break;

                case "Gênero":  
                    lblValorBuscaAlteracao.Text = "Digite o gênero:";
                    txtValorBuscaAlteracao.KeyPress += MascaraTextoLivre;
                    break;
            }
        }


        private void btnBuscarAlteracao_Click(object sender, EventArgs e)
        {
            if (cmbBuscaAlteracao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo de busca.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValorBuscaAlteracao.Text))
            {
                MessageBox.Show("Digite o valor para buscar.");
                return;
            }

            string campo = "";
            string filtro = "";
            string valor = txtValorBuscaAlteracao.Text.Trim();

            // Identifica o campo da busca
            switch (cmbBuscaAlteracao.Text)
            {
                case "Título":
                    campo = "l.nome";
                    filtro = $"{campo} LIKE CONCAT('%', @valor, '%')";
                    break;

                case "Autor":
                    campo = "a.nome";
                    filtro = $"{campo} LIKE CONCAT('%', @valor, '%')";
                    break;

                case "Editora":
                    campo = "e.editora";
                    filtro = $"{campo} LIKE CONCAT('%', @valor, '%')";
                    break;

                case "ISBN":
                    campo = "l.isbn";
                    filtro = $"{campo} LIKE CONCAT('%', @valor, '%')";
                    break;

                case "Gênero":   
                    campo = "l.genero";
                    filtro = $"{campo} LIKE CONCAT('%', @valor, '%')";
                    break;

                case "Preço":
                    if (valor.Contains("-"))
                    {
                        string[] partes = valor.Split('-');

                        if (partes.Length != 2)
                        {
                            MessageBox.Show("Formato inválido. Use: mínimo-máximo (ex: 20-50)");
                            return;
                        }

                        filtro = "e.preco BETWEEN @min AND @max";
                    }
                    else if (valor.StartsWith(">="))
                    {
                        filtro = "e.preco >= @valor";
                    }
                    else if (valor.StartsWith("<="))
                    {
                        filtro = "e.preco <= @valor";
                    }
                    else if (valor.StartsWith(">"))
                    {
                        filtro = "e.preco > @valor";
                    }
                    else if (valor.StartsWith("<"))
                    {
                        filtro = "e.preco < @valor";
                    }
                    else
                    {
                        filtro = "e.preco = @valor";
                    }
                    break;
            }

            string sql = $@"
        SELECT 
            l.id AS ID,
            l.isbn AS ISBN,
            l.nome AS Livro,
            l.genero AS Genero,     -- ✅ NOVO
            a.nome AS Autor,
            e.editora AS Editora,
            e.ano AS Ano,
            e.num_edicao AS NumeroEdicao,
            e.preco AS Preco
        FROM tb_livro l
        JOIN tb_edicoes e ON e.id_livro = l.id
        JOIN tb_lista li ON li.id_livro = l.id
        JOIN tb_autor a ON a.id = li.id_autor
        WHERE {filtro}
    ";

            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=livraria;uid=root;pwd=1234;"))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (cmbBuscaAlteracao.Text == "Preço" && valor.Contains("-"))
                    {
                        string[] partes = valor.Split('-');

                        cmd.Parameters.AddWithValue("@min", partes[0].Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@max", partes[1].Trim().Replace(",", "."));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@valor", valor.Replace(">", "").Replace("<", "").Replace("=", "").Trim().Replace(",", "."));
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gridAlteracoes.DataSource = dt;
                }
            }
        }

        private void gridAlteracoes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string coluna = gridAlteracoes.Columns[e.ColumnIndex].Name;
            string valor = gridAlteracoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();

            // ID do livro
            string id = gridAlteracoes.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            // Conversão automática do preço
            if (coluna == "Preco")
            {
                valor = valor.Replace(",", ".");
            }

            
            switch (coluna)
            {
                case "ISBN":
                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        MessageBox.Show("O ISBN não pode ficar vazio.");
                        return;
                    }
                    if (valor.Length > 50)
                    {
                        MessageBox.Show("O ISBN é muito longo.");
                        return;
                    }
                    break;

                case "Livro":
                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        MessageBox.Show("O título não pode ficar vazio.");
                        return;
                    }
                    if (valor.Length > 50)
                    {
                        MessageBox.Show("O título é muito longo.");
                        return;
                    }
                    break;

                case "Gênero":   
                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        MessageBox.Show("O gênero não pode ficar vazio.");
                        return;
                    }
                    if (valor.Length > 50)
                    {
                        MessageBox.Show("O gênero é muito longo.");
                        return;
                    }
                    break;

                case "Editora":
                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        MessageBox.Show("A editora não pode ficar vazia.");
                        return;
                    }
                    if (valor.Length > 50)
                    {
                        MessageBox.Show("O nome da editora é muito longo.");
                        return;
                    }
                    break;

                case "Ano":
                    if (!int.TryParse(valor, out int ano) || ano < 1 || ano > DateTime.Now.Year)
                    {
                        MessageBox.Show("Ano inválido.");
                        return;
                    }
                    break;

                case "Numero de Edicao":
                    if (!int.TryParse(valor, out int numEdicao) || numEdicao < 1)
                    {
                        MessageBox.Show("Número da edição inválido.");
                        return;
                    }
                    break;

                case "Preço":
                    if (!decimal.TryParse(valor, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal preco) || preco < 0)
                    {
                        MessageBox.Show("Preço inválido.");
                        return;
                    }
                    break;

                case "Autor":
                    MessageBox.Show("Autor não pode ser alterado por aqui.");
                    return;

                case "ID":
                    MessageBox.Show("O ID não pode ser alterado.");
                    return;
            }

            
            string sql = "";

            switch (coluna)
            {
                case "ISBN":
                    sql = "UPDATE tb_livro SET isbn = @valor WHERE id = @id";
                    break;

                case "Livro":
                    sql = "UPDATE tb_livro SET nome = @valor WHERE id = @id";
                    break;

                case "Genero":   
                    sql = "UPDATE tb_livro SET genero = @valor WHERE id = @id";
                    break;

                case "Editora":
                    sql = "UPDATE tb_edicoes SET editora = @valor WHERE id_livro = @id";
                    break;

                case "Ano":
                    sql = "UPDATE tb_edicoes SET ano = @valor WHERE id_livro = @id";
                    break;

                case "NumeroEdicao":
                    sql = "UPDATE tb_edicoes SET num_edicao = @valor WHERE id_livro = @id";
                    break;

                case "Preco":
                    sql = "UPDATE tb_edicoes SET preco = @valor WHERE id_livro = @id";
                    break;

                default:
                    return;
            }

            // UPDATE NO BANCO
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=livraria;uid=root;pwd=1234;"))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Alteração salva com sucesso!");
        }
        private void txtValorBuscaAlteracao_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void MascaraPreco(object sender, KeyPressEventArgs e)
        {
            // Aceita números, vírgula, ponto e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void MascaraAno(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void MascaraISBN(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void MascaraTextoLivre(object sender, KeyPressEventArgs e)
        {
            // Aceita tudo
            e.Handled = false;
        }

        private void txtValorBuscaAlteracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizarAlteracao_Click(object sender, EventArgs e)
        {
            
            if (cmbBuscaAlteracao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo de busca para atualizar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValorBuscaAlteracao.Text))
            {
                MessageBox.Show("Digite o valor da busca para atualizar.");
                return;
            }
            btnBuscarAlteracao_Click(sender, e);
        }
        private void btnLimparAlteracao_Click(object sender, EventArgs e)
        {
            
            cmbBuscaAlteracao.SelectedIndex = -1;

            txtValorBuscaAlteracao.Text = "";

            lblValorBuscaAlteracao.Text = "Digite o valor:";

            
            txtValorBuscaAlteracao.KeyPress -= MascaraPreco;
            txtValorBuscaAlteracao.KeyPress -= MascaraAno;
            txtValorBuscaAlteracao.KeyPress -= MascaraISBN;
            txtValorBuscaAlteracao.KeyPress -= MascaraTextoLivre;

            
            gridAlteracoes.DataSource = null;
            gridAlteracoes.ClearSelection();
        }

        private void btnExcluirAlteracao_Click(object sender, EventArgs e)
        {
            if (gridAlteracoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir.");
                return;
            }

            
            string id = gridAlteracoes.SelectedRows[0].Cells["ID"].Value.ToString();
            DialogResult confirm = MessageBox.Show(
                "Tem certeza que deseja excluir este livro?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=livraria;uid=root;pwd=1234;"))
            {
                conn.Open();

                string sqlLista = "DELETE FROM tb_lista WHERE id_livro = @id";
                string sqlEdicoes = "DELETE FROM tb_edicoes WHERE id_livro = @id";
                string sqlLivro = "DELETE FROM tb_livro WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sqlLista, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                using (MySqlCommand cmd = new MySqlCommand(sqlEdicoes, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                using (MySqlCommand cmd = new MySqlCommand(sqlLivro, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Livro excluído com sucesso!");

            // Atualiza a tabela automaticamente
            btnBuscarAlteracao_Click(sender, e);
        }
    }
    }





