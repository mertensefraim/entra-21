SELECT id, nome, codigo, categoria, descricao, altura, peso, hp, ataque, defesa, especial_ataque, especial_defesa, velocidade FROM pokemons;

SELECT ataque, especial_ataque, defesa, especial_defesa FROM pokemons;

SELECT nome, categoria, ataque FROM pokemons ORDER BY ataque DESC;

SELECT altura, peso, (peso / (altura * altura)) AS imc FROM pokemons;

SELECT altura, peso, (peso / (altura * altura)) AS imc FROM pokemons ORDER BY imc DESC;

SELECT nome, LEN(nome) AS 'tamanho nome' FROM pokemons ORDER BY nome DESC;

SELECT nome, descricao FROM pokemons WHERE LEN(nome) > 10;

SELECT TOP(1) nome, categoria, ataque FROM pokemons ORDER BY ataque ASC;
-- OU
SELECT nome, categoria, ataque FROM pokemons WHERE ataque = (SELECT MIN(p.ataque) FROM pokemons p); 

SELECT ataque, especial_ataque, nome, defesa, especial_defesa FROM pokemons ORDER BY ataque ASC;

SELECT AVG(CAST(ataque as decimal)) AS 'Média dos ataques' FROM pokemons;

SELECT SUM(ataque) AS 'Soma dos ataques' FROM pokemons;

SELECT AVG(especial_ataque) AS 'Média dos ataques' FROM pokemons WHERE nome LIKE 'P%';

-- Cidades

--1. Selecione o estado e cidade.
SELECT estado, cidade FROM cidades;

--2. Selecione as cidades que começam com a letra A.
SELECT cidade FROM cidades WHERE cidade LIKE 'A%';

--3. Selecione as cidades que contenham no ‘apar’ em qualquer parte do nome
SELECT cidade FROM cidades WHERE cidade LIKE '%apar%';

--4. Selecione as cidades que começam com a letra W.
SELECT cidade FROM cidades WHERE cidade LIKE 'W%'

--5. Selecione o estado e a cidade que a cidade termina com ‘tuba’ ordenando pelo estado em ordem decrescente.
SELECT estado, cidade FROM cidades WHERE cidade LIKE '%tuba';

--6. Selecione a cidade que o nome da cidade contenha mais que 15 caracteres, ordenando pelo quantidade de caracteres.
SELECT cidade FROM cidades WHERE LEN(cidade) > 15 ORDER BY LEN(cidade) ASC;

--7. Contabilize a quantidade de cidades do estado de SC.
SELECT COUNT(cidade) FROM cidades WHERE estado = 'SC';

--8. Contabilize a quantidade de cidades do estado de SP.
SELECT COUNT(cidade) FROM cidades WHERE estado = 'SP';

--9. Selecione o nome da cidade com a quantidade de caracteres, quando o nome da cidade conte 10 caracteres.
SELECT cidade, LEN(cidade) AS 'Quantidade caracteres' FROM cidades WHERE LEN(cidade) > 10;

-- ALUNOS

--1. Selecione todas as colunas da tabela.
SELECT id, nome, cpf, nick, signo, numero_favorito, nota_1, nota_2, nota_3, nota_4, cor_preferida, data_nascimento FROM alunos;

--2. Selecione o nome dos alunos que a nota 1 é maior que 9.0.
SELECT nome FROM alunos WHERE nota_1 < 9.0;

--3. Selecione o nome do aluno, nota 1, nota 2, nota 3, nota 4, e a média.
SELECT nome, nota_1, nota_2, nota_3, nota_4, ((nota_1 + nota_2 + nota_3 + nota_4) / 4) AS 'média' FROM alunos;

--4. Contabilize a quantidade de alunos com o signo de Peixes
SELECT COUNT(id) FROM alunos WHERE signo = 'Peixes';

--5. Selecione a soma da nota 1
SELECT SUM(nota_1) FROM alunos; 

--6. Selecione a média da nota 2
SELECT AVG(nota_2) FROM alunos;

--7. Selecione o nome, menor nota 1.
SELECT nome FROM alunos WHERE nota_1 = (SELECT MIN(p.nota_1) FROM alunos p);
-- OU
SELECT nome FROM alunos WHERE nota_1 = (SELECT MIN(nota_1) FROM alunos);

--8. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o maior nome.
SELECT nome, nota_1, nota_2, nota_3, nota_4 FROM alunos WHERE LEN(nome) = (SELECT MAX(LEN(nome)) FROM alunos);

--9. Selecione a cor e quantidade com a cor Gelo. ?????
SELECT 'Gelo', COUNT(cor_preferida) FROM alunos WHERE cor_preferida LIKE 'Gelo';

--10. Selecione a quantidade de alunos que o nome contém Francisco no começo.
SELECT COUNT(id) FROM alunos WHERE nome LIKE 'Francisco%'

--11. Selecione a quantidade de alunos que o nome contém Luc.
SELECT COUNT(id) FROM alunos WHERE nome LIKE '%Luc%'

--12. Selecione o nome, signo e data de nascimento quando o signo Áries
SELECT nome, signo, data_nascimento FROM alunos WHERE signo = 'Áries';

--13. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o maior média.
SELECT nome, nota_1, nota_2, nota_3, nota_4 FROM alunos WHERE ((nota_1 + nota_2 + nota_3 + nota_4) / 4) = (SELECT MAX(((nota_1 + nota_2 + nota_3 + nota_4) / 4)) FROM alunos);

--14. Selecione o nome, média e caso a média for menor que 5 apresentar reprovado, caso for menor que 7
--apresentar em exame senão apresentar aprovado.
--Dica: buscar como fazer IF em sql.
SELECT nome, (nota_1 + nota_2 + nota_3 + nota_4) / 4, 
	CASE 
		WHEN ((nota_1 + nota_2 + nota_3 + nota_4) / 4) < 5.0 then 'Reprovado'
		WHEN ((nota_1 + nota_2 + nota_3 + nota_4) / 4) < 7.0 then 'Em exame'
		ELSE 'Aprovado'
	END
FROM alunos;

--15. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o menor média.
SELECT nome, nota_1, nota_2, nota_3, nota_4 FROM alunos WHERE (nota_1 + nota_2 + nota_3 + nota_4) / 4 = (SELECT MIN((nota_1 + nota_2 + nota_3 + nota_4) / 4) FROM alunos);

--16. Selecione a quantidade de alunos em que a média foi maior que 7
SELECT nome, nota_1, nota_2, nota_3, nota_4 FROM alunos WHERE (nota_1 + nota_2 + nota_3 + nota_4) / 4 < 7.0;

--17. Selecione o nome, nick do aluno que o nick contém 5 caracteres.
SELECT nome, nick FROM alunos WHERE LEN(nick) = 5;

--18. Selecione o nome do aluno quando a cor for ouro ou amarelo-torrado e a média for maior que seis e meio.
SELECT nome, cor_preferida FROM alunos WHERE cor_preferida = 'Ouro' OR cor_preferida = 'amarelo-torrado' AND (nota_1 + nota_2 + nota_3 + nota_4) / 4 > 6.5;

--19. Selecione o nome e o ano da data de nascimento.
SELECT nome, YEAR(data_nascimento) FROM alunos;

--20. Selecione o nick e o mês de nascimento quando o mês de nascimento for maior que 6.
SELECT nick, MONTH(data_nascimento) FROM alunos WHERE MONTH(data_nascimento) > 6;

--21. Selecione a quantidade de pessoas que nasceram no ano de 1996
SELECT COUNT(id) FROM alunos WHERE YEAR(data_nascimento) = 1996;

--22. Selecione a quantidade de pessoas de pessoas que nasceram no dia dois do mês de fevereiro do ano 1964 ou 1994.
SELECT COUNT(id) FROM alunos WHERE MONTH(data_nascimento) = 2 AND (YEAR(data_nascimento) = 1964 OR YEAR(data_nascimento) = 1994);  

--23. Selecione o nick e a nota 4 do aluno que a nota 2 está entre 5.0 e 5.99.
SELECT nick, nota_4 FROM alunos WHERE nota_2 >= 5.0 AND nota_2 <= 5.99;

--24. Apresentar a média da aluna Josefina.
SELECT nome, (nota_1 + nota_2 + nota_3 + nota_4) / 4 FROM alunos WHERE nome LIKE 'Josefina%'

--25. Apresentar nome, nick, nota 1, nota 2, nota 3, nota 4, quando o nome conter Justino e o signo começar com ‘A’.
SELECT nome, nick, nota_1, nota_2, nota_3, nota_4 FROM alunos WHERE nome LIKE '%Justino%'AND signo LIKE 'A%';

--26. Apresentar a média das médias.
SELECT AVG((nota_1 + nota_2 + nota_3 + nota_4) / 4) FROM alunos;