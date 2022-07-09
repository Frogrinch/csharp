using System;

namespace SistemaPagamentoGaby
{
    public class Credito : Cartao
    {
        private float Limite = 3000f;

        public override void Pagar() {

            int vezes;
            float valor = this.Valor;
            
            
            if (valor > Limite) {
                Console.WriteLine("O pagamento não foi aprovado. Limite insuficiente!");
            } else {                
                do
                {
                    Console.WriteLine($"Em quantas vezes deseja parcelar o valor R${valor}? (De 1 à 12)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes <= 6 && vezes >= 0) {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 5% no valor total");
                        Console.WriteLine($"Você pagará R${(valor * 1.05).ToString("N2")}");

                    } else if (vezes >= 7 && vezes <= 12) {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 5% no valor total");
                        Console.WriteLine($"Você pagará R${(valor * 1.08).ToString("N2")}");

                    } else {
                        Console.WriteLine("Impossível parcelar o pagamento mais de 12x, escolha um numero de parcelas menor que 12");
                    }                    
                } while (vezes > 12);               
            }
        }
    }
}