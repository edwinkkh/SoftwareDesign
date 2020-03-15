using System;
using System.Collections.Generic;

namespace ParseTree
{
    public class Leaf: INodeOperation
    {
       double value = 0;

       public Leaf(double v){
            value = v;
        }

        public double getValue(){
           return value;
        }
    }
}
