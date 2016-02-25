using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eh.core;

namespace eh.worker
{
    public class WinWorker : IWinWorker
    {
        public string readWord(string path)
        {
            return "<readWord>" + path;
        }

        public string writeWord(string content)
        {
            return "<writeWord>" + content;
        }
    }
}
 