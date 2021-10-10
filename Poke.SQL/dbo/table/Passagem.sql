CREATE TABLE [dbo].[Passagem]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [HorarioPartida] DATETIME NOT NULL, 
    [Preco] DECIMAL(15, 2) NOT NULL, 
    [Descricao] NVARCHAR(50) NULL, 
    [UsuarioId] INT NOT NULL, 
    [ViagemId] INT NOT NULL,
    
    CONSTRAINT PK_Passagem PRIMARY KEY (Id),
    CONSTRAINT FK_Passagem_Viagem FOREIGN KEY (ViagemId) references Viagem(Id),
    CONSTRAINT FK_Passagem_Usuario FOREIGN KEY (UsuarioId) references Usuario(Id),
)
