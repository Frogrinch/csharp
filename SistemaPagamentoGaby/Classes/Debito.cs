using System;

namespace ExemploPilaresPOO.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 600f;

        public override void Pagar() {
            float valor = this.Valor;
         
            
            if (valor > Saldo) {
                Console.WriteLine("Pagamento não aprovado. Saldo insuficiente!");
            } else {
                Console.WriteLine($"O valor de R${valor.ToString("N2")} foi pago com sucesso!");
            }
        }
    }
}