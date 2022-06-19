
//Задача 2
//################################################################################

//Console.WriteLine("Введите первое число");
//int first = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//int second = Convert.ToInt16(Console.ReadLine());

//if (first > second) Console.WriteLine(first + " большее " + second + " меньшее");
//if (first < second) Console.WriteLine(second + " большее " + first + " меньшее");

//#################################################################################


//Задача 4
//################################################################################

Console.WriteLine("Введите первое число");
int first = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите третье число");
int third = Convert.ToInt16(Console.ReadLine());


if (first > second && first > third) Console.WriteLine(first + " больше всех");
if (second > first && second > third) Console.WriteLine(second + " больше всех");
if (third > second && third > first) Console.WriteLine(third + " больше всех");

//#################################################################################

//Задача 6
//################################################################################

Console.WriteLine("Введите число");
int number = Convert.ToInt16(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("число четное");
else Console.WriteLine("число не четное");

//#################################################################################

//Задача 8
//################################################################################

//Console.WriteLine("Введите число");
//int number = Convert.ToInt16(Console.ReadLine());

//for(int i = 0; i < number; i++)
//{
//    if(i%2 == 0)Console.Write(i + " ");
//}

//################