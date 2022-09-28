Console.WriteLine ("Введите номер четверти, дабы познать, что скрыто...");
int x=Convert.ToInt32(Console.ReadLine());

string quarter= Quarter(x);
Console.WriteLine(quarter);

string Quarter(int qua)
{
    if (qua==1)return "х>0 и y>0";
    if (qua==2) return "x>0 и y<0";
    if (qua==3)return "х<0 и y<0";
    if (qua==4)return "х<0 и y>0";
    return "Беда";
}


// void Quarter(int xC)
// {
//     if(xC==1)Console.WriteLine("х>0 и y>0");
//     else if(xC==2)Console.WriteLine("х>0 и y<0");
//     else if(xC==3)Console.WriteLine("х<0 и y<0");
//     else if(xC==4)Console.WriteLine("х<0 и y>0");
//     else if (xC!=1 && xC!=2 && x!=3 && xC!= 4)Console.WriteLine("Беда");

// }

// Quarter(x);