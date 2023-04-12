using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMock.Teste.Builder
{
    public class PendenciaBuilder : BaseBuilder<Pendencia>
    {
        public PendenciaBuilder Default()
        {
            _instance.CPF = "01234567891";
            _instance.NomePessoa = "João da Silva";
            _instance.NomeReclamante = "Empresa XYZ";
            _instance.DescricaoPendencia = "Parcela não paga";
            _instance.VlPendencia = 700;

            return this;
        }

    }
}
