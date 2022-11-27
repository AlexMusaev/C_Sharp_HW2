// // Задание 1. Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // В задание указано не было, но я дополнительно сделал проверку на трехзначное число

Console.Clear();
Console.WriteLine("Введите ваше трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 1000 || num <= 99) 
{
    Console.WriteLine($"Ваше число {num} не является трехзначным");
}
else 
{
    int secondNum = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра из числа {num} получается - {secondNum}");
}

// Задание 2. Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третей цифры нет.
// Делал через массив, это намного быстрее, чем через циклы доводить значение до трезначного.

Console.Clear();
Console.WriteLine("Введите ваше число: ");
int findNum = int.Parse(Console.ReadLine());

if (findNum <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    char [] array = findNum.ToString().ToCharArray();
    Console.WriteLine(array[2]);   
}

// Задание 3. Задача 15. Напишите програму, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите день недели: ");
int findDay = int.Parse(Console.ReadLine());

if (findDay == 6 || findDay == 7)
{
    Console.WriteLine("Этот день выходной");
}
if  (findDay < 6 && findDay != 0)
{
    Console.WriteLine("Это будний день");
}
if (findDay > 7)
{
    Console.WriteLine("Нет такого дня недели");
}



















