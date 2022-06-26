// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a==b)
{
    Console.WriteLine("Числа равны");
}
else
{
  if (a>b) 
  {
    Console.Write("max=");
    Console.Write(a);
     Console.Write(" ; min=");
      Console.Write(b);
  }
  else
  {
    Console.Write("max=");
    Console.Write(b);
    Console.Write(" ; min=");
    Console.Write(a);
  }
}