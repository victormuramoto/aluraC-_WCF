using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFPassagem
{
    public class ClienteService : IClienteService
    {
        public bool Add(string nome, string cpf)
        {
            new ClienteDAO().Add(
                new Cliente() { Nome = nome,Cpf = cpf });

            return true;
        }

        public Cliente Buscar(string nome)
        {
            return new ClienteDAO().Buscar(nome);
        }


        public IEnumerable<Cliente> GetClientes()
        {
            return new ClienteDAO().GetClientes().ToList();
        }
    }
}
