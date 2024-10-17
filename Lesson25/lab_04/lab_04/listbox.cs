using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    internal class listbox:window
    {
        // khai bao truong moi
        private string listboxcontents;
        // phuong thuc khoi tao
        public listbox(int top, int left, string contents) : base(top, left) // goi contruction lop co so
        {

        }
        // ghi de phuong thuc drawwindow
        public override void Drawwindow()
        {
            base.Drawwindow(); // goi phuong thuc lop co so
            Console.WriteLine("writing string to the listbox : {0} ", listboxcontents);
        }
    }
}
