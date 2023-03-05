// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Имеются две прямые, заданные уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите значение k1");
double coefOneLineOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1");
double coefTwoLineOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double coefOneLineTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double coefTwoLineTwo = Convert.ToInt32(Console.ReadLine());
double[,] creatMatrix = CreateMatrixCoefLine(coefOneLineOne, coefTwoLineOne, coefOneLineTwo, coefTwoLineTwo);
double[] findXY = FindXandY(creatMatrix);
if (coefOneLineOne == coefOneLineTwo || (coefOneLineOne == coefOneLineTwo && coefTwoLineOne == coefTwoLineTwo)) Console.WriteLine("Линии параллельны");
else PrintPointCross(findXY);

// методы
double[,] CreateMatrixCoefLine(double k1, double b1, double k2, double b2)
{
    double[,] matrixCoefLine = new double[2, 2];
    matrixCoefLine[0, 0] = k1;//5
    matrixCoefLine[0, 1] = b1;//2
    matrixCoefLine[1, 0] = k2;//9
    matrixCoefLine[1, 1] = b2;//4
    return matrixCoefLine;
}

double[] FindXandY(double[,] coefLine)
{
    double[] arrayXY = new double[2];
    double numY = Math.Round((coefLine[1, 0] * coefLine[0, 1] - coefLine[1, 1] * coefLine[0, 0]) / (coefLine[1, 0] - coefLine[0, 0]), 2, MidpointRounding.ToZero);
    arrayXY[1] = numY;
    double numX = Math.Round((arrayXY[1] - coefLine[1, 1]) / coefLine[1, 0], 2, MidpointRounding.ToZero);
    arrayXY[0] = numX;
    return arrayXY;
}

void PrintPointCross(double[] arrayXY)
{
    Console.Write("Точка пересечения прямых -> [");
    for (int i = 0; i < arrayXY.Length; i++)
    {
        if (i < arrayXY.Length - 1) Console.Write($"{arrayXY[i]}, ");
        if (i == arrayXY.Length - 1) Console.WriteLine($"{arrayXY[i]}]");
    }
}