Console.WriteLine("Введите 3х значное число ");
string numbers = Console.ReadLine()!;

if(numbers.Length != 3)
{
    Console.WriteLine("Введено неверное число ");
}
else 
{
    Console.WriteLine($"Вторая цифра введенного числа = {numbers[1]}");
}

