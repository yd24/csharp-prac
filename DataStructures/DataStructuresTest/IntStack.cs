using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class IntStack
    {
        public int MaxSize { get; set; }
        public int[] StackArray { get; set; }
        public int Top {  get; set; }
        public IntStack(int size) {
            this.MaxSize = size;
            this.StackArray = new int[size];
            this.Top = -1;
        }

        public void Push(int value)
        {
            this.Top++;
            if (this.Top >= this.MaxSize)
            {
                this.MaxSize = this.MaxSize * 2;
                int[] newArray = new int[this.MaxSize];
                Array.Copy(StackArray, newArray, StackArray.Length);
                this.StackArray = newArray;
            }
            this.StackArray[this.Top] = value;
        }

        public int Pop()
        {
            if (this.Top >= 0)
            {
                int val = this.StackArray[this.Top];
                this.Top--;
                return val;
            }
            return -1;
        }

        public int Peek()
        {
            if (this.Top < 0) 
            {
                return -1;
            }
            return this.StackArray[this.Top];
        }

        public int Count()
        {
            return this.StackArray.Length;
        }

    }
}
