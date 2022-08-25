
int[] strToIntArray(string a, int N)
{
    a = a.Replace(" ", "");
    string[] b = a.Split(",");
    int[] c = new int[N] ;
    for (int i = 0; i < b.Length & i< N; i++)
    {
        c[i] = Convert.ToInt32(b[i]);
       // System.Console.WriteLine(c[i]);
    }
    return c;
}


int PositiveCounter( int[] Array)
{
   int counter=0;
   for (int i = 0; i < Array.Length; i++)
   if (Array[i]>0)
       counter++;
   return counter;
}

System.Console.Write("Сколько чисел будете вводить? M = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа через , :  ");

int[] Array = new int[N];
Array = strToIntArray(Console.ReadLine(), N);
System.Console.WriteLine( $"Положительных чисел всего {PositiveCounter(Array)}");