// a) Заполнить массив случайными числами и вывести их на экран(используя методы).
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
//b) Решим задачу с find при помощи этих методов.
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // специальный прием для случаев, которые не входят в диапазон массива
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        //index = index + 1;
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array); // вызвал метод заполнения массива
array[4] = 4; //исскуствено добавили еще по 4ке
array[7] = 4;
PrintArray(array); // метод вывода на экран
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);