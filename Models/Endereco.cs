﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    //classe didatica, sem normalizacao.
    public class Endereco
    {
        public int EnderecoId { get; set; }

        public string Pais { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Logradouro { get; set; }

        public string Cep { get; set; }

        public string Numero { get; set; }
    }
}
