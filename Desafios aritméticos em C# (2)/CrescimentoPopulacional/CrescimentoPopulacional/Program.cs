using System;
using System.Globalization;

namespace CrescimentoPopulacional
{
    class Program
    {
        static void Main(string[] args)
        {

            int testes = int.Parse(Console.ReadLine());            
            int pa, pb, anos;
            double G1, G2;

            for (int i = 0; i < testes; i++)
            {
                
                string[] valores = Console.ReadLine().Split(' ');
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);                
                G1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
                G2 = double.Parse(valores[3], CultureInfo.InvariantCulture);
                anos = 0;

                while (pa <= pb && anos < 101)
                {

                    pa += (int)((pa * G1)/100);
                    pb += (int)((pb * G2)/100);
                    anos++;
                }

                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                   
                }
                else 
                {
                    Console.WriteLine(anos + " anos.");
                }
                
            }

        }

    }
}


/*
 * 
 * Desafio:
 
O Governador do Estado quer saber sobre as taxas de crescimento das cidades. De acordo com dados da população
e a taxa de crescimento de duas cidades quaisquer (A e B), ele quer que você calcule quantos anos levará para 
que a cidade menor (A) cresça mais em população que a cidade maior (B).

Claro que o Governador quer saber apenas para as cidades cuja taxa de crescimento da cidade A é maior do que a taxa 
de crescimento da cidade B, portanto, previamente já separou para você apenas os casos de teste que tem a taxa 
de crescimento maior para a cidade A.

Desenvolva um programa que apresente o tempo, em anos, para cada caso.

Porém, em alguns casos o tempo pode ser muito grande, e o Governador não se interessa em saber exatamente o tempo 
para estes casos, já que ele pode não estar mais eleito. Basta que você informe, nesta situação, a mensagem "Mais de 1 século.".

*/