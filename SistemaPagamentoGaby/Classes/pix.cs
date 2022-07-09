using System;
using SistemaPagamentoGaby;

namespace SistemaPagamentoGaby.Classes
{
    public class pix : Pagamento
    {
          private string ChavePix;
             
        Random numRand = new Random();
    
        
        public void Registrar() {
            ChavePix = numRand.Next(300000000).ToString();
            Console.Clear();
            Console.WriteLine($"Chave aleatória pix gerada com o código {ChavePix}");
            Console.WriteLine($"Pagamento registrado com desconto, o valor agora é de R${( this.Valor * 0.88 ).ToString("N2")}!");
             Console.WriteLine($"Para realizar o pagamento, copie e cole o código acima em seu app/internet banking de preferência.");
        }
    }
}
    