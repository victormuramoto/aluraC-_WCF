using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFPassagem
{
    public class ClienteDAO
    {
        private static List<Cliente> dados = new List<Cliente>();

        public void Add(Cliente cliente)
        {
            ClienteDAO.dados.Add(cliente);
        }

        public Cliente Buscar(string nome)
        {
            return (Cliente) dados.Select(cliente => cliente.Nome.Equals(nome));
            
        }


    }
}
