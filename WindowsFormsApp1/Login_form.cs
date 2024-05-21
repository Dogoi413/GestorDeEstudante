using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
           
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();
            DataTable minhaTabela = new DataTable(); 
            MySqlCommand meuComandoSql = new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario` = @usuario and `senha` = @senha", meuBancoDeDados.getConexao);
            meuComandoSql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = textBox2.Text;
            meuComandoSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBox3.Text;

            meuAdaptadorSql.SelectCommand = meuComandoSql;

            meuAdaptadorSql.Fill(minhaTabela);

            if (minhaTabela.Rows.Count > 0)
            {
                MessageBox.Show("existem dados");
            }
            else
            {
                MessageBox.Show("usuario ou senha incorretos", "erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
