﻿//Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int number = numberSintezator.Next(100,1000);
//Выводим данные в консоль
Console.WriteLine (number);
//Получаем старший разряд числа
int firstNumber = number/100;
//Получаем младший разряд числа
int secondNumber = number%10;

int result = firstNumber*10 + secondNumber;
Console.WriteLine (result);
