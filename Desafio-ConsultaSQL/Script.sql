-- 1 - Buscar o nome e ano dos filmes
SELECT
    [Nome],
    [Ano]
FROM
    [Filmes];

-- 2 - Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano
SELECT
    [Nome],
    [Ano]
FROM
    [Filmes]
ORDER BY
    [Ano];

-- 3 - Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração
SELECT
    [Nome],
    [Ano],
    [Duracao]
FROM
    [Filmes]
WHERE
    [Nome]='De Volta para o Futuro';

-- 4 - Buscar os filmes lançados em 1997
SELECT
    *
FROM
    [Filmes]
WHERE
    [Ano]=1997;

-- 5 - Buscar os filmes lançados APÓS o ano 2000
SELECT
    *
FROM
    [Filmes]
WHERE
    [Ano]>2000;

-- 6 - Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente
SELECT
    *
FROM
    [Filmes]
WHERE
    [Duracao]>100 and [Duracao]<150
ORDER BY
    [Duracao];

-- 7 - Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente
SELECT
    [Ano],
    COUNT(*) AS Quantidade
FROM
    [Filmes]
GROUP BY
    [Ano]
ORDER BY
    [Quantidade] DESC


-- 8 - Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome
SELECT
    [PrimeiroNome],
    [UltimoNome]
FROM
    Atores
WHERE
    [Genero]='M';

-- 9 - Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome
SELECT
    [PrimeiroNome],
    [UltimoNome]
FROM
    Atores
WHERE
    [Genero]='F'
ORDER BY
    [PrimeiroNome];

-- 10 - Buscar o nome do filme e o gênero
SELECT 
    filme.[Nome],
    generos.[Genero]
FROM
    [Filmes] as filme
INNER JOIN
    [FilmesGenero] as relacao
ON
    relacao.[IdFilme]=filme.[Id]
INNER JOIN
    [Generos] as generos
ON
    relacao.[IdGenero]=generos.[Id];

-- 11 - Buscar o nome do filme e o gênero do tipo "Mistério"
SELECT 
    filme.[Nome],
    generos.[Genero]
FROM
    [Filmes] as filme
INNER JOIN
    [FilmesGenero] as relacao
ON
    relacao.[IdFilme]=filme.[Id]
INNER JOIN
    [Generos] as generos
ON
    relacao.[IdGenero]=generos.[Id]
WHERE
    generos.[Genero]='Mistério';

-- 12 - Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel
SELECT 
    filme.[Nome],
    ator.[PrimeiroNome],
    ator.[UltimoNome],
    elenco.[Papel]
FROM
    [Atores] as ator
INNER JOIN
    [ElencoFilme] as elenco
ON
    elenco.[IdAtor]=ator.[Id]
INNER JOIN
    [Filmes] as filme
ON
    filme.[Id]=elenco.[IdFilme];