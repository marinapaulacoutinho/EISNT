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

        string server = Properties.Resources.server;
        string database = Properties.Resources.database;
        string uid = Properties.Resources.uid;
        string pass = Properties.Resources.pass;

        string strSQL;


        public Form1()
        {
            InitializeComponent();
            Show_list();
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
                conexao = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pass};");
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
                
                Clear_Inputs();

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
                Show_list();
            }

        }

        private void Clear_Inputs()
        {
            textBoxNome.Clear();
            richTextBoxDesc.Clear();
            textBoxTempoPrep.Clear();
            cBGrauDificuldade.SelectedIndex = -1;
            cBNumeroPessoas.SelectedIndex = -1;
            cBCategoria.SelectedIndex = -1;
            txtEliminar.Clear();
            txtBuscar.Clear();
        }
        private void Show_list() 
        {
            try
            {
                strSQL = "select id 'ID',nome 'Nome', tempo_preparacao 'Tempo de Preparacao', grau_dificuldade 'Grau de dificuldade', numero_pressoas 'Numero de pessoas', categoria 'Categoria' from receitas";

                conexao = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pass};");
                da = new MySqlDataAdapter(strSQL, conexao);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = $"select id 'ID',nome 'Nome', tempo_preparacao 'Tempo de Preparacao', grau_dificuldade 'Grau de dificuldade', numero_pressoas 'Numero de pessoas', categoria 'Categoria' from receitas where nome like '%{txtBuscar.Text}%'";

                conexao = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pass};");
                da = new MySqlDataAdapter(strSQL, conexao);
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

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pass};");
                strSQL = "delete from receitas where id = @id";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txtEliminar.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                Clear_Inputs();

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
                Show_list();
            }
        }

        private void bntLimpar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pass};");
                strSQL = "TRUNCATE TABLE receitas";
                comando = new MySqlCommand(strSQL, conexao);

                conexao.Open();
                comando.ExecuteNonQuery();

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
                Show_list();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
