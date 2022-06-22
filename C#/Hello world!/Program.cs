using System;
using System.Globalization;

namespace Project;

class program
{
    static void Main()
    {
        /*
        
        string str = Console.ReadLine(); // метод "статический" т.к. вызывается из класса
        Console.WriteLine(str);

        string str2 = "Zelensky Sila";
        char a = str2[2]; // char a = 2; Счет начинается с нуля
        Console.WriteLine(a);

        string str3 = "Pootin Mogila";
        Console.WriteLine(str3.Substring(0,5)); // метод "динамический" т.к. метод SubString вызывается из имени класса
        

        /* string str4 = Console.ReadLine(); // метод Parse конвертирует текст в цифры
        int number = int.Parse(str4);
        str4 = number.ToString(); // ToString конвертирует цифры в текст
        Console.WriteLine(number + 1);

        string str5 = "Kolbaska Sosiska Pelmeni";
        Console.WriteLine(str5.Length); // Динамический метод из переменной, определяет длину строки

        string str6 = null; // значение null подразумевает отсутствие строки, а не отсутствие символов
        Console.WriteLine(str6); 

        string str7 = Console.ReadLine(); // метод Parse конвертирует текст в цифры
        double number = double.Parse(str7, CultureInfo.InvariantCulture); // CultureInfo подключает библиотеку System.Globalization, InvariantCulture позволяет внезависимости от локализации "машины" делить числа точкой либо запятой
        Console.WriteLine(number + 1);


        int a = 2;
        int b = 10;
        int c = (a + b) * 2; // Принцип арифметических операций совпадает с математическим.
                             // При "c = a / b / 2" исп. скобки, операции будут выполняться слева направо.
                             // int c = b%a операция % - операция остатка
        Console.WriteLine(c);

        int a = 3;
        int b = 2;
        double c = (double)a / b; // а целочисленая константа b целочисленная константа, даже при методе double результатом будет являтся целочисленным.
                                  // для решения этой задачи требуется использовать double в одной из значений double c = (double) a / b;
        Console.WriteLine(c);

        double angle = 3.14156;
        Console.WriteLine(Math.Sin(angle)); // синус угла

        Console.WriteLine(Math.Pow(5, 9)); // Метод Pow возведение в степень 5 в 9 степени.


        int a = 2;
        int b = 4;
        var c = (a + b); // var указывает компилятору самому определить значение переменной
        Console.WriteLine(c);
        var d = c.ToString();

        var a = 4;
        var b = 6;
        var c = 8;

        a = b = c; // операции происходят справа налево. b присваивает значение c, результатом является 8, далее a присвает результат пред. операции.

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        var a = 4;
        var b = 6;
        a += 2;  // a += 2 подразумевает под собой a = a + 2
        b *= 5;  // b *= 5 подразумевает под собой b = b * 5
        Console.WriteLine(a);
        Console.WriteLine(b);

        var a = 2;
        var b = 2;

        ++a;     // ++a подразумевает увеличение значения на одну единицу
        b++;     // ++b возвращает изначальное значение, однако при выводе в консоль промежуточным результатом будет 2, но если вывести после, значение будет равно 3

        Console.WriteLine(a);
        Console.WriteLine(b);

        */

    } // void означает что этот метод не возвращает никаких данных, static означает что метод статический

    static int DivideAndRound(double a, double b)
    {
        /* a = 14;
        b = 2;

        var c = (a / b);              // return (int)Math.Round(a/b);
        var d = (int)Math.Round(c);
        return d;
        */

        static void WriteNumber(int a)
        {
            Console.WriteLine("a is Integer");
            Console.WriteLine(a);
        }


        static void WriteNumber(double a)
        {
            Console.WriteLine("a is double");
            Console.WriteLine(a);
        }
}