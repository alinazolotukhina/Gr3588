//Считываем данные с консоли
string? inputLine01 = Console.ReadLine();
string? inputLine02 = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine01 != null && inputLine02 != null)
{
    int inputNumber01 = int.Parse(inputLine01);
    int inputNumber02 = int.Parse(inputLine02);
    //Числа равны
  if (inputNumber01 == inputNumber02) 
  {
    Console.WriteLine("1е число равно второму ");
  }
    else
    {
    //Сравниваем 1е и 2е число
    
        if (inputNumber01 > inputNumber02)
            //1е число больше
            Console.WriteLine("1е число больше второго ");

        else
        
            //2е число больше
            Console.WriteLine("2е число больше первого ");

    }    

}
