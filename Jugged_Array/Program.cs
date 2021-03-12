using System;

namespace Jugged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                JuggedArray j = new JuggedArray(6, 3, 7);
                j.FillRand(-20, 20);
                Console.WriteLine(j.ToString());
                Console.WriteLine(j.Rows);
                Console.WriteLine($"Element j[1][2]: {j[1][2]}");
                Console.WriteLine($"Count of colums in row(0): {j.Colums(0)}");
                int[] res = j[1];
                string resStr = String.Join('\t', res);
                Console.WriteLine("Row[1]: "+resStr);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
