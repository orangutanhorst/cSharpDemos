using System;
using System.Linq;

namespace MoreLinq
{
    class MoreLinqDemo
    {
        public MoreLinqDemo()
        {
            //BatchDemo();
            //InterLeaveDemo();
            //PermutationDemo();
            SplitDemo();
        }

        private void SplitDemo()
        {
            var rand = new Random();
            var numbers = Enumerable.Range(1, 20).Select(_ => rand.Next(10));
            var split = numbers.Split(5);
            foreach (var group in split)
            {
                Console.WriteLine($"{group.Count()} elements : "+ string.Join(", ",group));
            }
        }

        private void BatchDemo()
        {
            var numbers = Enumerable.Range(1, 100);
            foreach (var batch in numbers.Batch(10))
            {
                Console.WriteLine("Got a batch");
                foreach (var i in batch)
                {
                    Console.Write($"{i}\t");
                }
            }
        }

        private void InterLeaveDemo()
        {
            var rand = new Random();
            var wholeNumbers = Enumerable.Range(1, 10).Select(_ => (double) rand.Next(10));
            var fractNumbers = Enumerable.Range(1, 10).Select(_ => rand.NextDouble());

            foreach (var number in wholeNumbers.Interleave(fractNumbers))
            {
                Console.Write(number);
                Console.Write("\t");

            }
        }

        private void PermutationDemo()
        {
            char[] letters = "draw".ToCharArray();
            foreach (var perm in letters.Permutations())
            {
                Console.WriteLine(new string(perm.ToArray()));                
            }

        }
    }
}