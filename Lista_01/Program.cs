using System.Threading;

namespace Lista_01
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Menu.MenuOpcoes();
        } 
    }
}
