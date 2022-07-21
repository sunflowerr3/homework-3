// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("введи пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int digitOnes = number%10;
int digitTens = number/10%10;
int digitThousands = number/1000%10;
int digitTensOfThousands = number/10000;

if (digitOnes == digitTensOfThousands || digitTens == digitThousands)
{
    Console.WriteLine ("это палиндром");
}
else
{
    Console.WriteLine("это не палиндром");
}