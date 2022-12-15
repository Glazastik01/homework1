Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int fib1 = 1;
int fib2 = 1;
int len = 0;
while(len < Num - 2){
    int fib_sum = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib_sum;
    len++;
}
Console.WriteLine($"Значение элемента на позиуции {Num}: {fib2}");
/*
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int fib1 = 1;
int fib2 = 1;
int len = 0;
for (len = 0; len < Num - 2; len++){
    int fib_sum = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib_sum;
}
Console.WriteLine($"Значение элемента на позиуции {Num}: {fib2}");
*/