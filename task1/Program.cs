Console.WriteLine("Введите первое число: ");
int numFirst  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());

if (numFirst > numSecond)
{
    Console.WriteLine("Первое число " + numFirst + " больше чем второе число " + numSecond);
}
else if (numFirst < numSecond)
{
    Console.WriteLine("Второе число " + numSecond + " больше чем первое число " + numFirst);
}
else 
{
    Console.WriteLine("Числа " + numFirst + " и " + numSecond + " равны");
}
