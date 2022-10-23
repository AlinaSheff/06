// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Напишите количество чисел, которые хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int count = 0;

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");

if(array[i] > 0) count++; 
}

Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0: {count}");
