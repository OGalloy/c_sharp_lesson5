/*Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//Инициализация массива.
int[] actualArray = createArray(10);

//Вывод массива на экран.
foreach (int value in actualArray)
{
    Console.Write("{0} ", value);
}
//Вывод  количества чётных чисел в массиве.
Console.WriteLine("Количество чётных чисел: {0}",calculateEven(actualArray));
//Функция Создания массива.
int[] createArray(uint arrayLength)
{
    int[]array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
//Функция подсчёта количества чётных чисел. 
int calculateEven(int[] array)
{   
    int count = 0;
    foreach (int value in array)
    {
        if (value % 2 == 0) count += 1;
    }
    return count;
}