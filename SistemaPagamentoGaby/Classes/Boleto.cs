using System;


namespace SistemaPagamentoGaby
{
    public class Boleto : Pagamento
    {
        private string CodigoCarnê;
             
        Random numRand = new Random();
    
        
        public void Registrar() {
            CodigoCarnê = numRand.Next(30000000).ToString();
            Console.Clear();
            Console.WriteLine($"Boleto gerado com o código {CodigoCarnê}");
            Console.WriteLine($"Boleto registrado com desconto, o valor agora é de R${( this.Valor * 0.88 ).ToString("N2")}!");
        }
    }
}