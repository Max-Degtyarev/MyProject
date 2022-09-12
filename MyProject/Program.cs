// See https://aka.ms/new-console-template for more information



//#define TASK_1
//#define TASK_2
//#define TASK_3
#define TASK_4
//#define TASK_5
//#define TASK_6
//#define TASK_7


using System;
using System.Globalization;

#if TASK_1

int number = 0;

do
{
    Console.WriteLine("Введите число: ");
    try
    {
        number = Int32.Parse(Console.ReadLine());
        if (number < 0 || number > 100)
        {
            throw new Exception();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели неправильное число!");
    }

    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("Fizz Buzz");
        return;
    }
    if (number % 3 == 0) Console.WriteLine("Fizz");
    if (number % 5 == 0) Console.WriteLine("Buzz");
    if (number % 3 != 0 && number % 5 != 0) Console.WriteLine(number);

} while (number < 0 || number > 100);

#endif




#if TASK_2

int number = 0;
int i = 0;

Console.WriteLine("Введите число: ");
try
{
    number = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Введите число для процента: ");
    i = Int32.Parse(Console.ReadLine());
    int result = number * i / 100;
    Console.WriteLine("Результат вычисления: {0}", result);
}
catch (Exception)
{
    Console.WriteLine("Вы ввели неправильное число!");
    
}


#endif



#if TASK_3

double number1, number2, number3, number4;
int result = 0;

Console.WriteLine("Введите 1 число");
number1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число");
number2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите 3 число");
number3 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите 4 число");
number4 = Double.Parse(Console.ReadLine());

result = (((result + (int)number1) * 10 + (int)number2) * 10 + (int)number3) * 10 + (int)number4;
Console.WriteLine("Результат вычисления = {0}", result);


#endif




#if TASK_4

int size = 6;
int[] arr = new int[size];
int number = 0;

Console.WriteLine("Введите шестизначное число: ");
try
{
    number = Int32.Parse(Console.ReadLine());
    int count = 0;
    int copynumber = number;
    for(int i = 0; copynumber > 0; i++)
    {
        copynumber /= 10;
        count++;

    }
    if (count != 6)
    {
        throw new Exception();
    }


}
catch (Exception)
{
    Console.WriteLine("Вы ввели не шестизначное число!");
    return;
}


for(int i = size - 1; i >= 0; i--)
{
    int buffer = number % 10;
    arr[i] = buffer;
    number /= 10;
}


int index1 = 0;
int index2 = 0;

Console.WriteLine("Введите первый номер разряда для обмена цифр: ");
try
{
    index1 = Int32.Parse(Console.ReadLine());
    if (index1 < 0 || index1 > 5) throw new Exception();
}
catch (Exception)
{
    Console.WriteLine("Вы ввели неправильный номер!"); return;
}

Console.WriteLine("Введите второй номер разряда для обмена цифр: ");
try
{
    index2 = Int32.Parse(Console.ReadLine());
    if (index2 < 0 || index2 > 5) throw new Exception();
}
catch (Exception)
{
    Console.WriteLine("Вы ввели неправильный номер!"); return;

}


int buffer2 = arr[index1];
arr[index1] = arr[index2];
arr[index2] = buffer2;

for (int i = 0; i < size; i++)
{
    Console.Write(arr[i]);

}



#endif




#if TASK_5


//Не получилось

DateTime date;
Console.WriteLine(date.DayOfWeek);

string dt = Console.ReadLine();

DateTime.TryParseExact(dt, "g", null, DateTimeStyles.None, out date);

Console.WriteLine(date);



#endif


#if TASK_6


Console.WriteLine("Введите температуру: ");
int temp = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите шкалу: ");
string i = Console.ReadLine();

double result = 0;

if(i == "F")
{

    result = temp * 1.8 + 32;

}
if(i == "C")
{

    result = (temp - 32) * 0.555555555555555555555555555555555555555555555555555555;

}

Console.WriteLine("Результат: {0}", result);



#endif




#if TASK_7

Console.WriteLine("Введите первое число: ");
int number1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Int32.Parse(Console.ReadLine());


Console.WriteLine("Все четные числа в указанном диапазоне: ");

if(number1 > number2)
{
    int buffer = number1;
    number1 = number2;
    number2 = buffer;
}

for(int i = number1; i != number2 + 1; i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");

    }


}




#endif
