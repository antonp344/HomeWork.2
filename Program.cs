//                     Задача1

//Задаем размер массива
//int arraySize = 10;

// Создаем массив и заполняем его случайными числами
// int[] array = new int[arraySize];
// for (int i = 0; i < arraySize; i++)
// {
//     array[i] = new Random().Next(1, 100);
// }

// // Выводим сгенерированный массив
// Console.WriteLine("Сгенерированный массив:");
// foreach (int element in array)
// {
//     Console.Write(element + " ");
// }
// Console.WriteLine();

// // Находим количество элементов массива, значения которых лежат в отрезке [20, 90]
// int count = 0;
// foreach (int element in array)
// {
//     if (element >= 20 && element <= 90)
//     {
//         count++;
//     }
// }

// // Выводим результат
// Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20, 90]: {count}");


//                    Задача 2

// int arraySize = 10;
// int[] array = new int[arraySize];
// for (int i = 0; i < arraySize; i++)
// {
//     array[i] = new Random().Next(1, 10);
// }
// Console.WriteLine("Сгенерированный массив:");
// foreach (int element in array)
// {
//     Console.Write(element + " ");
// }
// Console.WriteLine();

// int evenCount = 0;


// foreach (int number in array)
// {

//     if (number % 2 == 0)
//     {
//         evenCount++;
//     }
// }


// Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");


//                        Задача 3

// Задаем массив из вещественных чисел с ненулевой дробной частью
double[] array = { 10.5, 8.2, 15.7, 12.6, 7.3, 9.8, 11.0 };

// Находим максимальный и минимальный элементы массива
double maxElement = array[0];
double minElement = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > maxElement)
    {
        maxElement = array[i];
    }

    if (array[i] < minElement)
    {
        minElement = array[i];
    }
}

// Находим разницу между максимальным и минимальным элементами
double difference = maxElement - minElement;

// Выводим результат
Console.WriteLine($"Максимальный элемент: {maxElement}");
Console.WriteLine($"Минимальный элемент: {minElement}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
