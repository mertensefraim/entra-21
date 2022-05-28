﻿using Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio01;
using Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio02;


Console.WriteLine(@"Tabela
Exercício 01 - 01
Exercício 02 - 02
Exercício 03 - 03
Exercício 04 - 04
Exercício 05 - 05");
var valorUsuario = Convert.ToInt32(Console.ReadLine());

if (valorUsuario == 1)
{
    var exercicio = new ExemploLivro();
    exercicio.Executar();
}
else if (valorUsuario == 2)
{
    var exercicio = new ExemploTemperatura();
    exercicio.Executar();
}
