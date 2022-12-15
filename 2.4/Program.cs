Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

if ((Num > 4) && (Num < 11)){
    Console.WriteLine("Число в дианазоне");
} else {
    Console.WriteLine("Число не попадает в диапазон");
}