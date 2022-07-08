CREATE TABLE champions(
	id INTEGER PRIMARY KEY IDENTITY(1, 1),
	nome varchar(20),
	descricao varchar(50),
	habilidade1 varchar(50),
	habilidade2 varchar(50),
	habilidade3 varchar(50),
	habilidade4 varchar(50),
	habilidade5 varchar(50)
);

INSERT INTO champions(nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES ('Katarina', 'a Lâmina Sinistra', 'Voracidade', 'Lâmina Saltitante', 'Preparação', 'Shunpo', 'Lótus da Morte');

INSERT INTO champions(nome, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES ('Yasuo', 'Estilo do Errante', 'Tempestade de Aço', 'Parede de Vento', 'Espada Ágil', 'Último Suspiro');

INSERT INTO champions(nome, descricao, habilidade1) VALUES ('Master Yi', 'o Espadachim Wuju', 'Ataque Duplo');

INSERT INTO champions(nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES ('Vayne', 'a Caçadora Noturna', 'Caçadora Noturna', 'Rolamento', 'Dardos de Prata', 'Condenar', 'Hora Final');

INSERT INTO champions(nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4) VALUES ('Lee Sin', 'o Monge Cego', 'Agitação', 'Onda Sônica / Ataque Ressonante', 'Proteger / Vontade de Ferro', 'Tempestade / Mutilar');

INSERT INTO champions(nome, descricao, habilidade1, habilidade3, habilidade4, habilidade5) VALUES ('Vi', 'a Defensora de Piltover', 'Blindagem', 'Pancada Certeira', 'Força
Excessiva', 'Saque e Enterrada');

INSERT INTO champions(nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES ('Diana', 'o Escárnio da Lua', 'Espada de Prata Lunar', 'Golpe Crescente', 'Cascata Lívida', 'Colapso Minguante', 'Zênite Lunar');

INSERT INTO champions(nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES ('Annie', 'a Criança Sombria', 'Piromania', 'Desintegrar', 'Incinerar', 'Escudo Fundido', 'Invocar: Tibbers');

INSERT INTO champions(nome, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES ('Aatrox', 'Poço de Sangue', 'Voo Sombrio', 'Sede de Sangue / Preço em Sangue', 'Lâminas da Aflição', 'Massacre');

UPDATE champions SET descricao = 'O imperdoável' WHERE id = 2;

UPDATE champions SET habilidade2 = 'Ataque alpha', habilidade3 = 'Meditar', habilidade4 = 'Estilo wuju', habilidade5 = 'Highlander' WHERE id = 3;

UPDATE champions SET habilidade5 = 'Fúria do dragão' WHERE id = 5;

UPDATE champions SET habilidade2 = 'Quebra cofres' WHERE id = 6;

UPDATE champions SET descricao = 'A espada darkin' WHERE id = 9;
	

SELECT id, nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5 FROM champions;
