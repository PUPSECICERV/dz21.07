// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.WriteLine ("Введите числа:");
// string numbers = Console.ReadLine();
// string [] newNumbers = new string [numbers.Length];
// int k = 0;
// for (int i = 0; i < newNumbers.Length; i++)
// {
//   if (numbers[i] == ',')
//   {
//     k++;
//   }
//   else
//   {
//     newNumbers[k] = newNumbers[k]+$"{numbers[i]}";
//   }
// }
// k++;
// int [] resultNumbers = new int[k];
// PrintArray (resultNumbers, newNumbers);
// int sum = 0;
// for (int i = 0; i < k; i++)
// {
//   if (resultNumbers[i]>0)
//   {
//     sum++;
//   }
// }
// Console.WriteLine ("Количество чисел больше 0: "+sum);

// void PrintArray (int [] array, string [] string1)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//   array[i] = Convert.ToInt32(string1[i]);
//   Console.Write (array[i]+"  ");
//   }
// Console.WriteLine();
// }


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

