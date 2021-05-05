using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    public class Consorcio
    {
        public int ConsorcioId { get; set; }
        public string NomeSegmento { get; set; }
        public int TaxaSeguro { get; set; }
        public bool Ativo { get; set; }
        public int QtdMesPlano { get; set; }
        public string DescricaoPlano { get; set; }
        public int ValorCarta { get; set; }
    }
}
