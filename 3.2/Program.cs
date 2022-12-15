try {
    Console.WriteLine("Введите первое число");
    int Num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int Num2 = Convert.ToInt32(Console.ReadLine());
    if (Num > Num2){
        Console.WriteLine("Первое число больше");
    } else if (Num < Num2){
        Console.WriteLine("Второе число больше");
    } else if (Num == Num2){
        Console.WriteLine("Числа равны");
    }
} catch (Exception ex){
    string a = ex.ToString();
    Console.WriteLine("Введено не число", a);
} finally {
    Console.WriteLine("Программа сработала");
}