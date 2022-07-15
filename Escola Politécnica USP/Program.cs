using System;

namespace _250522
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("UNIVERSIDADE DE SÃO PAULO");
            Console.WriteLine("Escola Politécnica");
            string name;
            string idade;
            double nota1,nota2,nota3,nota4;
            double media;
            string curso;
            string cpf;

    Console.Write("Insira o nome do aluno: ");
    name = Console.ReadLine();
    Console.Write("Insira a idade do aluno: ");
    idade = Console.ReadLine();
    Console.Write("Insira o CPF do aluno: ");
    cpf = Console.ReadLine();
    Console.Write("Insira o curso do aluno: ");
    curso = Console.ReadLine();

            switch(curso){

                case "Engenharia Mecânica":
                Console.WriteLine("Curso do Aluno: Eng. Mecânica");
                break;

                case "Engenharia da Computação":
                Console.WriteLine("Curso do Aluno: Eng. da Computação");
                break;

                case "Engenharia Civil":
                Console.WriteLine("Curso do Aluno: Eng. Civil");
                break;

                case "Engenharia Química":
                Console.WriteLine("Curso do Aluno: Eng. Química");
                break;

                case "Engenharia de Minas":
                Console.WriteLine("Curso do Aluno: Eng. de Minas");
                break;

                default:
                Console.WriteLine("Curso não encontrado, escolha um curso POLI-USP para prosseguir.");
                break;
            }

    Console.Write("Insira a nota de Cálculo Diferencial e Integral I: ");
    nota1=Convert.ToDouble(Console.ReadLine());
    Console.Write("Insira a nota de Física I: ");
    nota2=Convert.ToDouble(Console.ReadLine());
    Console.Write("Insira a nota de Geometria Analítica e Álgebra Linear: ");
    nota3=Convert.ToDouble(Console.ReadLine());
    Console.Write("Insira a nota de Fundamentos das Transformações Químicas: ");
    nota4=Convert.ToDouble(Console.ReadLine());

    media = ( nota1 + nota2 + nota3 + nota4) / 4;

    Console.Clear();

   if(media >=5.0)
   {
     Console.Write("O aluno(a) " + name + ", "+idade+ " anos, do curso de " +curso+ ", portador(a) do CPF n°" +cpf+ ", está aprovado(a) com a média " +media);
     Console.WriteLine();
     Console.Write("Escola Politécnica da USP - 2022");
   }
   else
   {
     Console.WriteLine("O aluno(a) " +name + ", "+idade+" anos, do curso de " +curso+ ", portador(a) do CPF n°" +cpf+  ", está reprovado(a) com a média " +media);
     Console.Write("Escola Politécnica da USP - 2022");
   }

   Console.ReadKey();
   }
 }
}

