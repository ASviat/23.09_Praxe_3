Console.WriteLine("Введите число, дабы магия вершилась: ");
int num=Convert.ToInt32(Console.ReadLine());

int Square(int number)
{
    int count=1;
    while (count<=number)
    {
        int scount=count*count;
        Console.Write($"{scount} ");
        count++;
    }
    return -1;
}
int square=Square(num);
Console.WriteLine($"{square}");