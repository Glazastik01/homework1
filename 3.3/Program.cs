try {
    Console.WriteLine("Введите число");
    int Num = Convert.ToInt32(Console.ReadLine());
    if (Num < 8 && Num > 0){
        if (Num == 1){
        Console.WriteLine("Понедельник");
    } else if (Num == 2){
        Console.WriteLine("Вторник");
    } else if (Num == 3){
        Console.WriteLine("Среда");
    } else if (Num == 4){
        Console.WriteLine("Четверг");
    } else if (Num == 5){
        Console.WriteLine("Пятница");
    } else if (Num == 6){
        Console.WriteLine("Суббота");
    } else if (Num == 7){
        Console.WriteLine("Воскресенье");
    }} else {
        Console.WriteLine("Число не в диапазоне");
    }
} catch (Exception ex){
    string a = ex.ToString();
    Console.WriteLine("Введено не число", a);
} finally {
    Console.WriteLine("Программа сработала");
}