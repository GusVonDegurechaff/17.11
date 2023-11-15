//z4
//Console.WriteLine("Введите x не равный 0");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите y не равный 0");
//double y = Convert.ToDouble(Console.ReadLine());
//if (x == 0 ^ y == 0)
//    Console.WriteLine("Ты глуппый или что то?");
//else if (x > 0 && y > 0)
//{
//    Console.WriteLine("первая четверть");
//}
//else if (x > 0 && y < 0)
//{
//    Console.WriteLine("четвертая четверть");
//}
//else if (x < 0 && y > 0)
//{
//    Console.WriteLine("вторая четверть");
//}
//else
//{
//    Console.WriteLine("третья четверть");
//}
//z5
//Console.WriteLine("Введите x не равный 0");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите y не равный 0");
//double y = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите z не равный 0");
//double z = Convert.ToDouble(Console.ReadLine());
//if (x == 0 ^ y == 0 ^ z == 0)
//    Console.WriteLine("Ты глуппый или что то?");
//else if (x > 0 && y > 0 && z > 0)
//{
//    Console.WriteLine("первая");
//}
//else if (x < 0 && y > 0 && z > 0)
//{
//    Console.WriteLine("вторая");
//}
//else if (x < 0 && y < 0 && z > 0)
//{
//    Console.WriteLine("третья");
//}
//else if (x > 0 && y < 0 && z > 0)
//{
//    Console.WriteLine("четвертое");
//}
//else if (x > 0 && y > 0 && z < 0)
//{
//    Console.WriteLine("пятое");
//}
//else if (x < 0 && y > 0 && z < 0)
//{
//    Console.WriteLine("шестое");
//}
//else if (x < 0 && y < 0 && z < 0)
//{
//    Console.WriteLine("седьмое");
//}
//else
//{
//    Console.WriteLine("восьмое");
//}
//z422
//Console.WriteLine("Введите z");
//double z = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите x");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите c");
//double c = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите u");
//double u = Convert.ToDouble(Console.ReadLine());
//if (Math.Abs(z - c) == 2 && Math.Abs(x - u) == 1 || Math.Abs(z - c) == 1 && Math.Abs(x - u) == 2)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}
//z3
//Console.Write("Введите первое целое число");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите второе целое число");
//int b = int.Parse(Console.ReadLine());
//Console.Write("Введите третье целое число");
//int c = int.Parse(Console.ReadLine());
//if (a > b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//if (b > c)
//{
//    int temp = b;
//    b = c;
//    c = temp;
//}
//if (a > b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//Console.WriteLine($"Числа в порядке неубывания = {a}{b}{c}");