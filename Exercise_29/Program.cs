// Задача 29: Напишите программу, которая задаёт массив
//  из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int [] CreateNewArray (int size_array)
{
    int [] array = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {   
        Console.WriteLine($"Please, enter your number with index {i}:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int [] array_to_print)
{
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write(array_to_print[i] + " ");
}

Console.WriteLine("How many numbers will your array include?");
int size = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateNewArray(size);
PrintArray(myArray);