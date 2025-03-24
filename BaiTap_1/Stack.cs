using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_1
{
    class Stack
    {
        private int[] data;
        private int top;
        public Stack()
        {
            data = new int[100];
            top = -1;
        }
        public Stack(int size)
        {
            data = new int[size];
            top = -1;
        }
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            return false;
        }
        public bool IsFull()
        {
            if (top == data.Length - 1)
            {
                Console.WriteLine("Stack is full");
                return true;
            }
            return false;
        }
        public void Push(int x)
        {
            if (!IsFull())
            {
                top++;
                data[top] = x;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }
        public int Pop()
        {
            if (!IsEmpty())
            {
                int x = data[top--];
                return x;
            }
            Console.WriteLine("Stack rỗng. Không thể lấy phần tử. ");
            return -1;
        }
    }
}
