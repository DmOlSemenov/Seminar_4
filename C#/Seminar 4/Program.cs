Console.WriteLine("Введите номер задачи  ");
int i = int.Parse(Console.ReadLine());
switch (i)
{
    case 1:
    {
        string[,] table = new string[2, 5];
        table[1, 2] = "СЛОВО";
        for (int rows = 0; rows < 2; rows++)
        {
            for (int columns = 0; columns < 5; columns++)
            {
                Console.WriteLine($"-{table[rows, columns]}-");
            }
        }
        
        break;
    }
    case 2:
    {
        
        void PrintArray(int[,] matr)
        {
            for (int p = 0; p < matr.GetLength(0); p++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[p, j]}  ");
                }
                Console.WriteLine();
            }

        }
        void FillArray(int[,] matr)
        {
            for (int p = 0; p < matr.GetLength(0); p++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[p,j] = new Random().Next(1, 10);
                }
                Console.WriteLine();
            }

        }
        int[,] matrix = new int[3, 4];
        PrintArray(matrix);
        FillArray(matrix);
        Console.WriteLine();
        PrintArray(matrix);
        break;
    }
    
}
