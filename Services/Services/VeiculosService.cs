using Domain.Commands;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class VeiculosService : IVeiculoService //aqui herda a interface "IVeiculosServices"
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task PostAsync(VeiculoCommand command)
        {   
            //to do
            //incluir validação, só podem cadastrar veículos com até 5 anos de uso
            
            //to do
            //Incluir somente carros do tipo SUV, Sedan e Hatch

            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
