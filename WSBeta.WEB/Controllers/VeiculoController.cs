using LocacaoDeVeiculos.DATA.Models;
using LocacaoDeVeiculos.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace WSBeta.WEB.Controllers
{
    public class VeiculoController : Controller
    {
        private VeiculoService oVeiculoService = new VeiculoService();
        public IActionResult Index()
        {
            List<Veiculo> oListVeiculos = oVeiculoService.oRepositoryVeiculo.SelecionarTodos();
            return View(oListVeiculos);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Veiculo model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oVeiculoService.oRepositoryVeiculo.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
           Veiculo oVeiculo = oVeiculoService.oRepositoryVeiculo.SelecionarPk(id);
            return View(oVeiculo);
        }

        public IActionResult Edit(int id)
        {
            Veiculo oVeiculo = oVeiculoService.oRepositoryVeiculo.SelecionarPk(id);
            return View(oVeiculo);
        }
        [HttpPost]
        public IActionResult Edit(Veiculo model)
        {
            Veiculo oVeiculo = oVeiculoService.oRepositoryVeiculo.Alterar(model);

            int id = oVeiculo.Id;

            return RedirectToAction("Details", new { id });
        }
        public IActionResult Delete(int id)
        {
            oVeiculoService.oRepositoryVeiculo.Excluir(id);
            return RedirectToAction("index");
        }
    }
}
