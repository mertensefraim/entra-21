﻿using Entra21.ListaDeExercicios03___While;
using Entra21.ListaDeExercícios03While;

Console.WriteLine(@"------------MENU------------
01 - Exercício 01
02 - Exercício 02
03 - Exercício 03
04 - Exercício 04    
05 - Exercício 05
06 - Exercício 06
07 - Exercício 07
08 - Exercício 08
09 - Exercício 09
10 - Exercício 10
11 - Exercício 11
12 = Exercício 12
13 = Exercício 13
14 - Exercício 14
15 - Exercício 15
16 - Exercício 16
17 - Exercício 17
18 - Exercício 18
19 - Exercício 19");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if(opcaoDesejada == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if(opcaoDesejada == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (opcaoDesejada == 7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (opcaoDesejada == 9)
{
    Exercicio09 exercicio09 = new Exercicio09();
    exercicio09.Executar();
}
else if (opcaoDesejada == 10)
{
    Exercicio10 exercicio10 = new Exercicio10();
    exercicio10.Executar();
}
else if (opcaoDesejada == 11)
{
    Exercicio11 exercicio11 = new Exercicio11();
    exercicio11.Executar();
}
else if (opcaoDesejada == 12)
{
    Exercicio12 exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
else if (opcaoDesejada == 13)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}
else if (opcaoDesejada == 14)
{
    Exercicio14 exercicio14 = new Exercicio14();
    exercicio14.Executar();
}
else if (opcaoDesejada == 15)
{
    Exercicio15 exercicio15 = new Exercicio15();
    exercicio15.Executar();
}
else if (opcaoDesejada == 16)
{
    Exercicio16 exercicio16 = new Exercicio16();
    exercicio16.Executar();
}
else if (opcaoDesejada == 17)
{
    Exercicio17 exercicio17 = new Exercicio17();
    exercicio17.Executar();
}
else if (opcaoDesejada == 18)
{
    var exercicio18 = new Exercicio18_desafio();
    exercicio18.Executar();
}
else if (opcaoDesejada == 19)
{
    var exercicio19 = new Exercicio19();
    exercicio19.Executar();
}