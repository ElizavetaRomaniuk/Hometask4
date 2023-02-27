// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int negative = 0, positive = 0;
int[] arrayResult = new int[8];
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
    return array;
}
void PrintResult(int[] array)
{
    Console.WriteLine($"Array result is {String.Join(" ", array)}");
}
arrayResult = GetArray();
PrintResult(arrayResult);

