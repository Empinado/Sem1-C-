Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 / number2 == number2)
{
    Console.Write($"Да, число {number1} является корнем {number2}");
}
else
{
    Console.Write($"Нет, число {number1} не является корнем {number2}");
}