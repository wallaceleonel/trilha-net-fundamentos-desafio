namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //Implementado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            //Implementado
            string placa = Console.ReadLine();
            foreach (var veiculo in veiculos)
            {
                if(veiculo == placa)
                {
                    veiculos.Remove(placa);
                    Console.WriteLine("Veiculo removido com sucesso!");
                }
            }

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                var horas = Console.ReadLine();
               //Implementado
                decimal valorTotal = 0; 
                valorTotal = (precoInicial + precoPorHora) * Convert.ToInt32(horas);

                //Implementado
                RemoverVeiculo();
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                //Implementado
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
