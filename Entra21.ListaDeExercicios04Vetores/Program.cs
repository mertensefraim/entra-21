using Entra21.ListaDeExercicios04Vetores;

Console.WriteLine(@"------------MENU------------
01 - Exercício 00
01 - Exercício 01
02 - Exercício 02
03 - Exercício 03
04 - Exercício 04
05 - Exercício 05
06 - Exercício 06
07 - Exercício 07
09 - Exercício 09
11 - Exercício 11
12 - Exercício 12
");

Console.Write("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDesejada == 1)
{
    var exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 2)
{
    var exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if (opcaoDesejada == 3)
{
    var exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if (opcaoDesejada == 4)
{
    var exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if (opcaoDesejada == 5)
{
    var exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 6)
{
    var exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (opcaoDesejada == 7)
{
    var exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
else if (opcaoDesejada == 9)
{
    var exercicio09 = new Exercicio09();
    exercicio09.Executar();
}
else if (opcaoDesejada == 11)
{
    var exercicio11 = new Exercicio11();
    exercicio11.Executar();
}
else if (opcaoDesejada == 12)
{
    var exercicio12 = new Exercicio12();
    exercicio12.Executar();
}