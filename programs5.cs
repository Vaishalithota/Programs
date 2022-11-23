using System;
class Reverses {
   static void Main() {
      string str, rev;
      str = "hello";
      rev ="";
      Console.WriteLine("String is {0}", str);
      
      int len;
      len = str.Length - 1;
      while (len >= 0) {
         rev = rev + str[len];
         len--;
      }
      Console.WriteLine("Reversed String is {0}", rev);
      Console.ReadLine();
   }
}