using LocacaoDeVeiculos.DATA.Models;
using LocacaoDeVeiculos.DATA.Services;
using Microsoft.AspNetCore.Mvc;

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
            return View();  
        }
    }
}
