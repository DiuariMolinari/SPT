using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    public class Investimento
    {
        public int InvestimentoId { get; set; }
        public double ValorInvestido { get; set; }
        public double Periodo { get; set; }
        public TipoInvestimento TipoInvestimento { get; set; }
    }
}
