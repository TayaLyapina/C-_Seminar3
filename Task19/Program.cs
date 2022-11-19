/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/

int number = ReadInt("Введите пятизначное число: ");

if (number < 10000 && number > 0 || number > -10000 && number < 0)
{
    Console.WriteLine("Число не пятизначное. Повторите ввод.");
}

int firstDigit = number / 10000;

int secondDigit = number / 1000 % 10;

int forthDigit = number / 10 % 10;

int lastDigit = number%10;


if (firstDigit == lastDigit && secondDigit == forthDigit)
{
    Console.WriteLine ("Это число полиндром");
}
else
{
    Console.WriteLine ("Число не является полиндромом");
}


int ReadInt(string message)
{
Console.Write(message);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
