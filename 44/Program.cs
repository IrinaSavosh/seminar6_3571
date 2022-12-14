// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число А");
int n = Convert.ToInt32(Console.ReadLine());

int[] name = new int[n];
name[0] = 0;
name[1] = 1;
for (int i = 2; i < n; i++)
{
   name[i] = name[i - 1] + name[i - 2];
}

Console.WriteLine(string.Join(" ", name));