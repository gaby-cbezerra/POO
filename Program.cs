using System;

int numRep = int.Parse(Console.ReadLine());
int dentro = 0;
int fora = 0;
for ( int n = 0; n < numRep; n++){
    int x = int.Parse(Console.ReadLine());
    if ( x >= 10 && x <= 20){
        dentro++;
    }
    else 
        fora++;
    
}
Console.WriteLine($"{dentro} in");
Console.WriteLine($"{fora} out");