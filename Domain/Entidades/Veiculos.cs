﻿using Domain.ENums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Veiculos
    {
        public int VeiculoId { get; set; }
        public int Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public ETipoVeiculo TipoVeiculo { get; set; }
        public string Estado {  get; set; }
        public EMontadora Montadora { get; set; }
        public bool Alugado { get; set; } = false;

    }
}
