// Задача 41. Вариант 1 через массив и функцию
int FuncCheck(int[] arr)
{
    int val_2 = 0;
    for (int o = 0; o < arr.Length; o++){
        if (arr[o] > 0) val_2 = val_2 + 1;
    }
    return val_2;
}

Console.WriteLine($"Укажите, сколько чисел будет в вашем массиве");
int val_1 = Convert.ToInt32(Console.ReadLine());
int [] Array = new int[val_1];
Console.WriteLine($"Вводите числа. Заполнив массив, программа продолжит работу.");

for (int i = 0; i < val_1; i++)
{
    int temp = Convert.ToInt32(Console.ReadLine());
    Array[i] = temp;
}

Console.WriteLine($"Количество чисел больше 0 - {FuncCheck(Array)}");
