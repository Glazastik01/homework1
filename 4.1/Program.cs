Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int number = 0;
try
{
    int[] nums = new int[a];
    for (int i = 0; i < nums.Length; i++)
    {while (number % 5 != 2)
        {
            number++;
        }
        nums[i] = number;
        Console.WriteLine("Позиция {0} = {1}", i + 1, nums[i]);
        number++;
    }
}
catch
{
    Console.WriteLine("Введено неверное значение");
}