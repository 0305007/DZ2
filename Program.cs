// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Console.WriteLine("Введите трехзнaчное число");

// string? numberStringa = Console.ReadLine();

// int numbera = int.Parse(numberStringa!);

// int i = 0;

// if (numbera > 99 && numbera < 1000)

// {
//     i = numbera %100 / 10;

//     Console.WriteLine(i);
// }


// else if (numbera < -99 && numbera > -1000)
// {
//     i = numbera %100 / 10;

//     Console.WriteLine(i);
// }

// else 
//  Console.WriteLine("Число введено неверно");




// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



// Console.WriteLine("Введите трехзнaчное число");

// string? numberStringa = Console.ReadLine();

// int numbera = int.Parse(numberStringa!);


// if (numbera > 99)

// {
//     Console.WriteLine(numbera.ToString()[2]);
// }

// else if (numbera < -99)

// {
//     Console.WriteLine(numbera.ToString()[3]);

// }
// else
// { Console.WriteLine("У числа нет третьей цифры"); }



// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Console.WriteLine("Введите номер дня недели для проверки является ли этот день выходным");

// string? numberStringa = Console.ReadLine();

// int numbera = int.Parse(numberStringa!);

// if (numbera > 0 && numbera < 8)

// {
//     if (numbera < 6)
//     {
//         Console.WriteLine("нет");
//     }
//     else
//     {
//         Console.WriteLine("да");
//     }
// }

// else
// {
//     Console.WriteLine("число не соответствует условию");
// }