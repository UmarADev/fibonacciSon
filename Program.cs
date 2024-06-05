using System;

int fibonacci1 = 0;
int fibonacci2 = 1;

Console.Write("son kiriting: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

while(fibonacci1 <= userNumber)
{
    int nextFibonacci = fibonacci1 + fibonacci2;
    fibonacci1 = fibonacci2;
    fibonacci2 = nextFibonacci;
    if (fibonacci1 == userNumber)
    {
        Console.WriteLine("Bu fibonacci son");
        break;
    }
}

if (fibonacci1 != userNumber)
{
    Console.WriteLine("Bu fibonacci son emas");
}
