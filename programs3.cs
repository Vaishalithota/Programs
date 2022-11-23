

        public class Brackets {
    public class stack {
        public int top = -1;
        public char[] items = new char[100];
        public void push(char x)
        {if (top == 99) {
                Console.WriteLine("Stack is full");}
          else {
                items[++top] = x;}}
         char pop()
        { if (top == -1) {
                Console.WriteLine("Underflow error");
                return '\0';}
         else { char element = items[top];
                top--;
                return element;
            }}
         Boolean isEmpty()
        { return (top == -1) ? true : false;
        }}
    static Boolean Matching(char char1,char char2)
    {
        if (char1 == '(' && char2 == ')')
            return true;
        else if (char1 == '{' && char2 == '}')
            return true;
        else if (char1 == '[' && char2 == ']')
            return true;
        else
            return false;}
    static Boolean BracketsBalanced(char[] exp)
    { Stack<char> st = new Stack<char>();
        for (int i = 0; i < exp.Length; i++) {
            
            if (exp[i] == '{' || exp[i] == '('
                || exp[i] == '[')
                st.Push(exp[i]);
            if (exp[i] == '}' || exp[i] == ')'
                || exp[i] == ']') {
 
                if (st.Count == 0) {
                    return false;
                }
 else if (!Matching(st.Pop(),exp[i])) {
                    return false;
                }}}
         if (st.Count == 0)
            return true; 
        else {
          return false;}}
      public static void Main(String[] args)
    {
        char[] exp = { '(', '(', ')', '[', ')', ')' };
 
        if (BracketsBalanced(exp))
            Console.WriteLine("Balanced ");
        else
            Console.WriteLine("Not Balanced ");}}