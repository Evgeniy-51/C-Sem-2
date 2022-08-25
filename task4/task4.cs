Console.Clear();

int num = new Random().Next(1, 1000000);

Console.WriteLine(num);
Console.WriteLine((num % 7 == 0 && num % 23 == 0) ? "Да" : "Нет");