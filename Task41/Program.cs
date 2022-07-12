// 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPos(int number)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.Write("Insert number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
            count++;
    }
    return count;
}

Console.Write("How many numbers would you like to insert: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CountPos(m));
