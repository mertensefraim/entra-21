using Entra21.ListaDeExercicios03TryCatch;

Console.WriteLine(@"------------MENU------------
01 - Exercício 01
05 - Exercício 05
08 - Exercício 08
10 - Exercício 10
12 - Exercício 12
13 - Exercício 13
14 - Exercício 14
");

Console.Write("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDesejada == 1)
{
    var exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 5)
{
    var exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 8)
{
    var exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (opcaoDesejada == 10)
{
    var exercicio10 = new Exercicio10();
    exercicio10.Executar();
}
else if (opcaoDesejada == 12)
{
    var exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
else if (opcaoDesejada == 13)
{
    var exercicio13 = new Exercicio13();
    exercicio13.Executar();
}
else if (opcaoDesejada == 14)
{
    var exercicio14 = new Exercicio14();
    exercicio14.Executar();
}
