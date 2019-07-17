using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExportaPreco
{
    class Data
    {
            string server = ConfigurationManager.ConnectionStrings["ExportaPreco.Properties.Settings.conexao"].ToString();
            FbConnection conexao = null;
            
        

        public DataTable BuscaTabelas()
        {
            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                string query = "select idtabelapreco, descricao from testtabelapreco";
                FbCommand cmd = new FbCommand(query, conexao);
                DataTable table = new DataTable();
                FbDataAdapter adapter = new FbDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                return table;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }

        }

        public string NomeTabela(string id)
        {

            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                string query = "select descricao from testtabelapreco where idtabelapreco=" + id;
                FbCommand cmd = new FbCommand(query, conexao);
                if (cmd.ExecuteScalar() == null)
                {
                    return "TABELA NÃO ENCONTRADA!";
                }
                else
                {
                    return cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ExportarRegistro(string caminho, string idtabela, ProgressBar bar)
        {
            StreamWriter sw = new StreamWriter(caminho + @"\" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".txt", false, Encoding.UTF8);
            bar.Value = 0;

            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                string query =
                    "select                                                                                                " +
                    "lpad(c.codigobarra,13,0) as  EAN,                                                                     " +
                    "rpad(c.descricao,20,' ') as DESCRICAO,                                                                " +
                    "lpad(replace(cast(cast(b.custofinal as numeric(15,2))as varchar(15)),'.',''),12,'0') as PRECO         " +
                    "                                                                                                      " +
                    "from testtabelapreco a                                                                                " +
                    "inner join testtabelaprecoprodutos b on (a.empresa = b.empresa and a.idtabelapreco = b.idtabelapreco) " +
                    "inner join testprodutogeral c on (b.produto = c.codigo)                                               " +
                    "where                                                                                                 " +
                    "a.idtabelapreco = " + idtabela;
                FbCommand cmd = new FbCommand(query, conexao);
                FbDataAdapter adapter = new FbDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                string txt = string.Empty;
                FbDataReader reader = cmd.ExecuteReader();
                bar.Maximum = table.Rows.Count;
                while (reader.Read())
                {
                    sw.WriteLine(string.Format("{0}{1}{2}", reader["EAN"].ToString(), reader["DESCRICAO"].ToString(), reader["PRECO"].ToString()));
                    bar.Value += 1;
                }

                sw.Write(txt);

                MessageBox.Show("Processo concluído com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
                sw.Close();
            }

        }

        public bool VerificaConexao()
        {
            conexao = new FbConnection(server);

            try
            {
                conexao.Open();
            }
            catch
            {
            }

            if (conexao.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
