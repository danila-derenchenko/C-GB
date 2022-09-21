// Program 1
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Программа 1");
string number = Console.ReadLine();
void Program1(string number)
{
    Console.WriteLine(number[1]);
}

Program1(number);

// Program 2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Программа 2");
string number2 = Console.ReadLine();
void Program2(string number2)
{
    if (number2.Length >= 3)
    {
        Console.WriteLine(number2[2]);
    }
    else Console.WriteLine("Третье число не задано");
}

Program2(number2);

// Program 3
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Программа 3");
string numberDay = Console.ReadLine();
int numberDayInt = int.Parse(numberDay);
void Program3(int number)
{
    if (number == 6 || number == 7) Console.WriteLine("Это выходной");
    else Console.WriteLine("Это не выходной");
}

Program3(numberDayInt);