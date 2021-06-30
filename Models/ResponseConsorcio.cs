using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    public class ResponseConsorcio
    {
        public ResponseConsorcio(string Nome, string Bem, double ValorCarta, string Rua, string Cep)
        {
            this.Nome = Nome;
            this.Bem = Bem;
            this.ValorCarta = ValorCarta;
            this.Rua = Rua;
            this.Cep = Cep;
        }
        public string Nome { get; set; }
        public string Bem { get; set; }
        public double ValorCarta { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
    }
}
