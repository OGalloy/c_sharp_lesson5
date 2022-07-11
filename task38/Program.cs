/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76*/


//Инициализация массива.
double[] actualArray = createArray(10);

//Вывод массива на экран.
foreach (double value in actualArray)
{
    Console.WriteLine("{0} ", value);
}

//Вывод разницы между максимальным и минимальным элементом
Console.WriteLine("Разница между max и min равна: {0}", calculateSub(actualArray));

//Функция Создания массива типа double.
double[] createArray(uint arrayLength)
{
    double[] array = new double[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

/*Функция нахождения разницы
между максимальным и минимальным элементом массива*/
double calculateSub(double[] array) 
{
    double max = array[0];
    double min = array[1];
    if (array[0] < array[1])
    {
        double temp = max;
        max = min;
        min = temp;
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}