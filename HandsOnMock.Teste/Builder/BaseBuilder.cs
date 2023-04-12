using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMock.Teste.Builder
{
    public class BaseBuilder<T> where T : new()
    {
        protected T _instance = new();

        public T Build() => _instance;
        public List<T> BuildList() => new List<T> { _instance};

    }
}
