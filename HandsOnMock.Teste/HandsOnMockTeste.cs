
using HandsOnMock.Teste.Builder;

namespace HandsOnMock.Teste
{
    public class HandsOnMockTeste
    {
        [Fact(DisplayName = "Consultar situação CPF: 01 - Deve utilizar a classe AnaliseCredito.ConsultarSituacaoCPF")]

        public void GetConsultarPendenciasPorCPF_ShouldReturnStatusConsultaCredito_WhenParamentroForInvalido()
        {
            // Arrange
            var pendencias = new PendenciaBuilder().Default().BuildList();
            Console.WriteLine(pendencias);
            //var handlerMock =


            // Act

            // Assert


        }
    }
}