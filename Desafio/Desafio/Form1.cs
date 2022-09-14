using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace Desafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlCommand cm = new SqlCommand();

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-T3ACV1N\SQLEXPRESS;integrated security=SSPI;Database=cliente");

        SqlDataReader dt;
        

        private void desabilitaCampos()
        {   //dados cadastrais
            label_ID.Enabled = false;
            txt_Codigo.Enabled = false;
            txt_Nome.Enabled = false;
            txt_NomeFant.Enabled = false;
            cb_Tipo.Enabled = false;
            txt_CPF.Enabled = false;
            txt_RG.Enabled = false;
            txt_Email.Enabled = false;
            txt_Telefone.Enabled = false;
            //campos de endereço
            txt_CEP.Enabled = false;
            txt_Logradouro.Enabled = false;
            txt_Numero.Enabled = false;
            txt_Complemento.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_Municipio.Enabled = false;
            cb_UF.Enabled = false;
            //botões
            btn_Salvar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Remover.Enabled = false;
            btn_Cancelar.Enabled = false;
        }

        private void habilitaCampos()
        {
            txt_Codigo.Enabled = true;
            txt_Nome.Enabled = true;
            txt_NomeFant.Enabled = true;
            cb_Tipo.Enabled = true;
            txt_CPF.Enabled = true;
            txt_RG.Enabled = true;
            txt_Email.Enabled = true;
            txt_Telefone.Enabled = true;
            //campos de endereço
            txt_CEP.Enabled = true;
            txt_Logradouro.Enabled = true;
            txt_Numero.Enabled = true;
            txt_Complemento.Enabled = true;
            txt_Bairro.Enabled = true;
            txt_Municipio.Enabled = true;
            cb_UF.Enabled = true;
            //botões
            btn_Cadastrar.Enabled = true;
            btn_Salvar.Enabled = true;
            btn_Cancelar.Enabled = true;
            txt_Nome.Focus();
        }

        private void limparCampos()
        {
            txt_Codigo.Clear();
            txt_Nome.Clear();
            txt_NomeFant.Clear();
            cb_Tipo.Text = "";
            txt_CPF.Clear();
            txt_RG.Clear();
            txt_Email.Clear();
            txt_Telefone.Clear();
            //campos de endereço
            txt_CEP.Clear();
            txt_Logradouro.Clear();
            txt_Numero.Clear();
            txt_Complemento.Clear();
            txt_Bairro.Clear();
            txt_Municipio.Clear();
            cb_UF.Text = "";

        }

        private void listarGrid()
        {
            try
            {
                cn.Open();
                cm.CommandText = "select id as ID,codigo as Código,nome as Nome,nomeFantasia as [Nome Fantasia],rg as RG,cpf as CPF,tipo as [Tipo(PF/PJ)],email as Email ,telefone as Telefone,cep as CEP,logradouro as Logradouro,numero as Número,bairro as Bairro,municipio as Município,complemento as Complemento,unidadeFederativa as [Unidade Federativa(UF)],inclusao as [Dt Inclusão],alteracao as [Dt Alteração] from dbo.clientes where bloqueado = 0";
                cm.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = cm;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                cn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
            listarGrid();

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            limparCampos();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "")
            {
                MessageBox.Show("O campo 'Nome' é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_CPF.Text == "")
            {
                MessageBox.Show("Por favor, preencha o CPF/CNPJ.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_CPF.Text.Length > 11)
            {
                MessageBox.Show("CPF Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (cb_Tipo.Text == "")
            {
                MessageBox.Show("Você deve informar o tipo de cliente que será cadastrado (PF/PJ).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_RG.Text == "")
            {
                MessageBox.Show("Para concluir o cadastro, deve-se inserir o RG do Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_RG.Text.Length > 13)
            {
                MessageBox.Show("N° de RG inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_Email.Text == "")
            {
                MessageBox.Show("Para concluir o cadastro, deve-se inserir o Email do Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_Telefone.Text == "")
            {
                MessageBox.Show("Para concluir o cadastro, deve-se inserir o n° de telefone do Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //se os dados de endereço estiverem nulos

            else if (txt_CEP.Text == "")
            {
                MessageBox.Show("Para concluir o cadastro, deve-se inserir o CEP do Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try {
                    // dados cadastrais
                    int id = Convert.ToInt32(label_ID.Text);
                    string codigo = txt_Codigo.Text;
                    string nome = txt_Nome.Text;
                    string nomeFantasia = txt_NomeFant.Text;
                    string cpf = txt_CPF.Text;
                    string email = txt_Email.Text;
                    string telefone = txt_Telefone.Text;
                    string rg = txt_RG.Text;
                    string tipo = cb_Tipo.Text;


                    //endereço

                    string cep = txt_CEP.Text;
                    string logradouro = txt_Logradouro.Text;
                    string bairro = txt_Bairro.Text;
                    string municipio = txt_Municipio.Text;
                    string complemento = txt_Complemento.Text;
                    string uf = cb_UF.Text;
                    string numero = txt_Numero.Text;




                    string strSql = "update dbo.clientes set codigo = @codigo, nome = @nome, nomeFantasia = @nomeFantasia, cpf = @cpf, email = @email, telefone = @telefone, rg = @rg, tipo = @tipo, cep = @cep, logradouro = @logradouro, bairro = @bairro, municipio = @municipio, complemento = @complemento, unidadeFederativa = @uf, numero = @numero, alteracao = GETDATE() where id = @id";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cm.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@nomeFantasia", SqlDbType.VarChar).Value = nomeFantasia;
                    cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    cm.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                    cm.Parameters.Add("@rg", SqlDbType.VarChar).Value = rg;
                    cm.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo;


                    cm.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
                    cm.Parameters.Add("@logradouro", SqlDbType.VarChar).Value = logradouro;
                    cm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
                    cm.Parameters.Add("@municipio", SqlDbType.VarChar).Value = municipio;
                    cm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
                    cm.Parameters.Add("@uf", SqlDbType.VarChar).Value = uf;
                    cm.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero;

                    cm.Connection = cn;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Os dados foram alterados com sucesso!", "Alteração Concluída.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limparCampos();





                }
                
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }

                finally
                {
                    cn.Close();
                }

            }
            
               


        }

        private void manipulaDado()
        {
            btn_Editar.Enabled = true;
            btn_Cancelar.Enabled = true;
            btn_Cadastrar.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Remover.Enabled = true;
           

            txt_Codigo.Enabled = true;
            txt_Nome.Enabled = true;
            txt_NomeFant.Enabled = true;
            cb_Tipo.Enabled = true;
            txt_CPF.Enabled = true;
            txt_RG.Enabled = true;
            txt_Email.Enabled = true;
            txt_Telefone.Enabled = true;
            //campos de endereço
            txt_CEP.Enabled = true;
            txt_Logradouro.Enabled = true;
            txt_Numero.Enabled = true;
            txt_Complemento.Enabled = true;
            txt_Bairro.Enabled = true;
            txt_Municipio.Enabled = true;
            cb_UF.Enabled = true;
    
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //se os dados cadastrais estiverem nulos ao salvar

            if (txt_Nome.Text == ""){
                MessageBox.Show("O campo 'Nome' é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_CPF.Text == "")
            {
                MessageBox.Show("Por favor, preencha o CPF/CNPJ.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_CPF.Text.Length > 11)
            {
                MessageBox.Show("CPF Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (cb_Tipo.Text == "")
            {
                MessageBox.Show("Você deve informar o tipo de cliente que será cadastrado (PF/PJ).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_RG.Text == "")
            {
                MessageBox.Show("Para concluir o cadastro, deve-se inserir o RG do Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_RG.Text.Length > 13)
            {
                MessageBox.Show("N° de RG inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_Email.Text == "")
            {
                MessageBox.Show("Para concluir o cadastro, deve-se inserir o Email do Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_Telefone.Text == "")
            {
                MessageBox.Show("Para concluir o cadastro, deve-se inserir o n° de telefone do Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //se os dados de endereço estiverem nulos

            else if (txt_CEP.Text == "")
            {
                MessageBox.Show("Para concluir o cadastro, deve-se inserir o CEP do Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try { 
                // dados cadastrais
                string codigo = txt_Codigo.Text;
                string nome = txt_Nome.Text;
                string nomeFantasia = txt_NomeFant.Text;
                string cpf = txt_CPF.Text;
                string email = txt_Email.Text;
                string telefone = txt_Telefone.Text;
                string rg = txt_RG.Text;
                string tipo = cb_Tipo.Text;


                //endereço

                string cep = txt_CEP.Text;
                string logradouro = txt_Logradouro.Text;
                string bairro = txt_Bairro.Text;
                string municipio = txt_Municipio.Text;
                string complemento = txt_Complemento.Text;
                string uf = cb_UF.Text;
                string numero = txt_Numero.Text;
                

                

                string strSql = "insert into dbo.clientes(codigo, nome, nomeFantasia , cpf, email, telefone, rg, tipo, cep, logradouro, bairro, municipio, complemento, unidadeFederativa, numero,bloqueado,inclusao,alteracao) values(@codigo, @nome, @nomeFantasia , @cpf, @email, @telefone, @rg, @tipo, @cep, @logradouro, @bairro, @municipio, @complemento, @uf, @numero,0,GETDATE(),GETDATE())";

                cm.CommandText = strSql;
                cm.Connection = cn;

                cm.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cm.Parameters.Add("@nomeFantasia", SqlDbType.VarChar).Value = nomeFantasia;
                cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                cm.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                cm.Parameters.Add("@rg", SqlDbType.VarChar).Value = rg;
                cm.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo;
             

                cm.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
                cm.Parameters.Add("@logradouro", SqlDbType.VarChar).Value = logradouro;
                cm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
                cm.Parameters.Add("@municipio", SqlDbType.VarChar).Value = municipio;
                cm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
                cm.Parameters.Add("@uf", SqlDbType.VarChar).Value = uf;
                cm.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero;

                cm.Connection = cn;
                cn.Open();
                cm.ExecuteNonQuery();
                cm.Parameters.Clear();
                MessageBox.Show("Cliente cadastrado com sucesso!","Cadastro concluído.",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limparCampos();
                dataGridView1.Refresh();
                
                 



                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cm.Parameters.Clear();
                    cn.Close();
                }

                finally
                {
                    cm.Parameters.Clear();
                    cn.Close();
                }

            }





        }

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txt_pesquisa.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select id as ID,codigo as Código,nome as Nome,nomeFantasia as [Nome Fantasia],rg as RG,cpf as CPF,tipo as [Tipo(PF/PJ)],email as Email ,telefone as Telefone,cep as CEP,logradouro as Logradouro,numero as Número,bairro as Bairro,municipio as Município,complemento as Complemento,unidadeFederativa as [Unidade Federativa(UF)],inclusao as [Dt Inclusão],alteracao as [Dt Alteração] from dbo.clientes where bloqueado = 0 and dbo.clientes.nome like ('%" + txt_pesquisa.Text + "%') and bloqueado = 0 or dbo.clientes.codigo like ('%" + txt_pesquisa.Text + "%') and bloqueado = 0 or dbo.clientes.cpf like ('%" + txt_pesquisa.Text + "%') and bloqueado = 0";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cn.Close();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

                
            }

            else
            {

                try
                {
                    cn.Open();
                    cm.CommandText = "select id as ID,codigo as Código,nome as Nome,nomeFantasia as [Nome Fantasia],rg as RG,cpf as CPF,tipo as [Tipo(PF/PJ)],email as Email ,telefone as Telefone,cep as CEP,logradouro as Logradouro,numero as Número,bairro as Bairro,municipio as Município,complemento as Complemento,unidadeFederativa as [Unidade Federativa(UF)],inclusao as [Dt Inclusão],alteracao as [Dt Alteração] from dbo.clientes where bloqueado = 0";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                
            }
        }

        private void carregarCliente()
        {
            label_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_Codigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_Nome.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_NomeFant.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_RG.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_CPF.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cb_Tipo.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txt_Email.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txt_Telefone.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

            txt_CEP.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txt_Logradouro.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txt_Numero.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txt_Bairro.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            txt_Municipio.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            txt_Complemento.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            cb_UF.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();


            manipulaDado();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarCliente();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "")
            {
                MessageBox.Show("Para remover o registro, o campo 'Nome' não pode ser nulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_CPF.Text == "")
            {
                MessageBox.Show("Para remover o registro, o CPF/CNPJ não pode ser nulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_CPF.Text.Length > 11)
            {
                MessageBox.Show("CPF Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (cb_Tipo.Text == "")
            {
                MessageBox.Show("Para remover o registro, deve estar preenchido o campo com o tipo de cliente cadastrado (PF/PJ).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_RG.Text == "")
            {
                MessageBox.Show("Para remover o registro, o RG do cliente não pode ser nulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_RG.Text.Length > 13)
            {
                MessageBox.Show("N° de RG inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_Email.Text == "")
            {
                MessageBox.Show("Para remover o registro, o Email do cliente deve estar preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_Telefone.Text == "")
            {
                MessageBox.Show("Para remover o registro, o n° de telefone do cliente deverá estar preenchido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //se os dados de endereço estiverem nulos

            else if (txt_CEP.Text == "")
            {
                MessageBox.Show("Para remover o registro, o CEP do cliente deve estar preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover os registros?", "Exclusão de Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int id = Convert.ToInt32(label_ID.Text);


                        cn.Open();
                        string strSql = "update dbo.clientes set bloqueado = 1  where id = @id";

                        cm.CommandText = strSql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Dados excluídos com sucesso!", "Exclusão concluída.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limparCampos();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }

                    finally
                    {
                        cn.Close();
                    }
                }
            }

        }
    }
}