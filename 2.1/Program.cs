Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num % 3 == 0){
    Console.WriteLine("Число делится на 3 нацело");
} else {
    Console.WriteLine("Число не делится на 3 нацело");
}