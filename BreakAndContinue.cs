using System;
class BreakAndContinue {
    public static void printNumber(int i)
    {
        for(int j=i;j<=10;j++)
        {
           
           if(j==4)
           {
               continue;
               //it will not print the 4 beacause of the continue keyword
           }
           if(j==6)
           {
               break;
           }
           Console.WriteLine(j);
        }
    }
  static void Main() {
      int i=1;
      printNumber(i);
  }
}
