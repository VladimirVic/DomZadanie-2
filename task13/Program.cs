// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);  //тип данных строка с названием anyNumberText,Convert.ToString- функция, которая для числа даёт его строковое представление
if (anyNumberText.Length > 2)  // если длина строки больше 2 цифр то
{
    Console.WriteLine("третья цифра -> " + anyNumberText[2]); // 3-я цифра будет равна второму индексу в массиве
}
else // иначе
{
    Console.WriteLine("-> третьей цифры нет");
}
