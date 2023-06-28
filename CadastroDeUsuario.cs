using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroUsuaio
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

         void btnCadastrar_Click(object sender, EventArgs e)
        {
            using System.Data.SqlClient;

// classe para representar as informações do cadastro
public class Cadastro
 {     
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
}

//função para salvar o cadastro no banco de dados
public void SalvarCadastro(Cadastro cadastro)
{
    // informações de conexão com o banco de dados
    string connectionString = "Data Source=nome_servidor;Initial Catalog=nome_banco_dados;User ID=usuario;Password=senha;";
    using (SqlConnection connection = new SqlConnection(connectionString)) 
    {
        // conexão com o banco de dados
        connection.Open();

        // comando SQL que insere as informações do cadastro na tabela do banco de dados
        string query = "INSERT INTO cadastros (nome, email, telefone) VALUES (@Nome, @Email, @Telefone)";
        using (SqlCommand command = new SqlCommand(query, connection)) 
        {
            // parâmetros do comando SQL com as informações do cadastro
            command.Parameters.AddWithValue("@Nome", cadastro.Nome);
            command.Parameters.AddWithValue("@Email", cadastro.Email);
            command.Parameters.AddWithValue("@Telefone", cadastro.Telefone);

            // comando SQL
            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine("Linhas afetadas: " + rowsAffected);
        }
    }
}

            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }

            // Código para salvar as informações do cadastro

            MessageBox.Show("Cadastro realizado com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }
    }
}
