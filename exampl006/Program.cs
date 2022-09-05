int a = new Random().Next(1,100);
int b = new Random().Next(1,100);
int c = new Random().Next(1,100);
int d = new Random().Next(1,100);
int e = new Random().Next(1,100);
int max = a;
if (a > max) max = a;
Console.WriteLine(max);
if (b > max) max = b;
Console.WriteLine(max);
if (c > max) max = c;
Console.WriteLine(max);
if (d > max) max = d;
Console.WriteLine(max);
if (e > max) max = e;
Console.WriteLine(max);

Console.Write("max = ");
Console.WriteLine(max);