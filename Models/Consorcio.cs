using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    [Table("View_Consorcio")]
    public class Consorcio
    {
        public int ConsorcioId { get; set; }
        public string NomeSegmento { get; set; }
        public int TaxaSeguro { get; set; }
        public int QtdMesPlano { get; set; }
        public string DescricaoPlano { get; set; }
        public int ValorCarta { get; set; }
    }
}
