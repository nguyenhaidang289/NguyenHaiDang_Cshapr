using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    internal class button : window
    {
        public button(int top, int left) : base(top, left) { }
        public override void Drawwindow()   
        {
            Console.WriteLine("drawing a button at {0},{1}\n", top, left);
        }
    }
}
