CREATE TABLE enderecos (
	id INTEGER PRIMARY KEY IDENTITY(1, 1),
	estado VARCHAR(2),
	cidade VARCHAR(140),
	bairro VARCHAR(120),
	cep VARCHAR(10),
	logradouro VARCHAR(250),
	numero INTEGER,
	complemento TEXT
);

INSERT INTO enderecos(estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AC', 'Rio branco', 'Ayrton Senna', '69.911-866', 'Estrada Deputado José Rui da Silveira Lino', 282, 'Casa');

INSERT INTO enderecos(estado, cidade, bairro, cep, numero)
VALUES('SC', 'Biguaçu', 'Fundos', '88.161-400', 995);

INSERT INTO enderecos(estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('MG', 'Santa Luzia', 'Padre Miguel', '33.082-050', 'Rua Buenos Aires', 371, 'Apartamento');

INSERT INTO enderecos(estado, bairro, cep, logradouro, numero)
VALUES('BA', 'São Tomé de Paripe', '40.800-361', 'Travessa Luís Hage', 685);

 INSERT INTO enderecos(estado, cidade, bairro, logradouro, numero)
VALUES('MG', 'Ipatinga', 'Vaila Celeste', 'Rua Antônio Boaventura Batista', 645);

INSERT INTO enderecos(estado, cidade, bairro, cep, numero)
VALUES('RS', 'Passo Fundo', 'Nenê Graeff', '99.030-250', 154);

INSERT INTO enderecos(estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AM', 'Manaus', 'Petrópolis', '69.079-300', 'Rua Coronel Ferreira Sobrinho', 264, 'Fundos');

INSERT INTO enderecos(estado, cidade, bairro, cep, logradouro, numero)
VALUES('TO', 'Gurupi', 'Muniz Santana', '77.402-130', 'Rua Adelmo Aires Negri', 794);

INSERT INTO enderecos(estado, bairro, logradouro, numero, complemento)
VALUES('AC', 'Preventório', 'Beco da Ligação II', 212, 'Bloco B');

INSERT INTO enderecos(estado, cidade, bairro, cep, logradouro, numero)
VALUES('AP', 'Santana', 'Comercial', '68.925-073', 'Rua Calçoene', 648);

INSERT INTO enderecos(estado, cidade, bairro, cep, logradouro, numero)
VALUES('PB', 'Cabedelo', 'Camalaú', '58.103-052', 'Rua Siqueira Campos', 249);

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento FROM enderecos;

UPDATE enderecos SET logradouro = 'Rua Julio Teodoro Martins', complemento = 'de 2222 a 3046 - lado par' WHERE id = 2;

UPDATE enderecos SET cidade = 'Salvador', complemento = 'lado ímpar' WHERE id = 4;

UPDATE enderecos SET cep = '35.162-484', complemento = 'lado ímpar' WHERE id = 5;

UPDATE enderecos SET logradouro = 'Rua Itu', complemento = 'lado par' WHERE id = 6;

UPDATE enderecos SET complemento = 'lado par' WHERE id = 7;

UPDATE enderecos SET cep = '69.900-162', complemento = 'até 1498/1499' WHERE id = 8;

UPDATE enderecos SET complemento = 'lado par' WHERE id = 9;

UPDATE enderecos SET complemento = 'lado par' WHERE id = 10;

UPDATE enderecos SET complemento = 'lado ímpar' WHERE id = 11;