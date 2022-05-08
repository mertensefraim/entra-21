using Entra21.ListaDeExercicios03___While;
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
10 - Exercício 10");

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