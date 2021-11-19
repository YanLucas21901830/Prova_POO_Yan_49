using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1yanlucas49.CODE.DTO
{
    class LojasDTO
    {
        private int _id;
        private string _profissao;
        private int _salario;

        public int Id { get => _id; set => _id = value; }
        public string Profissao { get => _profissao; set => _profissao = value; }
        public int Salario { get => _salario; set => _salario = value; }
    }
}
