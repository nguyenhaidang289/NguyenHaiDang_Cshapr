using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    internal class window
    {
        // khai bao cac truong
        protected int top ;
        protected int left;
        // phuong thuc khoi tao
        public window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void Drawwindow()
        {
            Console.WriteLine("window : drawing window at {0},{1}",top,left);
        }
    }
}
