﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMock
{
    public enum StatusConsultaCredito
    {
        ParametroEnvioInvalido = -2,
        ErroComunicacao = -1,
        SemPendencias = 0,
        Inadimplente = 1
    }
    public class Pendencia
    {
        public string CPF { get; set; }
        public string NomePessoa { get; set; }
        public string NomeReclamante { get; set; }
        public string DescricaoPendencia { get; set; }
        public DateTime DataPendencia { get; set; }
        public double VlPendencia { get; set; }


    }

}
