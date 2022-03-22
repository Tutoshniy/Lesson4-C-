Console.Clear();
Console.WriteLine("Введите длину массива ");
int N = Convert.ToInt32(Console.ReadLine());
int [] nums = new int [N];
void Mass(int a)
{
    for (int i = 0; i < a; i++)
    {
        nums[i] = new Random().Next(0,1001);
    }
}
Mass(N);
Console.WriteLine("Произведения пар чисел: ");
for (int i = 0; i < nums.Length/2; i++)
{
    Console.WriteLine(nums[i] * nums[nums.Length-1-i]);
}