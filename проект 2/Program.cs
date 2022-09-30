Random rn = new Random();
int userNum, randomNum;
randomNum = rn.Next(100);
int action = 1;

while (action != 4)
{
    Console.WriteLine("Выберете действие:");
    Console.WriteLine("1.Угадай число \n2.Таблица умножения \n3.Вывод делителей числа");
    action = Convert.ToInt32(Console.ReadLine());

    if (action == 1)
    {
        Console.WriteLine("угадай число от 0 до 100 ");
        userNum = Convert.ToInt32(Console.ReadLine());
        if (userNum > randomNum) Console.WriteLine("Надо меньше");
        else if (userNum < randomNum) Console.WriteLine("Надо больше");

    }

    else
    {
        Console.WriteLine("Вы угадали число");

    }

}
if (action == 2)
{
    int[,] matrix = new int[9, 9];
    for (int i = 1; i < 10; i++)
    {
        for (int j = 1; j < 10; j++)
        {
            matrix[i - 1, j - 1] = i * j;
        }
    }




    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            Console.Write(matrix[i, j] + "\t");

        }
        Console.WriteLine();
    }

}


