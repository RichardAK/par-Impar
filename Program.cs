int numerocolocado;

Console.Write("Digite um número:");
numerocolocado = Convert.ToInt32(Console.ReadLine());

bool numeropar = (numerocolocado % 2) == 0;

if (numeropar)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{numerocolocado} é par");
    
}

else
{
    Console.WriteLine($"{numerocolocado} é impar");
    Console.Beep();
}

Console.ResetColor();