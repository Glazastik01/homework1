int size = 11;
double pow;
int[] arr = new int[size];
for (int k = 0; k < arr.Length; k++)
{
    pow = (Math.Pow(2, k));
    arr[k] = (int)pow;
    Console.WriteLine("\nПозиция {0} = {1}", k, arr[k]);                   
}

for (int i = arr.Length - 1; i >= 0; i--)
{
    Console.WriteLine("\nПозиция {0} = {1}", i, arr[i]);
}