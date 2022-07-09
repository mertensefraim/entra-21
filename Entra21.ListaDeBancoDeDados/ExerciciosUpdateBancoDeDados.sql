SELECT id, nome, codigo, categoria, descricao, altura, peso, hp, ataque, defesa, especial_ataque, especial_defesa, velocidade FROM pokemons;

UPDATE pokemons SET categoria = 'seed' WHERE codigo >= 50 AND codigo <= 100;

UPDATE pokemons SET ataque = 29 WHERE nome LIKE '%inj%';

UPDATE pokemons SET velocidade = 2 WHERE velocidade = 5;

UPDATE pokemons SET categoria = 'Manipulate' WHERE codigo = 100;

UPDATE pokemons SET nome = REPLACE(nome, SUBSTRING(nome, 1, 1), 'C') WHERE nome LIKE 'R%';

UPDATE pokemons SET altura = 0.51, peso = 0.70 WHERE altura = 0.5;

UPDATE pokemons SET codigo = 1, defesa = 1,	ataque = 1, especial_ataque = 3, especial_defesa = 4 WHERE especial_defesa = 3 AND especial_ataque = 4;

UPDATE pokemons SET nome = SUBSTRING(nome, 1, 10) WHERE LEN(nome) > 10;