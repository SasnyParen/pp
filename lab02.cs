double pi = Math.PI;
double sub = pi / 2;
Console.WriteLine("Введите значение X:");
double X = Convert.ToDouble(Console.ReadLine());
if (Math.Abs(X) > 1) { Console.WriteLine("Неверно введены данные"); return; }
double N = 0;
Console.WriteLine("Введите значение конечного шага:");
double end_N = Convert.ToDouble(Console.ReadLine());
double result = 0;
while (N < end_N)
{
    double step = sub + ((Math.Pow(-1, N + 1)) * Math.Pow(X, 2 * N + 1)) / 2 * N + 1;
    result+= step;
    N++;
}
Console.WriteLine($"Полученый результат: {result}");
