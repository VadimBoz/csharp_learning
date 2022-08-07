Console.Clear();
int  x1=40, y1=1,
     x2=1, y2=20,
     x3=80, y3=20;

Console.SetCursorPosition(x1,y1);
Console.WriteLine("*");
Console.SetCursorPosition(x2,y2);
Console.WriteLine("*");
Console.SetCursorPosition(x3,y3);
Console.WriteLine("*");
int count=1, x=x1, y=y1;

while (count<3)
{
    int point = new Random().Next(0, 3);
    if (point==0)
    {
          x=(x+x1)/2;
          y=(y+y1)/2;
    }
    if (point==1)
    {
          x=(x+x2)/2;
          y=(y+y2)/2;
    }
     if (point==2)
    {
          x=(x+x3)/2;
          y=(y+y3)/2;
    }
     Console.SetCursorPosition(x,y);
     Console.WriteLine("*");
   count++; 
}
