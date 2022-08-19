int x;
Console.WriteLine("Введи первое число - ");
x = Convert.ToInt32(Console.ReadLine());

int y;
Console.WriteLine("Введи второе число - ");
y = Convert.ToInt32(Console.ReadLine());

int z;
Console.WriteLine("Введи и третье число - ");
z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Max(x, Math.Max(y, z)));
