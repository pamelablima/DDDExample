using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVeiculoService
    {
        //a interface é um contrato, apenas usamos pra adicionar métodos
        //não é feita implementação de nada.


        Task PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();

    }
}
