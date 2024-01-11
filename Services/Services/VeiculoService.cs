using Domain.Commands;
using Domain.ENums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class VeiculoService : IVeiculoService //aqui herda a interface "IVeiculosServices"
    {
        private readonly IVeiculoRepository _repository;

        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;
        }
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(VeiculoCommand command)
        {
            //to do
            //incluir validação, só podem cadastrar veículos com até 5 anos de uso

            //to do
            //Incluir somente carros do tipo SUV, Sedan e Hatch

            int anoAtual = DateTime.Now.Year;
            if (anoAtual - command.AnoFabricacao > 5)

            if (command == null)
                return "Todos os campos são obrigatórios";

            if (command.TipoVeiculo != ETipoVeiculo.suv
                && command.TipoVeiculo != ETipoVeiculo.esportivo
                && command.TipoVeiculo != ETipoVeiculo.sedan
                )

                return "O tipo de veiculo não é permitido";

            return await _repository.PostAsync(command);

        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
