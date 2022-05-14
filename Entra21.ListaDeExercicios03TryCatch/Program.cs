using Entra21.ListaDeExercicios03TryCatch;

Console.WriteLine(@"------------MENU------------
01 - Exercício 01
05 - Exercício 05
08 - Exercício 08
10 - Exercício 10
12 - Exercício 12
13 - Exercício 13
");

Console.Write("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDesejada == 1)
{
    var exercicio01 = new Exercicio01();
    exercicio01.Executar();
}