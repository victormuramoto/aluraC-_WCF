using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
namespace WCFPassagem
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebInvoke(Method="GET",ResponseFormat=WebMessageFormat.Json,UriTemplate="addClientes/{nome};{cpf}")]
        bool Add(string nome, string cpf);

        [OperationContract]
        [WebInvoke(Method="GET",ResponseFormat=WebMessageFormat.Json,UriTemplate="buscaCliente/{nome}")]
        Cliente Buscar(string nome);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "getClientes/")]
        IEnumerable<Cliente> GetClientes();

    }
}
