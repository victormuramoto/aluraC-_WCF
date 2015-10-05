using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFPassagem
{
    [ServiceContract]
    public interface ICliente
    {
        
        void Add(Cliente cliente);
        Cliente Buscar(string nome);


    }
}
