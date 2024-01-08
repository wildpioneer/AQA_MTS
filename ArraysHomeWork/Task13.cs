using System.Collections;
using System.Diagnostics;

namespace ArraysHomeWork;

public class Task13
{
    /*
     * Поиск трех цифр в массиве, сумма которого равна заданному значению.
     */

    public void Execute()
    {
        // Получение размерности массива
        int arraySize = -1;
        do
        {
            Console.Write("Введите размерность массива: ");
            arraySize = Convert.ToInt32(Console.ReadLine());
        } while (arraySize <= 0);

        // Инициализация и заполнение массива
        int[] array = new int[arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(10);
        }

        Console.WriteLine("Массив: " + string.Join(" ", array));

        Console.Write("Введите сумму трех элементов: ");
        int targetSum = Convert.ToInt32(Console.ReadLine());

        // Решение
        Array.Sort(array);
        int count = 0;

        foreach (var i in array)
        {
            if (i <= targetSum) count++;
        }

        bool isSumExist = false;

        if (count > 2)
        {
            int[] resultArray = new int[count];
            count = 0;

            foreach (var i in array)
            {
                if (i <= targetSum)
                {
                    resultArray[count++] = i;
                }
            }

            for (int i = 0; i < resultArray.Length - 2; i++)
            {
                for (int j = i + 1; j < resultArray.Length - 1; j++)
                {
                    for (int k = j + 1; k < resultArray.Length; k++)
                    {
                        if (resultArray[i] + resultArray[j] + resultArray[k] == targetSum)
                        {
                            Console.WriteLine($"{resultArray[i]} + {resultArray[j]} + {resultArray[k]} = {targetSum}");
                            isSumExist = true;
                        }
                    }
                }
            }
        }

        if (!isSumExist)
        {
            Console.WriteLine($"Отсутствуют элементы в сумме равные {targetSum}");
        }
    }

    public void ExecuteSimple()
    {
        // Получение размерности массива
        int arraySize = -1;
        do
        {
            Console.Write("Введите размерность массива: ");
            arraySize = Convert.ToInt32(Console.ReadLine());
        } while (arraySize <= 0);

        // Инициализация и заполнение массива
        int[] array = new int[arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(10);
        }

        Console.WriteLine("Массив: " + string.Join(" ", array));

        Console.Write("Введите сумму трех элементов: ");
        int targetSum = Convert.ToInt32(Console.ReadLine());

        // Решение
        bool isSumExist = false;
        for (int i = 0; i < array.Length - 2; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[i] + array[j] + array[k] == targetSum)
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} + {array[k]} = {targetSum}");
                        isSumExist = true;
                    }
                }
            }
        }
        
        if (!isSumExist)
        {
            Console.WriteLine($"Отсутствуют элементы в сумме равные {targetSum}");
        }
    }
}