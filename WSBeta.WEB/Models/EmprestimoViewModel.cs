

using LocacaoDeVeiculos.DATA.Models;

namespace WSBeta.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Veiculo oVeiculo {get;set;}
        public Cliente oCliente { get;set;} 
        public List<Cliente> oListCliente { get;set;}
        public DateTime dataEmprestimo { get;set;}
        public DateTime dataEntrega { get;set;} 

        public List<Cliente>oListClientes{ get; set; }
        public List<Veiculo> oListVeiculo { get; set; }

    }
}
