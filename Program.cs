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

/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
начения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/* Решение 2
const int Coeficent = 0;
const int Constante =1;
const int X_Coordinate = 0;
const int Y_Coordinate = 1;
const int Line_1 = 1;
const int Line_2 = 2;

Double InputNum(string message) //Общение с пользователем на прием чисел
{
    
    Console.Write(message + " ");
    return Convert.ToDouble(Console.ReadLine());

}

Double[] InputLineDate(int NumberOfLine) //Ввод К и Б для прямой
{
    double[] LineDate = new double[2];

    LineDate[0] = InputNum("Введите значение Б для " + NumberOfLine);
    LineDate[1] = InputNum("Введите значение кофициента К для " + NumberOfLine);

    return LineDate;
}

bool ValidateLine (double[] LineDate_1, double[] LineDate_2)
{
    
    bool Result = true;
    
    if (LineDate_1[Coeficent] == LineDate_2[Coeficent])
    {
        if (LineDate_1[Constante] == LineDate_2[Constante])
        {
             Console.Write("Прямые совпадают");
             Result = false;   
        }
        else
        {
             Console.Write("Прямые параллельны");
             Result = false; 
        }
    }

    return Result;
}

Double[] FindCoordinate (double[] LineDate1, double[] Linedate2)
{
    double[]Coodrinate = new double[2];

    Coodrinate[X_Coordinate] = (LineDate1[Coeficent]-Linedate2[Coeficent])/(LineDate1[Constante]-Linedate2[Constante]);
    Coodrinate[Y_Coordinate] = LineDate1[Coeficent]*Coodrinate[X_Coordinate] - LineDate1[Constante];

    return Coodrinate;
}

double[] LineDate_1 = InputLineDate(Line_1);
double[] LineDate_2 = InputLineDate(Line_2);

if (ValidateLine(LineDate_1,LineDate_2))
{
     double[] Coordinate = FindCoordinate(LineDate_1,LineDate_2);
     Console.Write($"Точка пересечения прямых заданных уравнениями Y = {LineDate_1[Constante]} * X - {LineDate_1[Coeficent]} и Y = {LineDate_2[Constante]} * X - {LineDate_2[Coeficent]}");
     Console.Write($" имеет значения Y = {Coordinate[Y_Coordinate]} и X = {Coordinate[X_Coordinate]}");
}
*/

/* Тест 2
PS D:\Home_Works\CS_HW_6> dotnet run
Введите значение Б для 1 2
Введите значение кофициента К для 1 5
Введите значение Б для 2 4
Введите значение кофициента К для 2 9
Точка пересечения прямых заданных уравнениями Y = 5 * X - 2 и Y = 9 * X - 4 имеет значения Y = 6 и X = 0,5
*/

