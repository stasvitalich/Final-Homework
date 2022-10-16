// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключетельно массивами. 

string[] array1 = new string[5] { "Peace", "World", "777", "2022", "Me" }; // Инициализируем массив.
string[] array2 = new string[array1.Length];

void FillNewArray(string[] array1, string[] array2) // Метод, заполняющий новый массив.
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintFinalArray(string[] array) // Метод, выводящий новый массив на печать.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillNewArray(array1, array2);
PrintFinalArray(array2);
