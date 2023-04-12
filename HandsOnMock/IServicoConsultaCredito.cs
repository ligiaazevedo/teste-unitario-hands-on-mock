using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMock
{
    public interface IServicoConsultaCredito
    {
        IList<Pendencia> ConsultarPendenciasPorCPF(string cpf);
    }
}
