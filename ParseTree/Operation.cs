using System;
using System.Collections.Generic;

namespace ParseTree
{
    public class Operation: INodeOperation
    {
        public string operation;
        public INodeOperation leftNode;
        public INodeOperation rightNode;

        public Operation(string o, INodeOperation lnode, INodeOperation rnode){
            operation = o;
            leftNode = lnode;
            rightNode = rnode;
        }

        public double getValue(){
            double result = 0;
            double leftNum = leftNode.getValue();
            double rightNum = rightNode.getValue();
            
            switch(operation){
                case "+":
                    result = leftNum + rightNum;
                break;

                case "-":
                    result = leftNum - rightNum;
                break;

                case "*":
                    result = leftNum * rightNum;
                break;

                case "/":
                    result = leftNum / rightNum;
                break;

                default:
                    Console.WriteLine("Unknown operation");
                break;

            }
            return result;
        }
    }
}
