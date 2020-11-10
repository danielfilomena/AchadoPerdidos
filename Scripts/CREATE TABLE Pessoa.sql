USE LostFound;

CREATE table tbPes(
	pesCod	INT NOT NULL IDENTITY(1,1),
	pesNome	VARCHAR(20) NOT NULL,
	pesUltNome	VARCHAR(30) NOT NULL,
	pesCpf	VARCHAR(11) NOT NULL,
	pesDtaCad	DATETIME NULL,
	pesDtaAlt	DATETIME NULL,
	pesSenha	VARCHAR(10) NOT NULL,
	pesInativo	BIT NOT NULL CONSTRAINT DF_tbPes_pesInativo DEFAULT(0),
	pesExcluido	BIT NOT NULL CONSTRAINT DF_tbPes_pesExcluido DEFAULT(0),
		CONSTRAINT PK_tbPes_pesCod PRIMARY KEY (pesCod)
);	
	
	