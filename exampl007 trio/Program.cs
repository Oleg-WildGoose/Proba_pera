Console.Clear();

int xa = 46, ya = 1,
    xb = 1, yb = 30,
    xc = 92, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine(".l.");
Console.SetCursorPosition(xb, yb);
Console.WriteLine(".l.");
Console.SetCursorPosition(xc, yc);
Console.WriteLine(".l.");

int x = xa, y = ya;
int count = 0;

while(count<10000)
{
    int wtf = new Random().Next(0,3);
    if(wtf == 0)
    {
        x = (xa+x)/2;
        y = (ya+y)/2;
    }
    if(wtf == 1)
    {
        x = (xb+x)/2;
        y = (yb+y)/2;
    }
    if(wtf == 2)
    {
        x = (xc+x)/2;
        y = (yc+y)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine(".!.");
    count++;
}