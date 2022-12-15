Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num % 5 == 2 && Num % 7 == 1){
    Console.WriteLine("Число удовлетворяет условию");
} else {
    Console.WriteLine("Число не удовлетворяет условию");
} 