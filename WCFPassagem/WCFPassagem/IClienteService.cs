using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFPassagem
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        void Add(Cliente cliente);

        [OperationContract]
        Cliente Buscar(string nome);


    }
}
