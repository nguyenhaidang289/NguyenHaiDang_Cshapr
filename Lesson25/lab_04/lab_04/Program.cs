namespace lab_04
{
    internal class Progam
    {
        static void main(String[] args)
        {
            // khoi tao lop window 
            window win = new window(1, 2);
            // khoi tao lop listbox 
            listbox lb = new listbox(3, 4, " STAND alone list box ");
            // khoi tao lop button
            button b = new button(5, 6);
            win.Drawwindow();
            lb.Drawwindow();
            b.Drawwindow();
            // khoi tao mang window 
            window[] winarray = new window[3];
            winarray[0] = new window(1, 2);
            winarray[1] = new window(3, 4);
            winarray[2] = new window(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winarray[i].Drawwindow();
            }

        }
    }
}