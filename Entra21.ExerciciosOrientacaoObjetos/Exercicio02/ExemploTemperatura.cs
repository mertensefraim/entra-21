using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 30;
            temperatura.EscalaOrigem = "celsius";
            temperatura.EscalaDestino = "farenheit";

            var escalaOrigem = temperatura.EscalaOrigem;
            var escalaDestino = temperatura.EscalaDestino;
            var temperaturaFinal = temperatura.VerificarEscalaOrigem();

            Console.WriteLine($"Escala de Origem: {escalaOrigem}" +
                $"\nEscala de Destino: {escalaDestino}" +
                $"\nTemperatura final: {}");
        }
    }
}
