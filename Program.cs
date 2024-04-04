using System;

int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split();
            double valor1 = double.Parse(valores[0]);
            double valor2 = double.Parse(valores[1]);
            double valor3 = double.Parse(valores[2]);

            double media = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;
            Console.WriteLine(media.ToString("F1"));
        }  