static void WriteBoard(int size)
{
    for (int i = 0; i < size; i++)        // строки
    {
        for (int j = 0; j < size; j++)    // столбцы
        {
            if ((i + j) % 2 != 0)
                Console.Write('.');
            else
                Console.Write('#');
        }
        Console.WriteLine(); // переход на новую строку
    }
    Console.WriteLine();
}