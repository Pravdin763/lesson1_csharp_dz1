Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i<=num; i++)
    if (i%2==0)
    {
    Console.WriteLine(i);
    }