using System;
using ExemploPilaresPOO.Classes;

namespace ExemploPilaresPOO
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
B - Boleto
C - Crédito
D - Débito
Z - Cancelar pagamento
    ");
                string opcao = Console.ReadLine().ToLower();
                

                switch (opcao)
                {
                    case "b":
                        Boleto boletoInstanc = new Boleto();
                                         
                        boletoInstanc.Registrar();
                       
                        opcaoValida = true;
                        
                        break;
                        

                    case "c":
                        Credito cartaoCredInst = new Credito();
                        Console.WriteLine(cartaoCredInst.SalvarCartao());
                        cartaoCredInst.Pagar();
                        opcaoValida = true;
                        break;
                    case "d":
                        Debito cartaoDebInst = new Debito();                    
                        Console.WriteLine(cartaoDebInst.SalvarCartao());
                        cartaoDebInst.Pagar();
                        opcaoValida = true;
                        break;
                    case "z":
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
