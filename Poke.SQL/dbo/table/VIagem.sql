CREATE TABLE [dbo].[Viagem]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [DataViagem] DATETIME NULL, 
    [Destino] NVARCHAR(50) NULL, 
    [Origem] NVARCHAR(50) NULL, 
    [VeiculoId] INT NULL, 
    [RotaId] INT NOT NULL,
    
    CONSTRAINT PK_Viagem PRIMARY KEY (Id),
    CONSTRAINT FK_Viagem_Veiculo FOREIGN KEY (VeiculoId) references Veiculo(Id),
    CONSTRAINT FK_Viagem_Rota FOREIGN KEY (RotaId) references Rota(Id),
)
