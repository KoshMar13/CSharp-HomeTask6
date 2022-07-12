// 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Сложный способ
void PrintArray(double[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < len - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + "]");
    }
}

double[] EquationLine(int num1, int num2)
{
    double[] array = { num1, num2 };
    return array;
}

//x = (b2-b1)/(k1-k2)
//y = (k2*b1-k1*b2)/(k2-k1)

double[] LinesIntersection(double[] line1, double[] line2)
{
    // line1[k1; b1]
    //line2[k2; b2]
    double k1 = line1[0];
    double b1 = line1[1];
    double k2 = line2[0];
    double b2 = line2[1];
    double x = (b2 - b1) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    double[] array = { x, y };
    return array;
}

Console.Clear();
Console.Write("Insert k1: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert b1: ");
int b = Convert.ToInt32(Console.ReadLine());
double[] arr1 = EquationLine(k, b);
Console.Write("Insert k2: ");
k = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert b2: ");
b = Convert.ToInt32(Console.ReadLine());
double[] arr2 = EquationLine(k, b);
PrintArray(LinesIntersection(arr1, arr2));

//Простой способ
// Console.WriteLine("You see equation y = k1 * x + b1");
// Console.Write("Insert k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("You see equation y = k2 * x + b2");
// Console.Write("Insert k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// double x = Convert.ToDouble((b2 - b1) / (k1 - k2));
// double y = Convert.ToDouble((k2 * b1 - k1 * b2) / (k2 - k1));
// Console.WriteLine($"({x}; {y})");
