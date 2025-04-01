using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = textBox1.Text;
                string senha = textBox2.Text;
                string confirmarSenha = textBox3.Text;

                if (usuario != "" && senha != "" && senha == confirmarSenha)
                {
                    string conexaoBanco = "Server=localhost; Database=sistemaLogin; Uid=root; pwd=''";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                    conexao.Open();

                    string cadastroUsuario = "insert into usuarios (usuario, senha) values (@usuario, @senha)";

                    MySqlCommand comandoSql = new MySqlCommand(cadastroUsuario, conexao);

                    comandoSql.Parameters.AddWithValue("@usuario", usuario);
                    comandoSql.Parameters.AddWithValue("@senha", senha);

                    int linhasAfetadas = comandoSql.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente e confirme a senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao realizar cadastro" + ex.Message);
            }
        }
    }
}
