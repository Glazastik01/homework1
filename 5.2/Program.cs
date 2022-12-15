

int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(10, 100);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

Random rnd = new Random();
int r = rnd.Next(100);

int dimension = r;
int[] array = InitArray(dimension);

static int[] mami(){
    int[] arr = new int [2];
    for(int i = 0; i < array.Length; i++){

    }
    return
}




PrintArray(array);
int a = (array);

Console.WriteLine();