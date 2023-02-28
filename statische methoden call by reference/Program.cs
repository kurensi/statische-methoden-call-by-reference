// See https:/
/*try
{
    double a = 10.7, b = 0;
    Console.WriteLine($"Add {a} + {b} = {Math.Round(addition(a, b), 2)}");
    Console.WriteLine($"Add {a} - {b} = {Math.Round(subtraktion(a, b)),2}");
    Console.WriteLine($"Add {a} * {b} = {Math.Round(Multiplikation(a, b)),2}");
    Console.WriteLine($"Add {a} / {b} = {dividieren(a, b)}");
    Console.WriteLine(Convert.ToDouble(dividieren(a, b)) + 5);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
static double addition(double x,double y)
{
    return x + y;

}
static double subtraktion(double x, double y)
{
    return x - y;
}
static double Multiplikation(double x, double y)
{
    return x * y;
}
    static string dividieren(double x, double y)
    {
        if (y == 0)
        {
            return "error";
            
        }
        else
            return Math.Round((x / y),2).ToString();
    }


double k = 7.7, l = -8.6, z=0;

Console.WriteLine($"Main : k= {k} l={l}");
z = k;
k = l;
l = z;
Console.WriteLine($"Main : k= {k} l={l}");
swap(ref k, ref l);
Console.WriteLine($"Main : k= {k} l={l}");

static void swap(ref double x,ref double y)
{
    (x, y) = (y, x);
    Console.WriteLine($"\nSwap : k = {x} l = {y}");
}
*/
while (true)
{
    try
    {

        Console.Write("\n Mit j/J Weiter  und mit n/N Ende  : ");
        string str = Console.ReadLine();
        if (str == "n" || str == "N")
        {
            Console.WriteLine("\n Ciao Amigo !!");
            break;
        }
        else if (str == "j" || str == "J")
        {
            Console.Clear();
            int wahl = 0;
            Menü(ref wahl);
            if (wahl == 0)
            {
                Console.WriteLine("\n Ciao Amigo !!");
                break;
            }
            switch (wahl)
            {
                case 1:
                    double d = 0, c = 0;
                    WahlXY(ref d, ref c);
                    Console.WriteLine($"\nSie haben X = {d}  Y = {c} eingegeben ");
                    swap(ref d, ref c);
                    Console.WriteLine($"\nSwap :X = {d}  Y = {c}");
                    break;

                case 2:
                    double max = 0;
                    Console.Write("\nGeben Sie die Grösse des Arrays ein :");
                    int argr1 = Convert.ToInt32(Console.ReadLine());
                    double[] array = new double[argr1];
                    arrayFühlen(ref array);
                    Array_Max(array, ref max);
                    Console.WriteLine($"\nMax des Arrays ist = {max}");
                    break;

                case 3:
                    double min = 0;
                    Console.Write("\nGeben Sie die Grösse des Arrays ein :");
                    int argr2 = Convert.ToInt32(Console.ReadLine());
                    double[] array2 = new double[argr2];
                    arrayFühlen(ref array2);
                    Array_Min(array2, ref min);
                    Console.WriteLine($"\nMin des Arrays ist = {min}");
                    break;

                default:
                    Console.WriteLine("\n Falsche Eingabe !!!");
                    break;

            }
        }
        else
        {
            Console.WriteLine("\n Falsche Eingabe !!");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}

Console.ReadKey();

static void WahlXY(ref double x, ref double y)
{
    try
    {
        Console.Write("\n Geben Sie  x ein  : ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("\n Geben Sie  y ein  : ");
        y = Convert.ToDouble(Console.ReadLine());

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void swap(ref double x, ref double y)
{
    (y, x) = (x, y);
}
static void Array_Max(double[] ar, ref double max)
{
    double y = ar[0];
    foreach (var x in ar)
    {
        if (y < x)
            y = x;
    }
    max = y;
}
static void Array_Min(double[] ar, ref double min)
{
    double y = ar[0];
    foreach (var x in ar)
    {
        if (y > x)
            y = x;
    }
    min = y;
}
static void Menü(ref int x)
{
    try
    {
        Console.WriteLine("\n Menü - Auswahl ");
        Console.WriteLine(" Swap()           (1)");
        Console.WriteLine(" Array-Max()      (2)");
        Console.WriteLine(" Array-Min()      (3)");
        Console.Write(" Ende             (0)   > ");
        x = Convert.ToInt32(Console.ReadLine());

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void arrayFühlen(ref double[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"\nGeben Sie die Zahl für die {i + 1}te Stelle des Arrays ein  :");
        ar[i] = Convert.ToDouble(Console.ReadLine());
    }
}
