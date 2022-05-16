Double x1=0;
Double x2=0;
Double y1=0;
Double y2=0;
Double z1=0;
Double z2=0;

Console.WriteLine("введите координату x первой точки");
x1 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("введите координату y первой точки");
y1 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("введите координату z первой точки");
z1 = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("введите координату x второй точки");
x2 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("введите координату y второй точки");
y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату z второй точки");
z2 = Convert.ToDouble(Console.ReadLine()); 

double res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.WriteLine(res);
