using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace HandsOnMock.Teste.Mock
{
    public static class MockServicoConsultaCredito
    {
        public static Mock<IServicoConsultaCredito> ConsultarPendenciasPorCPF(this Mock<IServicoConsultaCredito> mock, IList<Pendencia> pendencias)
        {
            mock.Setup(x => x.ConsultarPendenciasPorCPF(It.IsAny<string>())).Returns(pendencias);
            return mock;
        }
    }
}
