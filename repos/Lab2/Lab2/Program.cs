
internal class Program
{
    private static void Main(string[] args )
    {
        Console.WriteLine("введите колличсктво строк");
        string? string_K = Console.ReadLine();
        Console.WriteLine("введите колличсктво столбцов");
        string? string_M = Console.ReadLine();

        int int_K = int.Parse(string_K);
        int int_M = int.Parse(string_M);

        int[,] num_array = new int[int_K, int_M];

        var rand = new Random();

        for (int i = 0; i < int_K; i++)
        {
            for (int j = 0; j < int_M; j++)
            {
                num_array[i, j] = rand.Next(0, 100);
            }
        }
        for (int i = 0; i < int_K; i++)
        {
            for (int j = 0; j < int_M; j++)
            {
                Console.WriteLine($"K: {i+1}, M: {j+1}, Num: {num_array[i, j]}");
            }
        }
        
        string input_K = Console.ReadLine();
        int input_int_K = Convert.ToInt16(input_K);
        int all_K_int = 0;
        int_M -= 1;
        for (int M_len = 0; M_len <= int_M; M_len++)
        {
            all_K_int = all_K_int + num_array[M_len, input_int_K];
        }
        Console.WriteLine($"Колличество дет: {int_M}, сред значене {all_K_int/ int_M}");
    }
}