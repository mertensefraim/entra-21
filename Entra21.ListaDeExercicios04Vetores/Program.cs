using Entra21.ListaDeExercicios04Vetores;

Console.WriteLine(@"------------MENU------------
01 - Exercício 01
02 - Exercício 02
03 - Exercício 03
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

}
