using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalconConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HDevelopExport hd = new HDevelopExport(@"D:/paperclip.png");
            hd.RunHalcon(hd.hv_ExpDefaultWinHandle);
            HDevelopExport hd2 = new HDevelopExport(@"D:/paperclip2.png");
            hd2.RunHalcon(hd2.hv_ExpDefaultWinHandle);
            Console.ReadLine();
        }
    }
}
