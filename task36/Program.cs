/*Задача 36: Задайте одномерный массив,
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

//Инициализация массива.
int[] actualArray = createArray(10);

//Вывод массива на экран.
foreach (int value in actualArray)
{
    Console.Write("{0} ", value);
}
//Подсчёт суммы нечётных элементов.
Console.WriteLine("Сумма нечётных элементов массива равна: {0}", calculateOddElements(actualArray));
//Функция Создания массива.
int[] createArray(uint arrayLength)
{
    int[]array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}
//Функция подсчёта нечётных элементов массива.
int calculateOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i]; 
    }
    return sum;
}