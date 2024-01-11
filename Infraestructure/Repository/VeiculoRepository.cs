using Dapper;
using Domain.Commands;
using Domain.Entidades;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private string conexao = @"Server=(localdb)\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(VeiculoCommand command)
        {

            string queryInsert = @"
            INSERT INTO Veiculo(Placa,  AnoFabricação,  TipoVeiculoId,  Estado,  MontadoraId)
            VALUES (@Placa, @AnoFabricação, @TipoVeiculoId, @Estado, @MontadoraId)";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new {
                    Placa = command.Placa,
                    AnoFabricação = command.AnoFabricacao,  
                    TipoVeiculoId = (int)command.TipoVeiculo,
                    Estado = command.Estado,
                    MontadoraId = (int)command.Montadora

                });

                return "Veiculo cadastrado com sucesso";
            }
        }

        public void PostAsync()
        {

        }
        public void GetAsync()
        {

        }

        public Task<string> PostAsync(IVeiculoCommand command)
        {
            throw new NotImplementedException();
        }

    }
}
