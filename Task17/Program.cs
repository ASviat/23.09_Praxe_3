Console.WriteLine ("Введите координату точки Х:");
int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату точки Y:");
int y=Convert.ToInt32(Console.ReadLine());

int quarter= Quarter(x,y);
Console.WriteLine(quarter==0?"Введены некорректные координаты":$"Четверть {quarter}");

int Quarter (int X, int Y)
{
    if (X>0 && Y>0) return 1;
    if (X>0 && Y<0) return 2;
    if (X<0 && Y<0) return 3;
    if (X<0 && Y>0) return 4;
    return 0;
}