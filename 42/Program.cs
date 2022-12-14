//  Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int Metod1(int number)
// {
//    int i = 0;
//    while (number > 0)
//    {
//       number = number / 2;
//       i++;
//    }{}
//    return i;
// }

// int[] box = new int[Metod1(number)];

// int b = box.Length - 1;
// while (number > 0)
// {
//    box[b] = number % 2;
//    number = number / 2;
//    b--;
// }
// Console.WriteLine (box);

// Console.WriteLine(string.Join(" ", box));

// 210,84 + 83,31

int a = 44;

void PrintBinaryView(int number)
{
   if (number <= 0) return;
   PrintBinaryView(number / 2);
   Console.Write(number % 2);
}
PrintBinaryView (a);