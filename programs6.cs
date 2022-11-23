using System;
public class Test
{
public static void Main()
{
String s = "2A3B4C";
String ans = "";
for(int i = 0; i < s.Length;){
int num = 0;
while(s[i] >= '0' && s[i] <= '9'){
num = num * 10 + (s[i] - '0');
i++;
}
while(num-- > 0){
ans += s[i];
}
i++;
}
Console.WriteLine(ans);
}
}
