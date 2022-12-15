try {
    Console.WriteLine("Введите число");
    int Num = Convert.ToInt32(Console.ReadLine());
    if ((Num % 3 == 0) && (Num % 7 == 0)){
        Console.WriteLine("Число делится на 3 и на 7");
    } else {
        Console.WriteLine("Число не делится на 3 и на 7");
    }
} catch (Exception ex){
    Console.WriteLine($"Введено не число, {ex}");
} finally {
    Console.WriteLine("Программа сработала");
}