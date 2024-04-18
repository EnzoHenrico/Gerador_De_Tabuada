// Faça um programa que leia um valor inteiro positivo e imprima a sua tabuada.
int number = 0, multiplier = 0;

do
{
    Console.Write("Diga um número para gerar sua tabuada: ");
    number = int.Parse(Console.ReadLine());

    if (number <= 0)
    {
        Console.WriteLine("O multiplicador deve ser positivo.");
    }
}
while (number <= 0);


while (multiplier <= 10)
{
    Console.WriteLine($"{number} x {multiplier} = {number * multiplier}");
    multiplier++;
}

// Adicionando comentário
