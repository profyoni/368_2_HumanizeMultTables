using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace HumanizeMultTables
{
    public static class MultTables
    {
        public static string MultiplierRow(int row, int colStart, int colEnd, bool header = true)
        {
            StringBuilder sb = new StringBuilder(header ? $"{row.ToWords(),10} | " : "");
            for (int i = colStart; i <= colEnd; i++)
            {
                sb.Append($"{(row * i).ToWords(),10} | ");
            }
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int GridSize = 5;
            Console.WriteLine($"{"",13}" + MultTables.MultiplierRow(1, 1, GridSize, header: false));
            for (int i = 1; i <= GridSize; i++)
            {
                Console.WriteLine(new String('_', (GridSize + 1) * 13));
                Console.WriteLine(MultTables.MultiplierRow(i, 1, GridSize));
            }
            Console.ReadLine();
        }
    }
}
