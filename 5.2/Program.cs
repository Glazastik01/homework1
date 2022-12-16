

namespace mass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            Random random = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 1000);
            }
            Console.WriteLine($"{string.Join(" ", arr)}");
            Console.WriteLine($"Минимальное и максимальное значения массива: {string.Join(" ", MaxMin(arr))}");
        }

        public static int[] MaxMin(int[] arr)
        {
            int[] maxmin = new int[2];
            int max = 0, min = 100;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                    maxmin[0] = min;
                }

                if (arr[i] > max)
                {
                    max = arr[i];
                    maxmin[1] = max;
                }
            }
            return maxmin;
        }
    }
}