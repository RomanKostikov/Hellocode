// Парс входной строки
using System.Linq;
string text = "(1,2) (2,3) (4,5) (9,7)"
                .Replace("(", "")
                .Replace(")", "") // замена скопки на пробел
                ;
Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) //конвертируем в числовой тип данных;
                .Where(e => e.x % 2 == 0) //выполнить доп условие;
                .Select(point => (point.x * 10, point.y)) //на постоянку увеличеваем в 10ть раз;
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]/*.x * 10*/);// это если разово хотим увеличеть
    // for (int k = 0; k < data[i].Length; k++)
    // {
    //     Console.WriteLine(data[i][k]);
    // }
    Console.WriteLine();
}




