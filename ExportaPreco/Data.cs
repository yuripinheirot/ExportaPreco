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

        public async Task ExportarRegistro(string caminho, string idtabela, string empresa, ProgressBar bar, Label Concluido, string data)
        {
            StreamWriter sw = new StreamWriter(caminho + @"\" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".txt", false, Encoding.UTF8);
            bar.Value = 0;

            try
            {

                await Task.Run(() =>
                {
                    conexao = new FbConnection(server);
                    conexao.Open();
                    string query =
                        "select distinct                                                                                    " +
                        "																						            " +
                        "pdg.codigobarra as  EAN,                                                                           " +
                        "replace(pdg.descricao,';','') as DESCRICAO,                                                        " +
                        "replace(cast(cast(pdt.prpraticado as numeric(17,2)) as varchar(20)),'.','')as PRECO                " +
                        "																						            " +
                        "from testproduto pdt                                                                               " +
                        "inner join testprodutogeral pdg on (pdt.produto = pdg.codigo)                                      " +
                        "																						            " +
                        "where                                                                                              " +
                       $"pdt.dataalteracao >= @dataalteracao                                                                " +
                       $"and pdt.empresa = @empresa                                                                         " +
                        "and pdt.ativo = 'S'                                                                                " +
                        "and exists (select                                                                                 " +
                        "            b.produto                                                                              " +
                        "            from testtabelapreco a                                                                 " +
                        "            inner join testtabelaprecoprodutos b on (a.empresa = b.empresa and                     " +
                        "                                                     a.idtabelapreco = b.idtabelapreco)            " +
                        "            where b.produto = pdt.produto                                                          " +
                        "              and b.empresa = pdt.empresa                                                          " +
                       $"              and a.idtabelapreco = @idTabela)                                                     " +
                        "and (select count(c.codigobarra) from testprodutogeral c where c.codigobarra = pdg.codigobarra) < 2";
                    
                        FbCommand cmd = new FbCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@empresa", empresa);
                    cmd.Parameters.AddWithValue("@dataalteracao", data);
                    cmd.Parameters.AddWithValue("@idTabela", idtabela);
                    FbDataAdapter adapter = new FbDataAdapter();
                    DataTable table = new DataTable();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    string txt = string.Empty;
                    FbDataReader reader = cmd.ExecuteReader();
                    bar.Maximum = table.Rows.Count;

                    while (reader.Read())
                    {
                        sw.WriteLine(string.Format("{0};{1};{2}", reader["EAN"].ToString(), reader["DESCRICAO"].ToString(), reader["PRECO"].ToString()));
                        bar.Value += 1;
                        Concluido.Text = "Concluído " + bar.Value + "/" + table.Rows.Count;
                    }

                    sw.Write(txt);
                });

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
