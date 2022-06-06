using Entra21.ListaDeExercicios06Listas;

Console.WriteLine(@"------------MENU------------
01 - Exercício 01
02 - Exercício 02
03 - Exercício 03");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDesejada == 1)
{
    var exercicio = new Exercicio01();
    exercicio.Executar();
}
else if (opcaoDesejada == 2)
{
    var exercicio = new Exercicio02();
    exercicio.Executar();
}
else if (opcaoDesejada == 3)
{
    var exercicio = new Exercicio03();
    exercicio.Executar();
}
