using System;
namespace baithuchanh1
{
    class Stack
    {
        private int top;
        private int[] s;
        public Stack()
        {
            top = -1;
            s = new int[20];
        }
        public Stack(int n)
        {
            top = -1;
            s = new int[n];
        }
        public bool isEmpty()
        {
            return top == -1;
        }
        public bool isFull()
        {
            return top == s.Length - 1;
        }
        public void Push(int x)
        {
            if (isFull())
                Console.WriteLine("Stack day");
            else
                s[++top] = x;
        }
        public int Pop()
        {
            if (isEmpty())
                throw new Exception("Stack rong");
            else
            {
                int x = s[top--];
                return x;
            }
        }
        static void Main3(string[] args)
        {
        }
    }
}
