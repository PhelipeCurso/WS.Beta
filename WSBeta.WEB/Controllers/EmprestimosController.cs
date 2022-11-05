using LocacaoDeVeiculos.DATA.Models;
using LocacaoDeVeiculos.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using WSBeta.WEB.Models;

namespace WSBeta.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        VeiculoClienteService _service = new VeiculoClienteService();
        public IActionResult Index()
        {
           List<VwVeiculoCliente> oListVwVeiculoCliente = _service.oRepositoryVwVeiculoCliente.SelecionarTodos();
            return View(oListVwVeiculoCliente);
        }

        public IActionResult Create()
        {
            EmprestimoViewModel oEmprestimoViewModel= new EmprestimoViewModel();
            List<Veiculo> oListVeiculos =_service.oRepositoryVeiculo.SelecionarTodos();
            List<Cliente> oListCliente = _service.oRepositoryCliente.SelecionarTodos();
            oEmprestimoViewModel.oListCliente = oListCliente;
            
            oEmprestimoViewModel.oListVeiculo = oListVeiculos;

            return View(oEmprestimoViewModel);  
        }
    }
}
