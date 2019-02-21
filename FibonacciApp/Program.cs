using System;
using System.Collections.Generic;

namespace FibonacciApp
{
    /// <summary>
    /// 
    /// Base Program-class.
    /// Calls of NNacci class.
    /// 
    /// Author: laveez
    /// 
    /// Creation date: 21.02.2019
    /// 
    /// </summary>
    class Program
    {

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Args</param>
        static void Main(string[] args)
        {
            NNacci two = new NNacci(20, 2);
            two.Run();

            NNacci three = new NNacci(20, 3);
            three.Run();

            NNacci four = new NNacci(20, 4);
            four.Run();

            NNacci five = new NNacci(20, 5);
            five.Run();

            NNacci six = new NNacci(20, 6);
            six.Run();

            NNacci seven = new NNacci(20, 7);
            seven.Run();

            NNacci x = new NNacci(300, 2);
            x.Run();
        }
    }
}
