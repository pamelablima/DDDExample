using Dapper;
using Domain.Entidades;
using Domain.ENums;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private string stringconnection = "";
        public async Task<string> PostAsync(Veiculos command)
        {

            string queryInsert = @"
            INSERT INTO Veiculo(Placa,  AnoFabricação,  TipoVeiculoId,  Estado,  MontadoraId)
            VALUES (@Placa, @AnoFabricação, @TipoVeiculoId, @Estado, @MontadoraId)";

            using (var conn = new SqlConnection())
            {
                conn.Execute(queryInsert, new {
                    Placa = command.Placa,
                    AnoFabricação = command.AnoFabricacao,  
                    TipoVeiculoId = command.TipoVeiculo,
                    Estado = command.Estado,
                    MontadoraId = command.Montadora

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
