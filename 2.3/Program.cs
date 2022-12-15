Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num > 999 && Num < 1000000){
    Console.WriteLine(Num / 1000);
} else {
    Console.WriteLine("Число не удовлетворяет диапазону");
}