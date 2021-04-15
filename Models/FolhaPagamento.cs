using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.Date)]
        public DateTime Periodo { get; set; }
    }
}
