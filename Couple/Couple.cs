using System;

namespace Couple
{
    class Couple
    {
        public static int maxInstance = 0;
        static Couple c1;
        static Couple c2;
        
        public static Couple GetInstance(int number){
          
          if(c1 == null){
              c1 = new Couple();
          }

          if(c2 == null){
              c2 = new Couple();
          }
          
          if(number == 1){
              return c1;
          } else {
                return c2;
            }
        }
    }

}