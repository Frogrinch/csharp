using System;


namespace SistemaPagamentoGaby
{
    public class Boleto : Pagamento
    {
        private string CodigoDeBarras;
             
        Random numRand = new Random();
    
        
        public void Registrar() {
            CodigoDeBarras = numRand.Next(30000000).ToString();
            Console.Clear();
            Console.WriteLine($"Boleto gerado com o código {CodigoDeBarras}");
            Console.WriteLine($"Boleto registrado com desconto, o valor agora é de R${( this.Valor * 0.88 ).ToString("N2")}!");
        }
    }
}