using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    public class PessoaEnderecos
    {
        public int PessoaEnderecosId { get; set; }

        public int PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }

        public int EnderecoId { get; set; }

        public Endereco Endereco { get; set; }
    }
}
