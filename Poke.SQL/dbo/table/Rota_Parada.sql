CREATE TABLE [dbo].[Rota_Parada]
(
    [RotaId] INT NOT NULL, 
    [ParadaId] INT NOT NULL,

    CONSTRAINT PK_RotaParada PRIMARY KEY (RotaId, ParadaId),
    CONSTRAINT FK_Parada_RotaParada FOREIGN KEY (ParadaId) references Parada(Id),
    CONSTRAINT FK_Rota_RotaParada FOREIGN KEY (RotaId) references Rota(Id)
)
