
Console.WriteLine("Введите координаты точки 1, на оси Х: ");
int xc1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 1, на оси Y: ");
int yc1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2, на оси Х: ");
int xc2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2, на оси Y: ");
int yc2=Convert.ToInt32(Console.ReadLine());

double Distance(int xC1, int yC1, int xC2, int yC2) 
{
    double n1=Math.Pow(xC2-xC1, 2);
    double n2=Math.Pow(yC2-yC1, 2);
    double sum=Math.Sqrt(n1+n2);
    return Math.Round(sum,2,MidpointRounding.ToZero);
}

double distance=Distance(xc1,yc1,xc2,yc2);
Console.WriteLine($"{distance}");