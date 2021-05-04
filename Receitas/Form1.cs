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

namespace Receitas
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=receitas;Uid=root;Pwd=110688;");
                strSQL = "INSERT INTO " +
                    "receitas (NOME, DESCRICAO, tempo_preparacao, grau_dificuldade, numero_pressoas, categoria) " +
                    "values (@NOME, @DESCRICAO,@tempo_preparacao, @grau_dificuldade, @numero_pressoas, @categoria)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", textBoxNome.Text);
                comando.Parameters.AddWithValue("@DESCRICAO", richTextBoxDesc.Text);
                comando.Parameters.AddWithValue("@tempo_preparacao", textBoxTempoPrep.Text);
                comando.Parameters.AddWithValue("@grau_dificuldade", cBGrauDificuldade.Text);
                comando.Parameters.AddWithValue("@numero_pressoas", cBNumeroPessoas.Text);
                comando.Parameters.AddWithValue("@categoria", cBCategoria.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }
    }
}
