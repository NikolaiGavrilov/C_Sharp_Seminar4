// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void NumberInDegree(int firstNum, int secondNum)
{
    int result = 1;
    for (int degree = 1; degree <= secondNum; degree++)
        result = result * firstNum;
        
    Console.WriteLine($"Your result is {result}");
}

Console.WriteLine("Input your first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB > 0)
    NumberInDegree(numA, numB);
else if (numB == 0)
    Console.WriteLine("Your result is 1");
else if (numB < 0)
    Console.WriteLine ("Your second number must be positive. Try again with another second number.");