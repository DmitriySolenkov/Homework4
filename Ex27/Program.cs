Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res=0;
int numMod=num;
while (numMod>0)
{
    res=res+numMod%10;
    numMod=numMod/10;
}
Console.WriteLine($"Сумма цифр в числе {num} равна {res}");