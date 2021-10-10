CREATE TABLE [dbo].[Usuario]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Sobrenome] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Senha] NVARCHAR(50) NOT NULL, 
    [Telefone] INT NULL, 
    [DataCadastro] DATETIME NOT NULL,

    CONSTRAINT PK_Usuario PRIMARY KEY (Id)
)
