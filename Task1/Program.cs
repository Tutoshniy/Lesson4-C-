Console.Clear();
int chet = 0;
int nechet = 0;
Console.Write("Введите количество чисел в массиве: ");
int [] nums = new int [Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(100, 1000);
    if (nums[i] % 2 == 0)
    {
        chet++;
    }
    else
    {
        nechet++;
    }
}
Console.Write("Количество чётных чисел в массиве равно ");
Console.WriteLine(chet);
Console.Write("Количество нечётных чисел в массиве равно ");
Console.WriteLine(nechet);