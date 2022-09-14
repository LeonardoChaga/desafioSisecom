namespace Desafio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Rg = new System.Windows.Forms.Label();
            this.lbl_Nome2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_Complemento = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_Municipio = new System.Windows.Forms.Label();
            this.lbl_UF = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_NomeFant = new System.Windows.Forms.TextBox();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_CEP = new System.Windows.Forms.TextBox();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Complemento = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Municipio = new System.Windows.Forms.TextBox();
            this.cb_UF = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupbox_Pesquisa = new System.Windows.Forms.GroupBox();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_ID = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupbox_Pesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.MediumPurple;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 130);
            this.panel1.TabIndex = 0;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(1247, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(30, 30);
            this.btn_Fechar.TabIndex = 1;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(360, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Id.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Id.Location = new System.Drawing.Point(505, 159);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(31, 21);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Id:";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Codigo.Location = new System.Drawing.Point(12, 159);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(70, 21);
            this.lbl_Codigo.TabIndex = 2;
            this.lbl_Codigo.Text = "Codigo:";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tipo.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Tipo.Location = new System.Drawing.Point(39, 277);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(109, 21);
            this.lbl_Tipo.TabIndex = 3;
            this.lbl_Tipo.Text = "Tipo(PF/PJ):";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Nome.Location = new System.Drawing.Point(39, 199);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(167, 21);
            this.lbl_Nome.TabIndex = 4;
            this.lbl_Nome.Text = "Nome/Razão Social:";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cpf.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Cpf.Location = new System.Drawing.Point(39, 317);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(93, 21);
            this.lbl_Cpf.TabIndex = 5;
            this.lbl_Cpf.Text = "CPF/CNPJ:";
            // 
            // lbl_Rg
            // 
            this.lbl_Rg.AutoSize = true;
            this.lbl_Rg.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Rg.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Rg.Location = new System.Drawing.Point(39, 355);
            this.lbl_Rg.Name = "lbl_Rg";
            this.lbl_Rg.Size = new System.Drawing.Size(61, 21);
            this.lbl_Rg.TabIndex = 6;
            this.lbl_Rg.Text = "RG/IE:";
            // 
            // lbl_Nome2
            // 
            this.lbl_Nome2.AutoSize = true;
            this.lbl_Nome2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome2.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Nome2.Location = new System.Drawing.Point(39, 237);
            this.lbl_Nome2.Name = "lbl_Nome2";
            this.lbl_Nome2.Size = new System.Drawing.Size(272, 21);
            this.lbl_Nome2.TabIndex = 7;
            this.lbl_Nome2.Text = "Nome Abreviado/Nome Fantasia:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Location = new System.Drawing.Point(603, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 351);
            this.panel2.TabIndex = 8;
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Endereco.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Endereco.Location = new System.Drawing.Point(916, 133);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(82, 21);
            this.lbl_Endereco.TabIndex = 9;
            this.lbl_Endereco.Text = "Endereço";
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cep.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Cep.Location = new System.Drawing.Point(666, 163);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(44, 21);
            this.lbl_Cep.TabIndex = 10;
            this.lbl_Cep.Text = "CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(666, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Logradouro:";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_num.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_num.Location = new System.Drawing.Point(666, 237);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(79, 21);
            this.lbl_num.TabIndex = 12;
            this.lbl_num.Text = "Número:";
            // 
            // lbl_Complemento
            // 
            this.lbl_Complemento.AutoSize = true;
            this.lbl_Complemento.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Complemento.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Complemento.Location = new System.Drawing.Point(666, 277);
            this.lbl_Complemento.Name = "lbl_Complemento";
            this.lbl_Complemento.Size = new System.Drawing.Size(125, 21);
            this.lbl_Complemento.TabIndex = 13;
            this.lbl_Complemento.Text = "Complemento:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bairro.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_bairro.Location = new System.Drawing.Point(666, 317);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(64, 21);
            this.lbl_bairro.TabIndex = 14;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // lbl_Municipio
            // 
            this.lbl_Municipio.AutoSize = true;
            this.lbl_Municipio.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Municipio.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Municipio.Location = new System.Drawing.Point(666, 355);
            this.lbl_Municipio.Name = "lbl_Municipio";
            this.lbl_Municipio.Size = new System.Drawing.Size(94, 21);
            this.lbl_Municipio.TabIndex = 15;
            this.lbl_Municipio.Text = "Município:";
            // 
            // lbl_UF
            // 
            this.lbl_UF.AutoSize = true;
            this.lbl_UF.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UF.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_UF.Location = new System.Drawing.Point(666, 394);
            this.lbl_UF.Name = "lbl_UF";
            this.lbl_UF.Size = new System.Drawing.Size(167, 21);
            this.lbl_UF.TabIndex = 16;
            this.lbl_UF.Text = "Unidade Federativa:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_email.Location = new System.Drawing.Point(39, 394);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(58, 21);
            this.lbl_email.TabIndex = 17;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Telefone.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_Telefone.Location = new System.Drawing.Point(39, 429);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(84, 21);
            this.lbl_Telefone.TabIndex = 18;
            this.lbl_Telefone.Text = "Telefone:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(212, 201);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(188, 23);
            this.txt_Nome.TabIndex = 19;
            // 
            // txt_NomeFant
            // 
            this.txt_NomeFant.Location = new System.Drawing.Point(317, 239);
            this.txt_NomeFant.Name = "txt_NomeFant";
            this.txt_NomeFant.Size = new System.Drawing.Size(219, 23);
            this.txt_NomeFant.TabIndex = 20;
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Items.AddRange(new object[] {
            "PF",
            "PJ"});
            this.cb_Tipo.Location = new System.Drawing.Point(154, 279);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(121, 23);
            this.cb_Tipo.TabIndex = 21;
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(154, 317);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(219, 23);
            this.txt_CPF.TabIndex = 22;
            // 
            // txt_RG
            // 
            this.txt_RG.Location = new System.Drawing.Point(154, 357);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(219, 23);
            this.txt_RG.TabIndex = 23;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(154, 396);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(219, 23);
            this.txt_Email.TabIndex = 24;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(154, 431);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(219, 23);
            this.txt_Telefone.TabIndex = 25;
            // 
            // txt_CEP
            // 
            this.txt_CEP.Location = new System.Drawing.Point(797, 161);
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(212, 23);
            this.txt_CEP.TabIndex = 26;
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Location = new System.Drawing.Point(797, 199);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(212, 23);
            this.txt_Logradouro.TabIndex = 27;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(797, 239);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(135, 23);
            this.txt_Numero.TabIndex = 28;
            // 
            // txt_Complemento
            // 
            this.txt_Complemento.Location = new System.Drawing.Point(797, 279);
            this.txt_Complemento.Name = "txt_Complemento";
            this.txt_Complemento.Size = new System.Drawing.Size(212, 23);
            this.txt_Complemento.TabIndex = 29;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(797, 319);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(212, 23);
            this.txt_Bairro.TabIndex = 30;
            // 
            // txt_Municipio
            // 
            this.txt_Municipio.Location = new System.Drawing.Point(797, 357);
            this.txt_Municipio.Name = "txt_Municipio";
            this.txt_Municipio.Size = new System.Drawing.Size(212, 23);
            this.txt_Municipio.TabIndex = 31;
            // 
            // cb_UF
            // 
            this.cb_UF.FormattingEnabled = true;
            this.cb_UF.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cb_UF.Location = new System.Drawing.Point(839, 396);
            this.cb_UF.Name = "cb_UF";
            this.cb_UF.Size = new System.Drawing.Size(121, 23);
            this.cb_UF.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(318, 561);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(586, 147);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(212, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Dados Cadastrais";
            // 
            // groupbox_Pesquisa
            // 
            this.groupbox_Pesquisa.Controls.Add(this.txt_pesquisa);
            this.groupbox_Pesquisa.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupbox_Pesquisa.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupbox_Pesquisa.Location = new System.Drawing.Point(318, 494);
            this.groupbox_Pesquisa.Name = "groupbox_Pesquisa";
            this.groupbox_Pesquisa.Size = new System.Drawing.Size(586, 61);
            this.groupbox_Pesquisa.TabIndex = 35;
            this.groupbox_Pesquisa.TabStop = false;
            this.groupbox_Pesquisa.Text = "Pesquisar Clientes";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(25, 28);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(530, 29);
            this.txt_pesquisa.TabIndex = 36;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.Location = new System.Drawing.Point(1150, 134);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(90, 40);
            this.btn_Cadastrar.TabIndex = 36;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Salvar.FlatAppearance.BorderSize = 0;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salvar.Location = new System.Drawing.Point(1150, 201);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(90, 40);
            this.btn_Salvar.TabIndex = 37;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.Location = new System.Drawing.Point(1150, 272);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(90, 40);
            this.btn_Editar.TabIndex = 38;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Remover.FlatAppearance.BorderSize = 0;
            this.btn_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remover.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Remover.Location = new System.Drawing.Point(1150, 340);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(90, 40);
            this.btn_Remover.TabIndex = 39;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(1150, 412);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(90, 40);
            this.btn_Cancelar.TabIndex = 40;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Location = new System.Drawing.Point(0, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1308, 13);
            this.panel3.TabIndex = 41;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ID.ForeColor = System.Drawing.Color.MediumPurple;
            this.label_ID.Location = new System.Drawing.Point(542, 159);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(0, 21);
            this.label_ID.TabIndex = 42;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(88, 161);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(87, 23);
            this.txt_Codigo.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.groupbox_Pesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_UF);
            this.Controls.Add(this.txt_Municipio);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.txt_Complemento);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.txt_Logradouro);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.txt_NomeFant);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_UF);
            this.Controls.Add(this.lbl_Municipio);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_Complemento);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Cep);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_Nome2);
            this.Controls.Add(this.lbl_Rg);
            this.Controls.Add(this.lbl_Cpf);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupbox_Pesquisa.ResumeLayout(false);
            this.groupbox_Pesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btn_Fechar;
        private Label label1;
        private Label lbl_Id;
        private Label lbl_Codigo;
        private Label lbl_Tipo;
        private Label lbl_Nome;
        private Label lbl_Cpf;
        private Label lbl_Rg;
        private Label lbl_Nome2;
        private Panel panel2;
        private Label lbl_Endereco;
        private Label lbl_Cep;
        private Label label2;
        private Label lbl_num;
        private Label lbl_Complemento;
        private Label lbl_bairro;
        private Label lbl_Municipio;
        private Label lbl_UF;
        private Label lbl_email;
        private Label lbl_Telefone;
        private TextBox txt_Nome;
        private TextBox txt_NomeFant;
        private ComboBox cb_Tipo;
        private TextBox txt_CPF;
        private TextBox txt_RG;
        private TextBox txt_Email;
        private TextBox txt_Telefone;
        private TextBox txt_CEP;
        private TextBox txt_Logradouro;
        private TextBox txt_Numero;
        private TextBox txt_Complemento;
        private TextBox txt_Bairro;
        private TextBox txt_Municipio;
        private ComboBox cb_UF;
        private DataGridView dataGridView1;
        private Label label3;
        private GroupBox groupbox_Pesquisa;
        private TextBox txt_pesquisa;
        private Button btn_Cadastrar;
        private Button btn_Salvar;
        private Button btn_Editar;
        private Button btn_Remover;
        private Button btn_Cancelar;
        private Panel panel3;
        private Label label_ID;
        private TextBox txt_Codigo;
    }
}