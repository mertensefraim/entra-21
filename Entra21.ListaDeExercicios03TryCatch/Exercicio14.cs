namespace Entra21.ListaDeExercicios03TryCatch
{
    internal class Exercicio14
    {
        public void Executar()
        {
            // 1 | 1 | 2 | 3 | 5 | 8 | 13 | 21 | 34

            var valor1 = 1;
            var valor2 = 1;

            Console.Write(valor1 + "|");
            for (var i = 1; i < 20; i++)
            {
                valor1 = +valor2;
                valor2 = valor1 - valor2;

                Console.Write(valor2 + "|");
            }


        }
    }
}
