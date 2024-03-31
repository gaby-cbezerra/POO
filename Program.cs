using System;

int maior = 0;
int posMaior = 1;
int x;
    for (int i = 1; i <= 100; i++) {
	 x = int.Parse(Console.ReadLine());
			if (i == 1) {
				maior = x;
				posMaior = 1;
			} else if (x > maior) {
				maior = x;
				posMaior = i;
			}
		}
Console.WriteLine(maior);
Console.WriteLine(posMaior);
	





    
    