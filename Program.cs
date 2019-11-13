using System;

namespace solid_waffle
{
    class Program
    {
        static void Main(string[] args)
        {
            var apples = new[] { "honeycrisp", "fuji" };
            var oranges = new[] { "mandarin", "navel" };
            var buckets = new[] { apples, oranges };
            var total = 1;

            for(var i = 0; i < buckets.Length; i ++)
                total = total * buckets[i].Length;

            var state = new int[buckets.Length];

            Output(buckets, state);

            for(var i = 0; i < total; i ++)
            {
                for(var j = buckets.Length - 1; j >= 0; j--)
                {
                    if (state[j] == buckets[j].Length - 1)
                    {
                        state[j] = 0;
                    }

                    else
                    {
                        state[j]++;

                        Output(buckets, state);

                        break;
                    }
                }
            }
        }

        static void Output(string[][] buckets, int[] state)
        {
            for(var i = 0; i < state.Length; i++)
            {
                Console.WriteLine(buckets[i][state[i]]);
            }

            Console.WriteLine();
        }
    }
}
