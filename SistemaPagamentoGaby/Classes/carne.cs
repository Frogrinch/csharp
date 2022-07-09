using System;


namespace SistemaPagamentoGaby
{
    public class carne : Pagamento
    {
        private string CodigoDeBarras;
             
        Random numRand = new Random();

    
        
        public void Registrar() {
        int vezes;
        float valor = this.Valor;
            CodigoDeBarras = numRand.Next(900000000).ToString();
            Console.Clear();
            Console.WriteLine($"Carnê gerado com o código {CodigoDeBarras}");
            Console.WriteLine($"O valor do carnê é de R${( this.Valor * 1.23 ).ToString("N2")}!");
             
            do
                {
                    Console.WriteLine($"Em quantas vezes deseja parcelar o valor R${valor}? (De 1 à 12)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes <= 6 && vezes >= 0) {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 12% no valor total");
                        Console.WriteLine($"Você pagará no total R${(valor * 1.12).ToString("N2")}");

                    } else if (vezes >= 7 && vezes <= 12) {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 18% no valor total");
                        Console.WriteLine($"Você pagará no total R${(valor * 1.18).ToString("N2")}");

                    } else {
                        Console.WriteLine("Impossível parcelar o pagamento mais de 12x, escolha um numero de parcelas menor que 12");
                    }                    
                } while (vezes > 12);
        }
    }
}