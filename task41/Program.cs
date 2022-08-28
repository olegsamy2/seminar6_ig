// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл // пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] array = new int[5];

int count = 0; // счетчик для положительных чисел

for (int i = 0; i < array.Length; i++)
{
    int n = 1 + i;
    Console.Write("\n Введите число №" + n + ": ");
    array[i] = int.Parse(Console.ReadLine()!);
    if (array[i] > 0)
    {
        count = count + 1;
    }
  
}

Console.WriteLine("\n Чисел больше нуля " + count);
