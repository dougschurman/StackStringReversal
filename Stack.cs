using System;

namespace StackADT
{
    class Stack
    {
        private char[] data_;
        private int top;
        private int max;
        public Stack(int size)
        {
            data_ = new char[size];
            top = -1;
            max = size;
        }

        public Stack(Stack stack)
        {
            data_ = stack.data_;
            top = stack.top;
            max = stack.max;
        }

        ~Stack()
        {

        }

        public void Push(char item)
        {
            if(top == max - 1)
            {
                Console.WriteLine("Overflow");
                return;
            }
            else
            {
                data_[++top] = item;
            }
        }

        public char Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Empty");
                return '0';
            }
            else
            {
                return data_[top--];
            }
        }

        public int GetSize()
        {
            return max;
        }

        public void PrintStack()
        {
            for(int i=top; i>-1; i--)
            {
                Console.WriteLine(data_[i]);
            }
        }
    }
}

