using System;
using System.Threading.Tasks;
using Refit;

namespace APIcep
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var CEP = RestService.For<cepservice>("https://viacep.com.br/");

                Console.WriteLine("Informe o CEP: ");
                var cepInformado = (Console.ReadLine());

                while (!String.IsNullOrEmpty(cepInformado))
                {
                    var cep = await CEP.Getcep(cepInformado);
                    Console.WriteLine();

                    Console.WriteLine($"Logradouro: {cep.logradouro}");
                    Console.WriteLine($"Bairro: {cep.bairro}");
                    Console.WriteLine($"Localidade: {cep.localidade}");
                    Console.WriteLine($"UF: {cep.uf}");

                    Console.WriteLine();
                    Console.WriteLine("Informe o CEP: ");
                    cepInformado = (Console.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro na requisição: {e.Message}");
            }
        }
    }
}
