using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFPassagem
{
    public class ClienteService : IClienteService
    {
        public void Add(Cliente cliente)
        {
            new ClienteDAO().Add(cliente);
        }

        public Cliente Buscar(string nome)
        {
            return new ClienteDAO().Buscar(nome);
        }
    }
}
