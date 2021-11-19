using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3c1yanlucas49.CODE.DTO; 
using _3c1yanlucas49.CODE.DAL;
using System.Data;

namespace _3c1yanlucas49.CODE.BLL
{
    class lojasBLL
    {
       
        bd bd = new bd();
        string tabela = "funcionarios";


        
        public void Inserir(LojasDTO lojasDTO)
        {
            
            string inserir = $"insert into {tabela} values('{ lojasDTO.Id}','{ lojasDTO.Profissao}','{ lojasDTO.Salario}')";
            bd.ExecutarComando(inserir);
        }


        public void Excluir(LojasDTO lojasDTO)
        {
            string excluir = $"delete from {tabela} where id = '{lojasDTO.Id}';";
            bd.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela}; ";
            return bd.ExecutarConsulta(sql);
        }
        public void Editar(LojasDTO lojasDTO)
        {
            string alterar = $"update {tabela} set profissao = '{lojasDTO.Profissao}', salario = '{lojasDTO.Salario}' where id = '{lojasDTO.Id}';";
            bd.ExecutarComando(alterar);
        }
    }
}
