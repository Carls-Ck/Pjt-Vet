CREATE TABLE [dbo].[Consulta] (
    [ID_Consults] INT      NOT NULL,
    [Date]        DATE     NOT NULL,
    [Time]     DATETIME NOT NULL,
    [ID_Médico]   INT      NOT NULL,
    [ID_Pacient] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Consults] ASC)
);

