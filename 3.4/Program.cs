Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int len = 0;
int sum = 0;
while (len <= Num){
    if (len % 2 == 1){
        sum += len;
        len++;
    } else {
        len++;
    }
}
Console.WriteLine(sum);

/*
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int len = 0; len <= Num; len++){
    if (len % 2 == 1){
        sum += len;
    }
}
Console.WriteLine(sum);
*/