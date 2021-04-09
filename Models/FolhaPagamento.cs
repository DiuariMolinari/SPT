using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    public class FolhaPagamento
    {
        public int FolhaPagamentoId { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public double HorasTrabalhadas { get; set; }
        public string Periodo { get; set; }
    }
}
