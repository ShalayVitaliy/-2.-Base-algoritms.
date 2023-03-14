Console.Clear();
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100 || a >= 1000)
{
    Console.Write("Вы велли не трёхзначное число!");
}
else
    Console.Write(a % 10);