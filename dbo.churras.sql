CREATE TABLE [dbo].[Churras]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Data] DATE NOT NULL, 
    [Motivo] NCHAR(255) NOT NULL, 
    [Observacao] NCHAR(2000) NULL, 
    [ValorComBebida] MONEY NULL, 
    [ValorSemBebida] MONEY NULL
)
