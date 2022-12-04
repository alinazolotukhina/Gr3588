//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine!=null)
{
//Парсим введенное число
   int inputNumber = int.Parse(inputLine);
   int index = 2;
//Выходное значение
   string outLine = string.Empty;

   while ( index < inputNumber+1)
   {
    outLine = outLine + index + ',';
    index = index+2;
   }
   outLine = outLine.TrimEnd(',');;

   Console.WriteLine(outLine);
}
