// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Input number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int index = 0; index < b; index++)
    result = result * a;
Console.WriteLine(result);



