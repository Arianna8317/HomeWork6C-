(double x,double y ) CrossLine(double k1, double b1, double k2, double b2)
{   double x, y;
    x = (b1-b2)/(k2-k1);
    y = k1*x + b1;
    return (x,y); 
}
System.Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
var Point = CrossLine(k1,b1,k2,b2);
System.Console.WriteLine($"Точка пересечения({Point.x},{Point.y})");