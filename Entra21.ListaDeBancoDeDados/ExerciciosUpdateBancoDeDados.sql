SELECT id, nome, codigo, categoria, descricao, altura, peso, hp, ataque, defesa, especial_ataque, especial_defesa, velocidade FROM pokemons ;

UPDATE pokemons SET categoria = 'seed' WHERE codigo >= 50 AND codigo <= 100;

UPDATE pokemons SET ataque = 29 WHERE nome LIKE '%inj%';

UPDATE pokemons SET velocidade = 2 WHERE velocidade = 5;

UPDATE pokemons SET categoria = 'Manipulate' WHERE codigo = 100;

UPDATE pokemons SET nome = REPLACE(nome, SUBSTRING(nome, 1, 1), 'C') WHERE nome LIKE 'R%';

UPDATE pokemons SET altura = 0.51, peso = 0.70 WHERE altura = 0.5;

UPDATE pokemons SET codigo = 1, defesa = 1,	ataque = 1, especial_ataque = 3, especial_defesa = 4 WHERE especial_defesa = 3 AND especial_ataque = 4;

UPDATE pokemons SET nome = SUBSTRING(nome, 1, 10) WHERE LEN(nome) > 10;

UPDATE pokemons SET categoria = 'flames' WHERE categoria LIKE '%water%';

UPDATE pokemons SET codigo = 151 WHERE codigo = 155;

UPDATE pokemons SET nome = 'Naruto', ataque = 1 WHERE nome = 'Kabuto';

UPDATE pokemons SET nome = 'Sasuke', especial_ataque = 8002, ataque = 8001 WHERE nome LIKE 'Mew' OR nome LIKE 'Mewtwo';

UPDATE pokemons SET descricao = 'Lorem ipsum.', nome = 'Tyranitar', categoria = 'Wood Gecko' WHERE codigo % 2 = 0;

-- CIDADES

SELECT cidade, estado FROM cidades;

UPDATE cidades SET estado = 'SS' WHERE estado LIKE 'SC'; 

UPDATE cidades SET cidade = 'Brumenau', estado = 'SC' WHERE cidade LIKE 'Blumenau';

UPDATE cidades SET cidade = 'Batata' WHERE cidade LIKE 'Bata%';

UPDATE cidades SET cidade = REPLACE(cidade, 'Belo', 'Lindo') WHERE cidade LIKE '%Belo%';

UPDATE cidades SET estado = 'SC' WHERE cidade LIKE 'Indaia%';

UPDATE cidades SET estado = 'SC' WHERE cidade LIKE 'Timbó';

UPDATE cidades SET cidade = REPLACE(cidade, 'José', 'Josué') WHERE cidade LIKE '%José%';

UPDATE cidades SET estado = 'PS' WHERE estado LIKE '%SP%';

UPDATE cidades SET cidade = 'Qualquer texto' WHERE LEN(cidade) = 10;

UPDATE cidades SET cidade = 'It' WHERE cidade LIKE 'It%';

UPDATE cidades SET estado = 'TO' WHERE cidade LIKE '%ã';

-- Alunos

SELECT id, nome, cpf, nick, signo, numero_favorito, cor_preferida, nota_1, nota_2, nota_3, nota_4, data_nascimento FROM alunos;

UPDATE alunos SET nota_1 = 9.9 WHERE YEAR(data_nascimento) = 1996;

UPDATE alunos SET nota_2 = 1.3 WHERE nome = 'Urbano%';

-- UPDATE alunos SET numero_favorito = ABS(CHECKSUM(NEWID())) WHERE numero_favorito % 2 = 1;

UPDATE alunos SET signo = 'Áries', numero_favorito = 100, cor_preferida = 'preto', nome = 'Marcela' WHERE signo = 'peixes'; 

UPDATE alunos SET cor_preferida = 'azul', nota_2 = 9.3 WHERE cor_preferida = 'cáqui';

UPDATE alunos SET cpf = '10194731189' WHERE cpf = '101.947.311-89';

UPDATE alunos SET nota_1 = 1, nota_2 = 1, nota_3 = 1, nota_4 = 1 WHERE (nota_1 + nota_2 + nota_3 + nota_4) / 4 < 4;

UPDATE alunos SET nick = 'Ninjutsu' WHERE nick LIKE 'Fueusn';

UPDATE alunos SET nick = 'Dovermann', cor_preferida = 'rosa' WHERE nick = 'Saxiol';

UPDATE alunos SET data_nascimento = CONVERT(datetime, FORMAT(data_nascimento, 'yyyy-MM-30 H:mm:ss')) WHERE DAY(data_nascimento) = 31;

UPDATE alunos SET cor_preferida = 'roxo', nick = 'Roxolandia' WHERE cor_preferida = 'roxo' OR cor_preferida = 'coral';

UPDATE alunos SET data_nascimento = CONVERT(datetime, FORMAT(data_nascimento, '2018-06-dd H:mm:ss')) WHERE MONTH(data_nascimento) = 07;