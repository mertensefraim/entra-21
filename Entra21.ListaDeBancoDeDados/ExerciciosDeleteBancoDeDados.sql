-- Pokemons

DELETE FROM pokemons WHERE categoria LIKE 'Seed';

DELETE FROM pokemons WHERE nome LIKE 'Nid%';

DELETE FROM pokemons WHERE categoria LIKE 'Snow%';

DELETE FROM pokemons WHERE ataque = 2 AND defesa = 1;

DELETE FROM pokemons WHERE especial_ataque % 2 = 0;

DELETE FROM pokemons WHERE LEN(categoria) = 10;

DELETE FROM pokemons WHERE LEN(categoria) < 4;

DELETE FROM pokemons WHERE velocidade % 2 = 1;

DELETE FROM pokemons WHERE nome LIKE '%Uno' OR nome LIKE '%Charm';

DELETE FROM pokemons WHERE categoria = 'Flower' AND (codigo >= 45 OR codigo <= 200);

DELETE FROM pokemons WHERE CONVERT(VARCHAR, descricao) LIKE '%shell%';

DELETE FROM pokemons WHERE peso >= 100;

DELETE FROM pokemons WHERE altura < 1;

DELETE FROM pokemons WHERE especial_defesa > 3;

DELETE FROM pokemons WHERE LEN(CONVERT(VARCHAR, descricao)) > 100;

DELETE FROM pokemons WHERE CONVERT(VARCHAR, descricao) LIKE '%good%';

DELETE FROM pokemons WHERE codigo % 2 = 0;

DELETE FROM pokemons WHERE nome LIKE 'Lileep';

DELETE FROM pokemons WHERE especial_ataque = 5;

DELETE FROM pokemons WHERE codigo < 100;

-- cidades

DELETE FROM cidades WHERE estado LIKE 'RS';

DELETE FROM cidades WHERE estado LIKE 'AC' AND cidade LIKE 'R%';

DELETE FROM cidades WHERE cidade LIKE '%goas';

DELETE FROM cidades WHERE cidade LIKE '%irmãos%';

DELETE FROM cidades WHERE estado LIKE 'MG';

DELETE FROM cidades WHERE cidade LIKE 'Douradinha';

-- alunos
SELECT * FROM alunos;

DELETE FROM alunos WHERE nome LIKE '%Francisco%';

DELETE FROM alunos WHERE YEAR(data_nascimento) = 1994;

DELETE FROM alunos WHERE signo LIKE '%Gêmeos%';

DELETE FROM alunos WHERE nome LIKE 'Reinaldo%';

DELETE FROM alunos WHERE nome LIKE '%Carvalho';

DELETE FROM alunos WHERE MONTH(data_nascimento) = 07;

DELETE FROM alunos WHERE nota_1 > nota_2 AND nota_4 < nota_3;

DELETE FROM alunos WHERE cpf LIKE '145.%';

DELETE FROM alunos WHERE (cor_preferida = 'Bordo' AND signo = 'Capricórnio') OR (cor_preferida = 'Cinza-claro' AND signo = 'Aquários');

DELETE FROM alunos WHERE (nota_1 + nota_2 + nota_3 + nota_4) / 4 < 4;

DELETE FROM  alunos WHERE DAY(data_nascimento) = 28;