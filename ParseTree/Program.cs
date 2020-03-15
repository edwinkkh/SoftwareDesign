using System;
using System.Collections.Generic;

namespace ParseTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // calcuate right side node first 
            // 10 + -5
            INodeOperation leftNode = new Leaf(10);
            INodeOperation rightNode = new Leaf(-5);
            INodeOperation rightResult = new Operation("+", leftNode, rightNode);

            // calculate left side result
            // 2 * (result of 10 + -5)
            INodeOperation root = new Leaf(2);
            INodeOperation equation = new Operation("s*", root, rightResult);
            Console.WriteLine(equation.getValue());
            
            Console.WriteLine();
        }
    }
}
