Console.WriteLine("Введите число от 0 до 10000 ");
string numbers = Console.ReadLine()!;

if(numbers.Length <= 2)
{
    Console.WriteLine("Третьей цифры нет в введенном числе ");
}
else 
{
    Console.WriteLine($"Третья цифра введенного числа = {numbers[2]}");
}

