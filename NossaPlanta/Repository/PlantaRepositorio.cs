using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PlantaRepositorio
    {
        public string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eduardo\Documents\GitHub\Exercicio-Class-Library\NossaPlanta\Repository\Database.mdf;Integrated Security=True";

        public int Inserir(Planta planta)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO plantas (nome, peso, altura) VALUES (@NOME, @PESO, @ALTURA)";
            comando.Parameters.AddWithValue("@NOME", planta.Nome);
            comando.Parameters.AddWithValue("@PESO", planta.Peso);
            comando.Parameters.AddWithValue("@ALTURA", planta.Altura);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            conexao.Close();
            return id;

        }

        public bool Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM plantas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            int qtdAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            conexao.Close();
            return qtdAfetada == 1;
        }

        public List<Planta> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM plantas WHERE nome LIKE @NOME";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("NOME", busca);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            List<Planta> plantas = new List<Planta>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Planta planta = new Planta();
                planta.Id = Convert.ToInt32(linha["id"]);
                planta.Nome = linha["nome"].ToString();
                planta.Altura = Convert.ToDecimal(linha["altura"]);
                planta.Peso = Convert.ToDecimal(linha["peso"]);
                plantas.Add(planta);
            }
            return plantas;
        }

        public Planta ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM plantas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            if (tabela.Rows.Count ==0)
            {
                return null;
            }

            DataRow linha = tabela.Rows[0];
            Planta planta = new Planta();
            planta.Id = id;
            planta.Nome = linha["nome"].ToString();
            planta.Peso = Convert.ToDecimal(linha["peso"]);
            planta.Altura = Convert.ToDecimal(linha["altura"]);
            return planta;
        }

        public bool Alterar(Planta planta)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE plantas SET nome = @NOME, altura = @ALTURA, peso = @PESO WHERE id = @ID";
            comando.Parameters.AddWithValue("NOME", planta.Nome);
            comando.Parameters.AddWithValue("ALTURA", planta.Altura);
            comando.Parameters.AddWithValue("PESO", planta.Peso);
            comando.Parameters.AddWithValue("ID", planta.Id);
            int qtdAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            conexao.Close();
            return qtdAfetada == 1;
        }
    }
}
