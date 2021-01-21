using System;

namespace Calcula_média_de_aluno_csharp
{
    class Aluno
    {
        static void Main(string[] args)
        {
            /// Declaração de Variáveis
            double n1, n2, n3, n4, media;

            //Solicita e lê a primeira nota do aluno
            Console.Write("Informe a 1ª Nota:");
            n1 = double.Parse(Console.ReadLine());

             //Solicita e lê a segunda nota do aluno
            Console.Write("Informe a 2ª Nota:");
            n2 = double.Parse(Console.ReadLine());

            //Solicita a terceira nota do aluno
            Console.Write("Informe a 3ª Nota:");
            n3 = double.Parse(Console.ReadLine());

            //Solicita a quarta nota do aluno
            Console.Write("Informe a 4ª Nota:");
            n4 = double.Parse(Console.ReadLine());

            //Agora calcula a média do aluno

            media = (n1 + n2 + n3 + n4)/4;

            //Agora verificar se o aluno foi aprovado ou não

            if (media >=7)
            Console.WriteLine("Aluno(a) foi Aprovado(a), sua média foi igual: {0}", media);

            else 
            Console.WriteLine("Aluno(a) foi reprovado(a), sua média foi igual: {0}", media);
        }
    }
}
