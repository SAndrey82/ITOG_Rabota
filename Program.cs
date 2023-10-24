//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива (через пробел): ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }

        Console.ReadLine();
    }

    static string[] FilterArray(string[] inputArray)
    {
        int count = 0;
        // Подсчитываем количество строк, которые удовлетворяют условию (длина <= 3)
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] resultArray = new string[count];
        int index = 0;

        // Заполняем новый массив подходящими строками
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}