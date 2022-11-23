using System;
public class Descending {
   public static void Main() {
      int[] arr = new int[5] {98, 76, 99, 32, 77};
      int i, j, temp;
      Console.Write("Elements: 
");
      for(i=0;i<5;i++) {
         Console.Write("{0} ",arr[i]);
      }
      for(i=0; i<5; i++) {
         for(j=i+1; j<5; j++) {
            if(arr[i] < arr[j]) {
               temp = arr[i];
               arr[i] = arr[j];
               arr[j] = temp;
            }
         }
      }
      Console.Write("
Descending order:
");
      for(i=0; i<5; i++) {
         Console.Write("{0} ", arr[i]);
      }
      Console.Write("

");
   }
}

        