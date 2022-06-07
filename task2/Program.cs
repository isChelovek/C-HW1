Console.WriteLine("Введите первое число: ");
int numFirst  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numThree = Convert.ToInt32(Console.ReadLine());

int max = numFirst;
if (numSecond > max) max = numSecond;
if (numThree  > max) max = numThree;

Console.WriteLine("Максимальное число: " + max);