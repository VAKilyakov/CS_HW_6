/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

/* Задача 2
int InputNum(string message)
{
    
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());

}

int[] CreateArray(int Length)
{

    int [] array = new int[Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNum("Введите число " + (i+1) );
    }

    return array;

}

void PrintArray(int[] array)
{
    Console.Write("Ваш массив [");

    for(int i=0; i < array.Length-1; i++)
    {
       Console.Write(array[i] + ","); 
    }

    Console.Write(array[array.Length-1] + "]");
}

int QuantityOfPositiveNumbers(int[] array)
{
    int Result = 0;

    for(int i=0; i < array.Length; i++)
    {
       if (array[i]>0)
       {
        Result++;
       } 
    }

    return Result;

}

int Length = InputNum("Введите количество чисел которых хотите ввести");
int[] Array = CreateArray(Length); 
PrintArray(Array);
Console.Write("В Вашем массиве больше нуля " + QuantityOfPositiveNumbers(Array) + " чисел");
*/

/* Тест 1
PS D:\Home_Works\CS_HW_6> dotnet run
Введите количество чисел которых хотите ввести 5
Введите число 1 0
Введите число 2 7
Введите число 3 8
Введите число 4 -2
Введите число 5 -2
Ваш массив [0,7,8,-2,-2]В Вашем массиве больше нуля 2 чисел
PS D:\Home_Works\CS_HW_6> dotnet run
Введите количество чисел которых хотите ввести 5
Введите число 1 1
Введите число 2 -7
Введите число 3 567
Введите число 4 89
Введите число 5 223
Ваш массив [1,-7,567,89,223]В Вашем массиве больше нуля 4 чисел
*/

