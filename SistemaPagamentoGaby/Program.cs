using System;
using SistemaPagamentoGaby.Classes;

namespace SistemaPagamentoGaby
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
Escolha um método de pagamento:
Q - Boleto
W - Crédito
E - Débito
R - Pix
T - Carnê
Y - Cancelar pagamento
    ");
                string opcao = Console.ReadLine().ToLower();
                

                switch (opcao)
                {
                    case "q":
                        Boleto boletoInstanc = new Boleto();                
                        boletoInstanc.Registrar();
                        opcaoValida = true;
                        break;
                    case "w":
                        Credito cartaoCredInst = new Credito();
                        Console.WriteLine(cartaoCredInst.SalvarCartao());
                        cartaoCredInst.Pagar();
                        opcaoValida = true;
                        break;
                    case "e":
                        Debito cartaoDebInst = new Debito();                    
                        Console.WriteLine(cartaoDebInst.SalvarCartao());
                        cartaoDebInst.Pagar();
                        opcaoValida = true;
                        break;
                    case "r":
                        pix pixInstanc = new pix();                
                        pixInstanc.Registrar();
                        opcaoValida = true;
                        break;
                    case "t":
                        carne carneInstanc = new carne();                
                        carneInstanc.Registrar();
                        opcaoValida = true;
                        break;
                    case "y":
                        Pagamento pagamentoInst = new Pagamento();
                        Console.WriteLine(pagamentoInst.Cancelar());                        
                        opcaoValida = true;
                        break;
                    default:
                        Console.WriteLine("Opção de pagamento inválida!");
                        opcaoValida = false;
                        break;
                }                
            } while (!opcaoValida);
        }
    }
}
