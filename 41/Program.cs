// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается
// при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int size = 500;
int i = 0;


int[] array = new int[size];

while (i < size)
{

   Console.WriteLine("Введите число или слово stop, если хотите прервать введение: ");
   string? text = Console.ReadLine();
   if (text == "stop")
   {
      break;
   }
   if (text != "stop")
   {
      array[i] = Convert.ToInt32(text);
      i++;
   }
}

int[] mass = new int[i];

for (int j = 0; j < i; j++)
{
   mass[j] = array[j];
}

Console.WriteLine(string.Join(", ", mass));
int k = 0;
int count = 0;
while (k < mass.Length)
{
   if (mass[k] > 0)
   {
      count++; 
   }
   k++;
}
Console.WriteLine(count);
