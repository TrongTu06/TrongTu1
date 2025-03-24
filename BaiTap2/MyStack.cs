using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public class Stack
    {
        private Node top;
        public Stack()
        {
            top = null;
        }
        public bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }
            return false;
        }
        public void Push(int x)
        {
            Node p = new Node(x);
            if (top == null)
            {
                top = p;
            }
            else
            {
                p.next = top;
                top = p;
            }
        }
        public int Pop()
        {
            if (top != null)
            {
                int x = top.data;
                top = top.next;
                return x;
            }
            return -1;
        }
        public int Peek()
        {
            if (top != null)
            {
                return top.data;
            }
            return -1;
        }
    }
}
