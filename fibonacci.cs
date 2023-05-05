using System;
class First {
    
    public static void fibonacciSeries(int first,int second,int n)
    {
       if(n==0)
       {
           return;
       }
       int sum=first+second;
       Console.WriteLine(sum);
       first=second;
       second=sum;
       fibonacciSeries(first,second,n-1);
    }
    
  static void Main() {
      int a=0;
      int b=1;
      int n=10;
      Console.WriteLine(a);
      Console.WriteLine(b);
      fibonacciSeries(a,b,n-2);
  }
}