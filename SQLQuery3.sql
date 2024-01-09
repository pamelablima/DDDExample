
USE AluguelVeiculos 
GO


INSERT INTO Veiculo(Placa,  AnoFabricação,  TipoVeiculoId,  Estado,  MontadoraId)
VALUES (@Placa, @AnoFabricação, @TipoVeiculoId, @Estado, @MontadoraId)

SELECT * FROM Veiculo

