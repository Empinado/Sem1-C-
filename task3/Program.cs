Console.Write("Введите числовой номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.Write("Понедельник");
}
if (number == 2)
{
    Console.Write("Вторник");
}
if (number == 3)
{
    Console.Write("Среда");
}
if (number == 4)
{
    Console.Write("Четверг");
}
if (number == 5)
{
    Console.Write("Пятница");
}
if (number == 6)
{
    Console.Write("Суббота");
}
if (number == 7)
{
    Console.Write("Воскресение");
}
if (number > 7)
{
    Console.Write("В неделе всего 7 дней, попробуйте снова.");
}
if (number < 1)
{
    Console.Write("В неделе всего 7 дней, попробуйте снова.");
}    

