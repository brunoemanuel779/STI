CREATE TABLE [dbo].[cliente] (
    [IdCli]     INT        IDENTITY (1, 1) NOT NULL,
    [NomeCli]   NCHAR (50) NULL,
    [CpfCli]    CHAR (11)  NULL,
    [TelCli]    CHAR (15)  NULL,
    [RuaCli]    NCHAR (50) NULL,
    [CidadeCli] NCHAR (50) NULL,
    [EstadoCli] NCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([IdCli] ASC)
);

