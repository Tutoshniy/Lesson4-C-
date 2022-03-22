// Я использовал диапазон от 0 до 1000, потому что был очень большой разброс чисел. Если нужно использовать абсолютный рандом для int, 
// То можно использовать вместо new Random().Next(0, 1000) - new Random().Next()
Console.Clear();
int numbers = 0;
int [] nums = new int [123];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(0, 1000);
    if (nums[i] >= 10)
    {
        if (nums[i] <= 99)
        {
            numbers++;   
        }
    }
}
Console.WriteLine();
Console.Write("Количество чисел в диапазоне от 10 (включительно) до 99 (включительно): ");
Console.WriteLine(numbers);