CREATE TABLE [dbo].[Parada]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [Nome] NVARCHAR(50) NULL, 
    [Local] NVARCHAR(50) NULL, 
    [Latitude] NVARCHAR(50) NULL, 
    [Longitude] NVARCHAR(50) NULL, 
    [DataCadastro] DATETIME NULL,
    
    CONSTRAINT PK_Parada PRIMARY KEY (Id)
)
