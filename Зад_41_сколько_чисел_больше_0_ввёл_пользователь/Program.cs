/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
*/


int CountNumbersPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine("Введите несколько чисел через пробел: ");
int[] userNumbers = Console.ReadLine()!.Split().Select(x => Convert.ToInt32(x)).ToArray();
int userCount = CountNumbersPositive(userNumbers);

if ((userCount - 1) % 10 == 0 || userCount == 1)
{
    Console.WriteLine($"Вы ввели {userCount} положительное число");
}
if (userCount % 10 > 1 && userCount % 10 < 5 && (userCount < 6 || userCount > 20))
{
    Console.WriteLine($"Вы ввели {userCount} положительных числа");

}
if (userCount % 10 > 4 && userCount % 10 < 10 || userCount > 9 && userCount < 20)
{
    Console.WriteLine($"Вы ввели {userCount} положительных чисел");
}
