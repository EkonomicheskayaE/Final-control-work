// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

string[] arr1 = new string[4] {"hello", "2", "world", ":-)"};
string[] arr2 = new string[arr1.Length];

void FillArray(string[] arr1, string[] arr2)
{
    int k = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i].Length <= 3)
        {
            arr2[k] = arr1[i];
            k++;
        }
    }
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
 
FillArray(arr1, arr2);
Print(arr2);
