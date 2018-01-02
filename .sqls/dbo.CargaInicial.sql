CREATE TABLE Postagem
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY ,
        [Titulo] NVARCHAR(255) NOT NULL ,
        [Conteudo] NVARCHAR(MAX) NOT NULL ,
        [DataHoraAtualizacao] DATETIME NOT NULL ,
        [DataHoraCriacao] DATETIME NOT NULL ,
        AutorId INT NOT NULL
            FOREIGN KEY REFERENCES Autor ( Id )
    );

GO

CREATE TABLE Autor
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY ,
		[Nome] NVARCHAR(100) NOT NULL,
        [Bio] NVARCHAR(255) NULL
    );

GO

SET IDENTITY_INSERT Autor ON;

INSERT dbo.Autor ( Id , Nome,
                   Bio )
VALUES ( 1, 'Nome 1',  N'Minha Biografia sem sentido....' ),
	  ( 2,'Nome 2', N'Minha Biografia sem sentido 2....' ),
	  ( 3,'Nome 3', N'Minha Biografia sem sentido 3....' );
SET IDENTITY_INSERT Autor OFF;

INSERT dbo.Postagem ( Titulo ,
                      Conteudo ,
                      DataHoraAtualizacao ,
                      DataHoraCriacao ,
                      AutorId )
VALUES ( N'Meu titulo 1' ,                              -- Titulo - nvarchar(255)
         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
         GETDATE() ,                                    -- DataHoraCriacao - datetime
         1                                              -- AutorId - int
    ) ,
       ( N'Meu titulo 2' ,                              -- Titulo - nvarchar(255)
         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
         GETDATE() ,                                    -- DataHoraCriacao - datetime
         1                                              -- AutorId - int
       ) ,
       ( N'Meu titulo 3' ,                              -- Titulo - nvarchar(255)
         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
         GETDATE() ,                                    -- DataHoraCriacao - datetime
         2                                              -- AutorId - int
       ) ,
       ( N'Meu titulo 4' ,                              -- Titulo - nvarchar(255)
         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
         GETDATE() ,                                    -- DataHoraCriacao - datetime
         2                                              -- AutorId - int
       ) ,
       ( N'Meu titulo 5' ,                              -- Titulo - nvarchar(255)
         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
         GETDATE() ,                                    -- DataHoraCriacao - datetime
         2                                              -- AutorId - int
       );