CREATE TABLE [dbo].[Empresas]
(
	[EmpresaID] INT NOT NULL PRIMARY KEY IDENTITY,
	[RazaoSocial] VARCHAR(200),
	[CNPJ] VARCHAR(14),
	[Fone] VARCHAR(20)
)
GO
CREATE TABLE [dbo].[Simulacoes]
(
	[SimulacaoID] INT NOT NULL PRIMARY KEY IDENTITY,
	[EmpresaID] INT NOT NULL,
	[CustoFixoTotal] MONEY,
	[CustoVarUnit] MONEY,
	[PrecoUnit] MONEY,
	[QtdeVendaInicial] INT,
	[QtdeVendaFinal] INT,
	[IncrementoUnit] INT,
	CONSTRAINT FK_SimulacoesEmpresas FOREIGN KEY([EmpresaID]) REFERENCES [dbo].[Empresas]([EmpresaID])
)
