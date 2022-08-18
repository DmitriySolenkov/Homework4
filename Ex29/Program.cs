Console.Write("Ввежите нижний порог чисел массива: ");
int loNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввежите верхний порог чисел массива: ");
int upNum = Convert.ToInt32(Console.ReadLine());
int[] array= new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(loNum,upNum);
}

for (int k = 0; k < array.Length; k++)
{
    Console.Write(array[k]+ ", ");
}
