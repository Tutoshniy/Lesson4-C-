Console.Clear();
int sum = 0;
Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] nums = new int[N];
for (int i = 0; i < N; i++)
{
    nums[i] = new Random().Next(0, 1000);
    if (i % 2 == 0)
    {
        sum += nums[i];
    }
}
Console.Write("Сумма чисел на нечётных позициях равна ");
Console.WriteLine(sum);
