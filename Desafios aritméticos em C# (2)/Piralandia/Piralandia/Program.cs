﻿using System;

namespace Piralandia
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string v = Convert.ToString(n);
            string comunicacaoInvertida = "";

            for (int i = n.ToString().Length; i > 0; i--)
            {
                string decodificacao = v.Substring(i - 1, 1);
                comunicacaoInvertida += decodificacao;
            }
            
            Console.WriteLine(comunicacaoInvertida);
        }
    }
}


/*
 * 
 * Desafio
Os cientistas brasileiros descobriram um exoplaneta a 1 bilhão de anos luz da terra. 
Ele foi carinhosamente batizado de Piralândia, uma homenagem a cidade de Piracicaba, 
onde moram os cientistas. Após algum tempo observando esse planeta, os cientistas puderam 
ver que nele haviam habitantes e, além disso, esses habitantes estavam tentando fazer contato 
com os cientistas através de uma comunicação numérica. 

Só que a numeração que encontraram estava invertida e como muitas delas foram descobertas, 
os cientistas chamaram você para conseguir automatizar esse processo. Logo, dado um número 
grande, sua tarefa é imprimir esse número invertido.

Entrada
O arquivo contém apenas uma linha de teste que é o número encontrado (0 < n < 9999999999).

Obs.: Perceba que o número lido é muito alto para armazenar em uma variável do tipo int, 
logo você irá precisar utilizar o tipo long, que para a leitura e impressão em C, você 
deve utilizar o %llu.

Saída
Imprimir o número lido invertido. Não esqueça de imprimir a quebra de linha (\n) no final, 
caso contrário você receberá (Presentation Error).

*/