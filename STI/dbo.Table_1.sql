CREATE TABLE [dbo].[Cliente]
(
	[IdCli] INT NOT NULL PRIMARY KEY  IDENTITY, 
    [NomeCli] NCHAR(50) NULL, 
    [CpfCli] CHAR(11) NULL, 
    [TelCli] CHAR(15) NOT NULL, 
    [RuaCli] NCHAR(50) NULL, 
    [CidadeCli] NCHAR(50) NULL, 
    [EstadoCli] NCHAR(30) NULL
)
