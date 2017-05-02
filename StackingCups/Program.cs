using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackingCups
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<decimal, string> outputs = new SortedList<decimal, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                int result = 0;

                if (int.TryParse(inputs[0], out result))
                {
                    outputs.Add((result / 2), inputs[1]);
                }
                else
                {
                    outputs.Add(decimal.Parse(inputs[1]), inputs[0]);
                }
            }

            foreach (var kvp in outputs)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
