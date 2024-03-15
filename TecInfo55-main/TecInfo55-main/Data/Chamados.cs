﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Chamados
    {
        public int CodigoChamados { get; set; }

        public DateTime DataSolicitacao { get; set; }

        public string Ocorrencia { get; set; }

        public string Problema { get; set; }

        public bool Concluido { get; set; }

        public int fk_Cliente_CodigoCliente { get; set; }

        public int fk_Tecnico_CodigoTecnico { get; set; }
    }
}
