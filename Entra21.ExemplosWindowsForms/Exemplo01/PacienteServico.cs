using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class PacienteServico
    {
        private List<Paciente> pacientes;

        public PacienteServico()
        {
            pacientes = new List<Paciente>();

            LerArquivo();
        }

        // Método que expôes a lista de pacientes que tem o encapsulamento privado
        public List<Paciente> ObterTodos()
        {
            return pacientes;
        }

        private void LerArquivo()
        {
            // Verificar se o arquivo existe
            if (File.Exists("pacientes.json") == false)
                return;

            // Ler arquivo Json com a lista de pacientes
            var pacientesJson = File.ReadAllText("pacientes.json");

            // Converter JSON para lista de ojetos de pacientes
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(pacientesJson);

        }

        public Paciente ObterPorNomePaciente(string nomePaciente)
        {
            // Percorrer a lista de pacientes para encontrar o paciente por nome
            for (int i = 0; i < pacientes.Count; i++)
            {
                // Obter o paciente que está sendo percorrido
                var paciente = pacientes[i];

                // Verificar se o paciente atual contém o nome do paciente escolhido
               if (paciente.Nome == nomePaciente)
                    return paciente;
            }

            // Retorna null quando não encontrar nenhum paciente com o mesmo nome do paciente escolhido
            return null;
        }
    }
}
