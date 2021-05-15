using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public int EnderecoId { get; set; }

        public Endereco Endereco { get; set; }
    }
}
