Console.WriteLine("Введите возводимое в степень число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int index = Convert.ToInt32(Console.ReadLine());
int res=num;
for (int i = 1; i < index; i++)
{
    res=res*num;
}
Console.WriteLine($"Число {num} в степени {index} равно: {res}");


// Console.WriteLine("Введите возводимое в степень число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень числа: ");
// int index = Convert.ToInt32(Console.ReadLine());
// double res=Math.Pow(num,index);
// Console.WriteLine($"число {num} в степени {index} равно: {res}");