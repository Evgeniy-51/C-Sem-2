Console.Clear();

int num = new Random().Next(1, 8);

Console.WriteLine(num);
Console.WriteLine((num == 6 || num == 7) ? "Да" : "Нет");
