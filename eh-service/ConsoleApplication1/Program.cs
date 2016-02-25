using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eh.core;
using eh.worker;

namespace eh.service
{
    class WordService
    {
        static void Main(string[] args)
        {
            IWinWorker win = new WinWorker();
            IMacWorker mac = new MacWorker();
            Console.WriteLine(win.readWord("myWordPath"));
            Console.WriteLine(win.writeWord("myWordContent"));
            Console.WriteLine(mac.parseXml("myWordXml"));
            Console.WriteLine(mac.wordCommond("myWordCommond"));
        }
    }
}
