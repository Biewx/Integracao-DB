using MySql.Data.MySqlClient;

namespace Database
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = textBox1.Text;
                string senha = textBox2.Text;

                if (usuario != "" && senha != "")
                {
                    string conexaoBanco = "Server=localhost; Database=sistemaLogin; Uid=root; pwd=''";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                    conexao.Open();

                    string consultaUsuario = "select * from usuarios where usuario = @usuario and senha = @senha ";

                    MySqlCommand comandoSql = new MySqlCommand(consultaUsuario, conexao);

                    comandoSql.Parameters.AddWithValue("@usuario", usuario);
                    comandoSql.Parameters.AddWithValue("@senha", senha);

                    int registro = Convert.ToInt32(comandoSql.ExecuteScalar());

                    if (registro > 0)
                    {
                        MessageBox.Show("Login bem sucedido!!");
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha não encontrados");
                    }
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Preencha os campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login" + ex.Message);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro telaCadastro = new Cadastro();
            telaCadastro.Show();
            this.Hide();



        }
    }
}
