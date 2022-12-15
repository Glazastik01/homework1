Console.WriteLine("Введите первое число");
int NumFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int NumSecond = Convert.ToInt32(Console.ReadLine());
int sum = NumFirst + NumSecond;
int diff = NumFirst - NumSecond;
Console.WriteLine($"Результат сложения: {sum}");
Console.WriteLine($"Результат вычитания: {diff}");