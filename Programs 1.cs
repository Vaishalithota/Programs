

using System;
class Sockmatch {
static void Main(String[] args) {
int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
Array.Sort(arr);
int res = 0;
for (int i = 1; i < n; i++) {
if (arr[i] == arr[i - 1]) { res++; i++; }
}
Console.WriteLine(res);
}
}