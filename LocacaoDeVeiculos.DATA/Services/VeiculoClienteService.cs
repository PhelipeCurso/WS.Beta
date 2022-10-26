using LocacaoDeVeiculos.DATA.Models;
using LocacaoDeVeiculos.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeVeiculos.DATA.Services
{
    public  class VeiculoClienteService
    {
        public RepositoryVwVeiculoCliente oRepositoryVwVeiculoCliente { get; set; }  

        public VeiculoClienteService()
        {
            oRepositoryVwVeiculoCliente = new RepositoryVwVeiculoCliente();
        }

    }
}
