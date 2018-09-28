CREATE TABLE [dbo].[Participante]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [IdChurras] INT NOT NULL, 
    [Nome] NCHAR(10) NOT NULL, 
    [Valor] MONEY NULL, 
    [Pago] BIT NULL, 
    [ComBebida] BIT NULL, 
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([IdChurras]) REFERENCES [Churras]([Id])
)
