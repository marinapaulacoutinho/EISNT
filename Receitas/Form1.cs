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
        string strSQLSelect;


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
                conexao = new MySqlConnection("Server=localhost;Database=receitas;Uid=root;Pwd=;");
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

                strSQLSelect = "select nome 'Nome', tempo_preparacao 'Tempo de Preparacao', grau_dificuldade 'Grau de dificuldade', numero_pressoas 'Numero de pessoas', categoria 'Categoria' from receitas";

                da = new MySqlDataAdapter(strSQLSelect, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dGVReceitas.DataSource = dt;

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

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            string strSQL;
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=receitas;Uid=root;Pwd=110688;");
                strSQL = "delete from receitas";
                comando = new MySqlCommand(strSQL, conexao);
                

                conexao.Open();
                comando.ExecuteNonQuery();

                strSQLSelect = "select nome 'Nome', tempo_preparacao 'Tempo de Preparacao', grau_dificuldade 'Grau de dificuldade', numero_pressoas 'Numero de pessoas', categoria 'Categoria' from receitas";

                da = new MySqlDataAdapter(strSQLSelect, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dGVReceitas.DataSource = dt;

            }
            catch (Exception ex)
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
