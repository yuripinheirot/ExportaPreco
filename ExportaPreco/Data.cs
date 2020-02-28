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

        public async Task ExportarRegistro(string caminho, string idtabela, ProgressBar bar, Label Concluido, string data)
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
                        "select distinct                                                                     " +
                        "pdg.codigobarra as  EAN,                                                            " +
                        "replace(pdg.descricao,';','') as DESCRICAO,                                         " +
                        "replace(cast(cast(pdt.prpraticado as numeric(17,2)) as varchar(20)),'.','')as PRECO " +
                        "from testproduto pdt                                                                " +
                        "inner join testprodutogeral pdg on (pdt.produto = pdg.codigo)                       " +
                        "inner join  testtabelapreco tbp on (tbp.empresa = pdt.empresa)                      " +
                        "inner join testtabelaprecoprodutos tpt on (pdt.empresa = tpt.empresa and            " +
                        "                                           tbp.idtabelapreco = tpt.idtabelapreco    " +
                        "                                           and tpt.produto = pdt.produto)           " +
                        "where                                                                               " +
                        "pdt.ativo = 'S'                                                                     " +
                       $"and tbp.idtabelapreco  = '{idtabela}'                                               " +
                       $"and pdt.dataalteracao >= '{data}'                                                   ";
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
                        sw.WriteLine(string.Format("{0};{1};{2}", reader["EAN"].ToString(), reader["DESCRICAO"].ToString(), reader["PRECO"].ToString()));
                        bar.Value += 1;
                        Concluido.Text = "Concluído " + bar.Value + "/" + table.Rows.Count;
                    }

                    sw.Write(txt);
                });

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
