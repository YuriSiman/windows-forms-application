using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Data.Database
{
    public class DatabaseSql
    {
        public string tabela;
        public string mensagem;
        public bool status;
        public DatabaseContext db;

        public DatabaseSql(string tabelaDb)
        {
            status = true;

            try
            {
                db = new DatabaseContext();
                tabela = tabelaDb;
                mensagem = "Sucesso ao conectar com a tabela!";
            }
            catch (Exception e)
            {
                status = false;
                mensagem = $"Erro ao conectar com a Tabela: {e.Message}";
            }
        }

        public string Buscar(string id)
        {
            status = true;

            try
            {
                var sql = $"SELECT Id, JSON FROM {tabela} WHERE Id = '{id}'";
                var dt = db.SqlQuery(sql);

                if(dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    mensagem = $"Busca efetuada com sucesso! Identificador: {id}";
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Erro: Cliente não encontrado!";
                }
            }
            catch (Exception e)
            {
                status = false;
                mensagem = $"Erro: Busca não realizada! {e.Message}";
            }
            return "";
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> list = new List<string>();

            try
            {
                var sql = $"SELECT Id, JSON FROM {tabela}";
                var dt = db.SqlQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        list.Add(conteudo);
                    }
                    return list;
                }
                else
                {
                    status = false;
                    mensagem = "Erro: Clientes não encontrados!";
                }
            }
            catch (Exception e)
            {
                status = false;
                mensagem = $"Erro: Busca não realizada! {e.Message}";
            }
            return list;
        }

        public void Adicionar(string id, string json)
        {
            status = true;

            try
            {
                var sql = $"INSERT INTO {tabela} (Id, JSON) VALUES ('{id}', '{json}')";
                db.SqlCommand(sql);
                status = true;
                mensagem = $"Inclusão efetuada com sucesso! Identificador: {id}";
            }
            catch (Exception e)
            {
                status = false;
                mensagem = $"Erro: Inclusão não efetuada! {e.Message}";
            }
        }

        public void Alterar(string id, string json)
        {
            status = true;

            try
            {
                var sql = $"SELECT Id, JSON FROM {tabela} WHERE Id = '{id}'";
                var dt = db.SqlQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    sql = $"UPDATE {tabela} SET JSON = '{json}' WHERE Id = '{id}'";
                    db.SqlCommand(sql);
                    status = true;
                    mensagem = $"Alteração efetuada com sucesso! Identificador: {id}";
                }
                else
                {
                    status = false;
                    mensagem = "Erro: Não existe cliente com esse código!";
                }
            }
            catch (Exception e)
            {
                status = false;
                mensagem = $"Erro: Alteração não efetuada! {e.Message}";
            }
        }

        public void Excluir(string id)
        {
            status = true;

            try
            {
                var sql = $"SELECT Id, JSON FROM {tabela} WHERE Id = '{id}'";
                var dt = db.SqlQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    sql = $"DELETE FROM {tabela} WHERE Id = '{id}'";
                    db.SqlCommand(sql);
                    status = true;
                    mensagem = $"Exclusão efetuada com sucesso! Identificador: {id}";
                }
                else
                {
                    status = false;
                    mensagem = "Erro: Não existe cliente com esse código!";
                }
            }
            catch (Exception e)
            {
                status = false;
                mensagem = $"Erro: Exclusão não efetuada! {e.Message}";
            }
        }

    }
}
