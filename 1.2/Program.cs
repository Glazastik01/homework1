Console.WriteLine("Укажите дату вашего рождения");
int yOld = Convert.ToInt32(Console.ReadLine());
DateTime now = DateTime.Now;
int years = now.Year - yOld;
Console.WriteLine(years);