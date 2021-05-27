using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, DateTime dataNascimento, string cpf)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Cpf = cpf;
        }
        public int PessoaId { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public string Cpf { get; set; }
    }
}
