CREATE TABLE [dbo].[Rota]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [Embarque] NVARCHAR(50) NULL, 
    [Destino] NVARCHAR(50) NULL, 
    [Preco] DECIMAL(15, 2) NULL, 
    [TempoViagem] INT NULL, 
    [HoraEmbarque] DATETIME NULL, 
    [HoraChegada] DATETIME NULL, 
    [QtdParada] INT NULL
        
    CONSTRAINT PK_Rota PRIMARY KEY (Id),
)
