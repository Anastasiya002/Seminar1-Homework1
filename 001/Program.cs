// Нахождение квадрата числа, введенного пользователем
Console.Write("Введите целое число и нажмите Enter: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);
int result = number * number;
Console.WriteLine($"{number} -> {result}");