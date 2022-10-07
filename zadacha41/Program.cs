/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.WriteLine ("Введите числа через запятую:");
string numbers = Console.ReadLine();
/* нам нужно перебрать каждый элемент строки, если это не запятая 
или пробел, кладём его в массив, иначе, делаем ++ */
string [] newNumbers = new string [numbers.Length];
int j = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    j++;
  }
  else
  {
    newNumbers[j] = newNumbers[j]+$"{numbers[i]}";
  }
}
j++;
int [] resultNumbers = new int[j];
PrintArray (resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < j; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество введённых чисел, которые больше 0: "+sum);

void PrintArray (int[] array, string[] strings)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(strings[i]);
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

