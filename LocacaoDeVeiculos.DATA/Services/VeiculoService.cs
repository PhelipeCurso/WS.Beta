using LocacaoDeVeiculos.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeVeiculos.DATA.Services
{
    public class VeiculoService
    {
        public RepositoryVeiculo oRepositoryVeiculo { get; set; }    

        public VeiculoService()
        {
            oRepositoryVeiculo = new RepositoryVeiculo();
        }

    }
}
