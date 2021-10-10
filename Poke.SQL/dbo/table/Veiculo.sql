CREATE TABLE [dbo].[Veiculo]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [Placa] NCHAR(10) NULL, 
    [QtdAssentos] NCHAR(10) NULL, 
    [Ano] NCHAR(10) NULL, 
    [TipoVeiculo] NCHAR(10) NULL, 
    [Wifi] BIT NOT NULL, 
    [Banheiro] BIT NOT NULL, 
    [Lanches] BIT NOT NULL, 
    [ArCondicionado] BIT NOT NULL,
    
    CONSTRAINT PK_Veiculo PRIMARY KEY (Id)
)
