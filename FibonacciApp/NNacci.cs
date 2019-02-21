using System;
using System.Collections.Generic;

namespace FibonacciApp
{
    /// <summary>
    /// 
    /// N:th degree calculation of Generalizations of Fibonacci numbers.
    /// If Fibonacci, also calculates golden ratio.
    /// 
    /// Author: laveez
    /// 
    /// Creation date: 21.02.2019
    /// 
    /// </summary>
    class NNacci
    {
        public List<int> sequence = new List<int>();
        public double goldenRatio;
        public int Degree;
        public int Limit;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="limit">amount of numbers to be calculated</param>
        /// <param name="degree">Degree of calculation</param>
        public NNacci(int limit, int degree)
        {
            Limit = limit;
            Degree = degree;
        }

        /// <summary>
        /// Generates the n-nacci sequence.
        /// </summary>
        public void Generate()
        {
            sequence.Clear();

            for (var i = 0; i < Limit; i++)
            {
                if (i < Degree - 1)
                {
                    sequence.Add(0);
                }
                else if (i == Degree - 1)
                {
                    sequence.Add(1);
                }
                else
                {
                    int number = 0;
                    for (var j = i - 1; j >= (i - Degree); j--)
                    {
                        number += sequence[j];
                    }
                    sequence.Add(number);
                }
            }
        }

        /// <summary>
        /// Prettyprint.
        /// </summary>
        public void Print()
        {
            Console.WriteLine(Degree + "-nacci sequence:");

            if (sequence.Count > 0)
            {
                Console.WriteLine(String.Join(", ", sequence.ToArray()));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sequence is empty.");
                Console.WriteLine();
            }

            if (goldenRatio > 0)
            {
                Console.WriteLine("Golden ratio:");
                Console.WriteLine(goldenRatio);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Calculates the golden ratio.
        /// </summary>
        public void GoldenRatio()
        {
            Generate();
            double secondLast = Convert.ToDouble(sequence[Limit - 1]);
            double last = Convert.ToDouble(sequence[Limit - 2]);
            goldenRatio = last / secondLast;
        }

        /// <summary>
        /// Easy method for running the class.
        /// </summary>
        public void Run()
        {
            if (Degree == 2)
            {
                GoldenRatio();
            }
            else
            {
                Generate();
            }
            Print();
        }
    }
}

