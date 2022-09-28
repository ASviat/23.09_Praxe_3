Console.WriteLine("Введите число, дабы магия вершилась: ");
int num=Convert.ToInt32(Console.ReadLine());

void Square(int number)
{
    int count=1;
    while (count<=number)
    {
        Console.WriteLine($"{count}  {count*count}");
        count++;
    }
    
}

if (num>0)Square(num);
else Console.WriteLine ("Введите корректные значения");
