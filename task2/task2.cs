Console.Clear();

int num = new Random().Next(1, 65536);

string res = num.ToString();

Console.WriteLine(num);
Console.WriteLine((num > 99) ? res[2] : "Третьей цифры нет");
