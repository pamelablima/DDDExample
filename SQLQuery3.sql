
USE AluguelVeiculos 
GO


INSERT INTO Veiculo(Placa,  AnoFabrica��o,  TipoVeiculoId,  Estado,  MontadoraId)
VALUES (@Placa, @AnoFabrica��o, @TipoVeiculoId, @Estado, @MontadoraId)

SELECT * FROM Veiculo

