namespace Livraria
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbEdicao = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblEdicao = new System.Windows.Forms.Label();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.gbAutor = new System.Windows.Forms.GroupBox();
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.NomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarAutor = new System.Windows.Forms.Button();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.gbLivro = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtValorConsulta = new System.Windows.Forms.TextBox();
            this.lblValorConsulta = new System.Windows.Forms.Label();
            this.cmbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.lblConsultaTipo = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExcluirAlteracao = new System.Windows.Forms.Button();
            this.btnLimparAlteracao = new System.Windows.Forms.Button();
            this.btnAtualizarAlteracao = new System.Windows.Forms.Button();
            this.txtValorBuscaAlteracao = new System.Windows.Forms.TextBox();
            this.btnBuscarAlteracao = new System.Windows.Forms.Button();
            this.lblValorBuscaAlteracao = new System.Windows.Forms.Label();
            this.cmbBuscaAlteracao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAlteracoes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbEdicao.SuspendLayout();
            this.gbAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            this.gbLivro.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlteracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(368, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 790);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Goldenrod;
            this.tabPage1.Controls.Add(this.gbEdicao);
            this.tabPage1.Controls.Add(this.gbAutor);
            this.tabPage1.Controls.Add(this.gbLivro);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Goldenrod;
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 751);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastros";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gbEdicao
            // 
            this.gbEdicao.Controls.Add(this.txtPreco);
            this.gbEdicao.Controls.Add(this.lblpreco);
            this.gbEdicao.Controls.Add(this.lblEditora);
            this.gbEdicao.Controls.Add(this.txtEditora);
            this.gbEdicao.Controls.Add(this.lblAno);
            this.gbEdicao.Controls.Add(this.txtAno);
            this.gbEdicao.Controls.Add(this.lblEdicao);
            this.gbEdicao.Controls.Add(this.txtEdicao);
            this.gbEdicao.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEdicao.Location = new System.Drawing.Point(71, 457);
            this.gbEdicao.Name = "gbEdicao";
            this.gbEdicao.Size = new System.Drawing.Size(803, 226);
            this.gbEdicao.TabIndex = 18;
            this.gbEdicao.TabStop = false;
            this.gbEdicao.Text = "Edição";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.White;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.Black;
            this.txtPreco.Location = new System.Drawing.Point(169, 177);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(548, 34);
            this.txtPreco.TabIndex = 15;
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreco.ForeColor = System.Drawing.Color.Black;
            this.lblpreco.Location = new System.Drawing.Point(36, 181);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(85, 26);
            this.lblpreco.TabIndex = 14;
            this.lblpreco.Text = "Preço:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.ForeColor = System.Drawing.Color.Black;
            this.lblEditora.Location = new System.Drawing.Point(36, 32);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(102, 26);
            this.lblEditora.TabIndex = 8;
            this.lblEditora.Text = "Editora:";
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.Color.White;
            this.txtEditora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.Color.Black;
            this.txtEditora.Location = new System.Drawing.Point(155, 28);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(562, 34);
            this.txtEditora.TabIndex = 9;
            this.txtEditora.TextChanged += new System.EventHandler(this.txtEditora_TextChanged);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.Color.Black;
            this.lblAno.Location = new System.Drawing.Point(36, 80);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(66, 26);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "Ano:";
            this.lblAno.Click += new System.EventHandler(this.lblAno_Click);
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.White;
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.ForeColor = System.Drawing.Color.Black;
            this.txtAno.Location = new System.Drawing.Point(140, 76);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(577, 34);
            this.txtAno.TabIndex = 11;
            // 
            // lblEdicao
            // 
            this.lblEdicao.AutoSize = true;
            this.lblEdicao.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicao.ForeColor = System.Drawing.Color.Black;
            this.lblEdicao.Location = new System.Drawing.Point(36, 132);
            this.lblEdicao.Name = "lblEdicao";
            this.lblEdicao.Size = new System.Drawing.Size(95, 26);
            this.lblEdicao.TabIndex = 12;
            this.lblEdicao.Text = "Edição:";
            this.lblEdicao.Click += new System.EventHandler(this.lblEdicao_Click);
            // 
            // txtEdicao
            // 
            this.txtEdicao.BackColor = System.Drawing.Color.White;
            this.txtEdicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicao.ForeColor = System.Drawing.Color.Black;
            this.txtEdicao.Location = new System.Drawing.Point(169, 128);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(548, 34);
            this.txtEdicao.TabIndex = 13;
            // 
            // gbAutor
            // 
            this.gbAutor.Controls.Add(this.gridAutores);
            this.gbAutor.Controls.Add(this.btnAdicionarAutor);
            this.gbAutor.Controls.Add(this.lblAutor);
            this.gbAutor.Controls.Add(this.txtAutor);
            this.gbAutor.Controls.Add(this.lblNacionalidade);
            this.gbAutor.Controls.Add(this.txtNacionalidade);
            this.gbAutor.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAutor.Location = new System.Drawing.Point(71, 183);
            this.gbAutor.Name = "gbAutor";
            this.gbAutor.Size = new System.Drawing.Size(803, 250);
            this.gbAutor.TabIndex = 17;
            this.gbAutor.TabStop = false;
            this.gbAutor.Text = "Autor";
            // 
            // gridAutores
            // 
            this.gridAutores.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod;
            this.gridAutores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAutores.BackgroundColor = System.Drawing.Color.White;
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAutor,
            this.Nacionalidade});
            this.gridAutores.GridColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gridAutores.Location = new System.Drawing.Point(71, 121);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.ReadOnly = true;
            this.gridAutores.RowHeadersWidth = 51;
            this.gridAutores.RowTemplate.Height = 24;
            this.gridAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAutores.Size = new System.Drawing.Size(646, 106);
            this.gridAutores.TabIndex = 20;
            this.gridAutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAutores_CellContentClick);
            // 
            // NomeAutor
            // 
            this.NomeAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeAutor.HeaderText = "Autor";
            this.NomeAutor.MinimumWidth = 6;
            this.NomeAutor.Name = "NomeAutor";
            this.NomeAutor.ReadOnly = true;
            // 
            // Nacionalidade
            // 
            this.Nacionalidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nacionalidade.HeaderText = "Nacionalidade";
            this.Nacionalidade.MinimumWidth = 6;
            this.Nacionalidade.Name = "Nacionalidade";
            this.Nacionalidade.ReadOnly = true;
            // 
            // btnAdicionarAutor
            // 
            this.btnAdicionarAutor.BackColor = System.Drawing.Color.Black;
            this.btnAdicionarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarAutor.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarAutor.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAdicionarAutor.Location = new System.Drawing.Point(606, 49);
            this.btnAdicionarAutor.Name = "btnAdicionarAutor";
            this.btnAdicionarAutor.Size = new System.Drawing.Size(111, 37);
            this.btnAdicionarAutor.TabIndex = 19;
            this.btnAdicionarAutor.Text = "+ Autor";
            this.btnAdicionarAutor.UseVisualStyleBackColor = false;
            this.btnAdicionarAutor.Click += new System.EventHandler(this.btnAdicionarAtor_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.Black;
            this.lblAutor.Location = new System.Drawing.Point(36, 34);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(87, 26);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            this.lblAutor.Click += new System.EventHandler(this.lblAutor_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.White;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.Black;
            this.txtAutor.Location = new System.Drawing.Point(155, 37);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(427, 34);
            this.txtAutor.TabIndex = 5;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidade.ForeColor = System.Drawing.Color.Black;
            this.lblNacionalidade.Location = new System.Drawing.Point(36, 81);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(182, 26);
            this.lblNacionalidade.TabIndex = 6;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.BackColor = System.Drawing.Color.White;
            this.txtNacionalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidade.ForeColor = System.Drawing.Color.Black;
            this.txtNacionalidade.Location = new System.Drawing.Point(274, 78);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(308, 34);
            this.txtNacionalidade.TabIndex = 7;
            // 
            // gbLivro
            // 
            this.gbLivro.Controls.Add(this.cmbGenero);
            this.gbLivro.Controls.Add(this.lblGenero);
            this.gbLivro.Controls.Add(this.lblTitulo);
            this.gbLivro.Controls.Add(this.txtTitulo);
            this.gbLivro.Controls.Add(this.lblISBN);
            this.gbLivro.Controls.Add(this.txtISBN);
            this.gbLivro.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLivro.Location = new System.Drawing.Point(71, 6);
            this.gbLivro.Name = "gbLivro";
            this.gbLivro.Size = new System.Drawing.Size(803, 171);
            this.gbLivro.TabIndex = 16;
            this.gbLivro.TabStop = false;
            this.gbLivro.Text = "Livro";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(155, 129);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(207, 34);
            this.cmbGenero.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Black;
            this.lblGenero.Location = new System.Drawing.Point(36, 128);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(102, 26);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Gênero:";
            this.lblGenero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(36, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(87, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(155, 31);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(562, 34);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.Black;
            this.lblISBN.Location = new System.Drawing.Point(36, 82);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(74, 26);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.Click += new System.EventHandler(this.lblISBN_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.White;
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.Color.Black;
            this.txtISBN.Location = new System.Drawing.Point(155, 79);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(562, 34);
            this.txtISBN.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnLimpar.Location = new System.Drawing.Point(524, 699);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 32);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSalvar.Location = new System.Drawing.Point(240, 699);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 32);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Goldenrod;
            this.tabPage2.Controls.Add(this.gridResultados);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.txtValorConsulta);
            this.tabPage2.Controls.Add(this.lblValorConsulta);
            this.tabPage2.Controls.Add(this.cmbTipoConsulta);
            this.tabPage2.Controls.Add(this.lblConsultaTipo);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Goldenrod;
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 751);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscas";
            // 
            // gridResultados
            // 
            this.gridResultados.AllowUserToAddRows = false;
            this.gridResultados.AllowUserToDeleteRows = false;
            this.gridResultados.AllowUserToResizeColumns = false;
            this.gridResultados.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            this.gridResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResultados.BackgroundColor = System.Drawing.Color.White;
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Location = new System.Drawing.Point(78, 241);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 51;
            this.gridResultados.RowTemplate.Height = 24;
            this.gridResultados.Size = new System.Drawing.Size(810, 255);
            this.gridResultados.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBuscar.Location = new System.Drawing.Point(554, 148);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 41);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtValorConsulta
            // 
            this.txtValorConsulta.BackColor = System.Drawing.Color.White;
            this.txtValorConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorConsulta.ForeColor = System.Drawing.Color.Black;
            this.txtValorConsulta.Location = new System.Drawing.Point(404, 94);
            this.txtValorConsulta.Name = "txtValorConsulta";
            this.txtValorConsulta.Size = new System.Drawing.Size(394, 34);
            this.txtValorConsulta.TabIndex = 5;
            // 
            // lblValorConsulta
            // 
            this.lblValorConsulta.AutoSize = true;
            this.lblValorConsulta.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConsulta.ForeColor = System.Drawing.Color.Black;
            this.lblValorConsulta.Location = new System.Drawing.Point(73, 102);
            this.lblValorConsulta.Name = "lblValorConsulta";
            this.lblValorConsulta.Size = new System.Drawing.Size(228, 26);
            this.lblValorConsulta.TabIndex = 3;
            this.lblValorConsulta.Text = "Informe o critério:";
            // 
            // cmbTipoConsulta
            // 
            this.cmbTipoConsulta.BackColor = System.Drawing.Color.White;
            this.cmbTipoConsulta.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoConsulta.FormattingEnabled = true;
            this.cmbTipoConsulta.Location = new System.Drawing.Point(554, 25);
            this.cmbTipoConsulta.Name = "cmbTipoConsulta";
            this.cmbTipoConsulta.Size = new System.Drawing.Size(244, 34);
            this.cmbTipoConsulta.TabIndex = 2;
            this.cmbTipoConsulta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoConsulta_SelectedIndexChanged);
            // 
            // lblConsultaTipo
            // 
            this.lblConsultaTipo.AutoSize = true;
            this.lblConsultaTipo.BackColor = System.Drawing.Color.Goldenrod;
            this.lblConsultaTipo.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaTipo.ForeColor = System.Drawing.Color.Black;
            this.lblConsultaTipo.Location = new System.Drawing.Point(73, 33);
            this.lblConsultaTipo.Name = "lblConsultaTipo";
            this.lblConsultaTipo.Size = new System.Drawing.Size(400, 26);
            this.lblConsultaTipo.TabIndex = 1;
            this.lblConsultaTipo.Text = "Escolha o tipo de busca desejada:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tabPage3.Controls.Add(this.btnExcluirAlteracao);
            this.tabPage3.Controls.Add(this.btnLimparAlteracao);
            this.tabPage3.Controls.Add(this.btnAtualizarAlteracao);
            this.tabPage3.Controls.Add(this.txtValorBuscaAlteracao);
            this.tabPage3.Controls.Add(this.btnBuscarAlteracao);
            this.tabPage3.Controls.Add(this.lblValorBuscaAlteracao);
            this.tabPage3.Controls.Add(this.cmbBuscaAlteracao);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.gridAlteracoes);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.Color.Goldenrod;
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(970, 751);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alterações";
            // 
            // btnExcluirAlteracao
            // 
            this.btnExcluirAlteracao.BackColor = System.Drawing.Color.Black;
            this.btnExcluirAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirAlteracao.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnExcluirAlteracao.Location = new System.Drawing.Point(637, 461);
            this.btnExcluirAlteracao.Name = "btnExcluirAlteracao";
            this.btnExcluirAlteracao.Size = new System.Drawing.Size(128, 37);
            this.btnExcluirAlteracao.TabIndex = 8;
            this.btnExcluirAlteracao.Text = "Excluir";
            this.btnExcluirAlteracao.UseVisualStyleBackColor = false;
            this.btnExcluirAlteracao.Click += new System.EventHandler(this.btnExcluirAlteracao_Click);
            // 
            // btnLimparAlteracao
            // 
            this.btnLimparAlteracao.BackColor = System.Drawing.Color.Black;
            this.btnLimparAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparAlteracao.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnLimparAlteracao.Location = new System.Drawing.Point(393, 461);
            this.btnLimparAlteracao.Name = "btnLimparAlteracao";
            this.btnLimparAlteracao.Size = new System.Drawing.Size(128, 37);
            this.btnLimparAlteracao.TabIndex = 7;
            this.btnLimparAlteracao.Text = "Limpar";
            this.btnLimparAlteracao.UseVisualStyleBackColor = false;
            this.btnLimparAlteracao.Click += new System.EventHandler(this.btnLimparAlteracao_Click);
            // 
            // btnAtualizarAlteracao
            // 
            this.btnAtualizarAlteracao.BackColor = System.Drawing.Color.Black;
            this.btnAtualizarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarAlteracao.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAtualizarAlteracao.Location = new System.Drawing.Point(146, 461);
            this.btnAtualizarAlteracao.Name = "btnAtualizarAlteracao";
            this.btnAtualizarAlteracao.Size = new System.Drawing.Size(140, 37);
            this.btnAtualizarAlteracao.TabIndex = 6;
            this.btnAtualizarAlteracao.Text = "Atualizar";
            this.btnAtualizarAlteracao.UseVisualStyleBackColor = false;
            this.btnAtualizarAlteracao.Click += new System.EventHandler(this.btnAtualizarAlteracao_Click);
            // 
            // txtValorBuscaAlteracao
            // 
            this.txtValorBuscaAlteracao.Location = new System.Drawing.Point(451, 103);
            this.txtValorBuscaAlteracao.Name = "txtValorBuscaAlteracao";
            this.txtValorBuscaAlteracao.Size = new System.Drawing.Size(254, 34);
            this.txtValorBuscaAlteracao.TabIndex = 5;
            this.txtValorBuscaAlteracao.TextChanged += new System.EventHandler(this.txtValorBuscaAlteracao_TextChanged);
            this.txtValorBuscaAlteracao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorBuscaAlteracao_KeyPress);
            // 
            // btnBuscarAlteracao
            // 
            this.btnBuscarAlteracao.BackColor = System.Drawing.Color.Black;
            this.btnBuscarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarAlteracao.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBuscarAlteracao.Location = new System.Drawing.Point(739, 102);
            this.btnBuscarAlteracao.Name = "btnBuscarAlteracao";
            this.btnBuscarAlteracao.Size = new System.Drawing.Size(110, 37);
            this.btnBuscarAlteracao.TabIndex = 4;
            this.btnBuscarAlteracao.Text = "Buscar";
            this.btnBuscarAlteracao.UseVisualStyleBackColor = false;
            this.btnBuscarAlteracao.Click += new System.EventHandler(this.btnBuscarAlteracao_Click);
            // 
            // lblValorBuscaAlteracao
            // 
            this.lblValorBuscaAlteracao.AutoSize = true;
            this.lblValorBuscaAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBuscaAlteracao.ForeColor = System.Drawing.Color.Black;
            this.lblValorBuscaAlteracao.Location = new System.Drawing.Point(100, 106);
            this.lblValorBuscaAlteracao.Name = "lblValorBuscaAlteracao";
            this.lblValorBuscaAlteracao.Size = new System.Drawing.Size(333, 29);
            this.lblValorBuscaAlteracao.TabIndex = 3;
            this.lblValorBuscaAlteracao.Text = "Digite o que deseja buscar:";
            // 
            // cmbBuscaAlteracao
            // 
            this.cmbBuscaAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscaAlteracao.FormattingEnabled = true;
            this.cmbBuscaAlteracao.Items.AddRange(new object[] {
            "Título",
            "Autor",
            "Editora ",
            "ISBN",
            "Preço "});
            this.cmbBuscaAlteracao.Location = new System.Drawing.Point(261, 38);
            this.cmbBuscaAlteracao.Name = "cmbBuscaAlteracao";
            this.cmbBuscaAlteracao.Size = new System.Drawing.Size(260, 37);
            this.cmbBuscaAlteracao.TabIndex = 2;
            this.cmbBuscaAlteracao.SelectedIndexChanged += new System.EventHandler(this.cmbBuscaAlteracao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por:";
            // 
            // gridAlteracoes
            // 
            this.gridAlteracoes.AllowUserToAddRows = false;
            this.gridAlteracoes.AllowUserToDeleteRows = false;
            this.gridAlteracoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridAlteracoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridAlteracoes.BackgroundColor = System.Drawing.Color.White;
            this.gridAlteracoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlteracoes.Location = new System.Drawing.Point(105, 159);
            this.gridAlteracoes.Name = "gridAlteracoes";
            this.gridAlteracoes.RowHeadersWidth = 51;
            this.gridAlteracoes.RowTemplate.Height = 24;
            this.gridAlteracoes.Size = new System.Drawing.Size(744, 269);
            this.gridAlteracoes.TabIndex = 0;
            this.gridAlteracoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlteracoes_CellContentClick);
            this.gridAlteracoes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlteracoes_CellEndEdit);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Livraria.Properties.Resources.WhatsApp_Image_2025_12_02_at_20_13_20_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1358, 829);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbEdicao.ResumeLayout(false);
            this.gbEdicao.PerformLayout();
            this.gbAutor.ResumeLayout(false);
            this.gbAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            this.gbLivro.ResumeLayout(false);
            this.gbLivro.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlteracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label lblEdicao;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbLivro;
        private System.Windows.Forms.GroupBox gbAutor;
        private System.Windows.Forms.GroupBox gbEdicao;
        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.Button btnAdicionarAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidade;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblConsultaTipo;
        private System.Windows.Forms.ComboBox cmbTipoConsulta;
        private System.Windows.Forms.Label lblValorConsulta;
        private System.Windows.Forms.TextBox txtValorConsulta;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridAlteracoes;
        private System.Windows.Forms.Label lblValorBuscaAlteracao;
        private System.Windows.Forms.ComboBox cmbBuscaAlteracao;
        private System.Windows.Forms.TextBox txtValorBuscaAlteracao;
        private System.Windows.Forms.Button btnBuscarAlteracao;
        private System.Windows.Forms.Button btnAtualizarAlteracao;
        private System.Windows.Forms.Button btnLimparAlteracao;
        private System.Windows.Forms.Button btnExcluirAlteracao;
    }
}