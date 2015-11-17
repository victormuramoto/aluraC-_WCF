using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFPassagem
{
    public class ClienteDAO
    {
        public static List<Cliente> dados = new List<Cliente>();

        public void Add(Cliente cliente)
        {
            ClienteDAO.dados.Add(cliente);
        }

        public Cliente Buscar(string nome)
        {
            return dados.Where(cliente => cliente.Nome.Equals(nome)).FirstOrDefault();
            
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return dados;
        }
    }
}
