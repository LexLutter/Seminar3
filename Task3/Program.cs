Console.Write("Введите число N: ");
var N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    var cube = Math.Pow(i, 3);
    if (i == N) Console.Write($"{cube}."); 
    else Console.Write($"{cube}, ");
}



