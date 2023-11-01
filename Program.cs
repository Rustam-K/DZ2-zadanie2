// Напишите программу, которая принимает число и на выходе
//показывает вторую цтфру этого числа

//using System.Collections.Generic;

int ReadInt(string msg)   // Оюъявляем функцию ReadInt и строковый параметр msg
{
    Console.WriteLine(msg);  // пишет в консоль параметр msg
    string numb = Console.ReadLine();   // функция считывания строки с консоли (терминала)
    int number;  // вводим переменную намбер
    number = int.Parse(numb);  // как результат преобразования строки в число
    return number; // возврат из функции
} // описание функции хаканчивается

int number = ReadInt("Введите целое число в диапазоне от 1 до 999999999");

int cifra = ReadInt("Введите какую цифру числа " + number + " вы хотите получить ?");
int ind = 0; //  Счетчик
int digit = 10;  // Делитель
int numb = number % digit;  // Производная из остатков

while (numb! < number)   // Цикл определения количества цифр в числе
{
    numb = number % digit;
    ind++;
    digit = digit * 10;
}
// return ind

int ind1 = ind;  // Переменная обратного отсчета
int ostatok = number;   // Контрольный остаток

while (ind1 != cifra) // Цикл нахождения цифры
{
    ostatok = ostatok / 10;
    ind1 = ind1 - 1;
}
Console.WriteLine("В числе " + number + " " + cifra + " цифра - это " + ostatok % 10);
