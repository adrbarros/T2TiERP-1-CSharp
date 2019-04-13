﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFeService.Model
{
    public class NFeLocalEntregaDTO
    {
        public int? id { get; set; }
        public int? idNFeCabecalho { get; set; }
        public string cpfCnpj { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public int? codigoMunicipio { get; set; }
        public string nomeMunicipio { get; set; }
        public string uf { get; set; }
    }
}