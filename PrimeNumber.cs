using System;
class PrimeNumber {
    public static void primeNumber(int n)
    {
       if(n==0 ||n==1)
       {
           Console.WriteLine(n+" is not a Prime Number ");
       }
       else
       {
       int count=0;
       for(int j=2;j<=n/2;j++){
           if(n%j==0)
           {
              count++; 
              break;
           }
       }
       if(count>0)
       {
           Console.WriteLine(n+" is not a prime number");
       }
       else
       {
           Console.WriteLine(n+" is a prime number");
       }
    }
    }
  static void Main() {
      Console.WriteLine("enter the value : ");
      int a=Convert.ToInt16(Console.ReadLine());
      primeNumber(a);
  }
}
