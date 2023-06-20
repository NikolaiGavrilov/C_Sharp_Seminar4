// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Input your number: ");
// int yourNumber = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (yourNumber > 0)
//     {
//         sum = sum + yourNumber % 10;
//         yourNumber = yourNumber / 10;
        
//     }
// Console.WriteLine(sum);


int SumOfDigits(int yourNumber)
{
    int sum = 0;
    while (yourNumber > 0)
    {
        sum = sum + yourNumber % 10;
        yourNumber = yourNumber / 10;
    }
    return sum;
}

Console.WriteLine("Input your number: ");
int yourNum = Convert.ToInt32(Console.ReadLine());

if (yourNum >= 0)
    Console.WriteLine($"Your sum is {SumOfDigits(yourNum)}");
else
{
    yourNum = (-1) * yourNum;
    Console.WriteLine($"Your sum is {SumOfDigits(yourNum)}");
}