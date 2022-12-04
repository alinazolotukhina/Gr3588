//Считываем данные с консоли
string? inputLine01 = Console.ReadLine();
string? inputLine02 = Console.ReadLine();
string? inputLine03 = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine01 != null && inputLine02 != null && inputLine03 != null)
{
    int inputNumber01 = int.Parse(inputLine01);
    int inputNumber02 = int.Parse(inputLine02);
    int inputNumber03 = int.Parse(inputLine03);
    //Сравниваем 1е и 2е число
    if (inputNumber01 > inputNumber02)
    {
        //Если 1е число больше, сравниваем его с 3м
        if (inputNumber01 > inputNumber03)
        {
            // 1е число максимально
            Console.WriteLine("1е число максимальное и равно " + inputNumber01);
        }
        else
        {
            //3е число максимально
            Console.WriteLine("3е число максимальное и равно " + inputNumber03);
        }
    }
    else
    {
        //Если 2е число больше, сравниваем его с 3м
        if (inputNumber02 > inputNumber03)
        {
            Console.WriteLine("2е число максимальное и равно " + inputNumber02);
        }
        else
        {
            Console.WriteLine("3е число максимальное и равно " + inputNumber03);
        }
    }
}
