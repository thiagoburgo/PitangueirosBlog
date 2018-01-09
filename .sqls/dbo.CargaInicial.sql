

CREATE TABLE Usuario
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY,
        [Nome] NVARCHAR(255) NOT NULL ,
        [Email] NVARCHAR(255) NOT NULL ,
        [Senha] NVARCHAR(50) NOT NULL
    );

GO
CREATE TABLE Autor
    (
        [Id] INT NOT NULL PRIMARY KEY  
			FOREIGN KEY REFERENCES dbo.Usuario(Id),
        [Bio] NVARCHAR(255) NULL
    );

GO

CREATE TABLE Moderador
    (
        [Id] INT NOT NULL PRIMARY KEY 
			FOREIGN KEY REFERENCES dbo.Usuario(Id)				
    );

GO
CREATE TABLE Postagem
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY ,
        [Titulo] NVARCHAR(255) NOT NULL ,
        [Conteudo] NVARCHAR(MAX) NOT NULL ,
        [DataHoraAtualizacao] DATETIME NOT NULL ,
        [DataHoraCriacao] DATETIME NOT NULL ,
        [AutorId] INT NOT NULL
            FOREIGN KEY REFERENCES Autor ( Id ),
		[ModeradorId] INT NULL FOREIGN KEY REFERENCES Moderador ( Id )
    );

GO
--SET IDENTITY_INSERT Autor ON;

--INSERT dbo.Autor ( Id , Nome,
--                   Bio )
--VALUES ( 1, 'Nome 1',  N'Minha Biografia sem sentido....' ),
--	  ( 2,'Nome 2', N'Minha Biografia sem sentido 2....' ),
--	  ( 3,'Nome 3', N'Minha Biografia sem sentido 3....' );
--SET IDENTITY_INSERT Autor OFF;

--INSERT dbo.Postagem ( Titulo ,
--                      Conteudo ,
--                      DataHoraAtualizacao ,
--                      DataHoraCriacao ,
--                      AutorId )
--VALUES ( N'Meu titulo 1' ,                              -- Titulo - nvarchar(255)
--         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
--         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
--         GETDATE() ,                                    -- DataHoraCriacao - datetime
--         1                                              -- AutorId - int
--    ) ,
--       ( N'Meu titulo 2' ,                              -- Titulo - nvarchar(255)
--         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
--         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
--         GETDATE() ,                                    -- DataHoraCriacao - datetime
--         1                                              -- AutorId - int
--       ) ,
--       ( N'Meu titulo 3' ,                              -- Titulo - nvarchar(255)
--         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
--         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
--         GETDATE() ,                                    -- DataHoraCriacao - datetime
--         2                                              -- AutorId - int
--       ) ,
--       ( N'Meu titulo 4' ,                              -- Titulo - nvarchar(255)
--         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
--         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
--         GETDATE() ,                                    -- DataHoraCriacao - datetime
--         2                                              -- AutorId - int
--       ) ,
--       ( N'Meu titulo 5' ,                              -- Titulo - nvarchar(255)
--         N'Meu conteúdo que não tem conteudo nenhum!' , -- Conteudo - nvarchar(max)
--         GETDATE() ,                                    -- DataHoraAtualizacao - datetime
--         GETDATE() ,                                    -- DataHoraCriacao - datetime
--         2                                              -- AutorId - int
--       );