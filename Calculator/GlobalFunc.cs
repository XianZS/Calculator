using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class GlobalFunc
    {
        // 单例模式
        private static GlobalFunc _Instance;
        public static GlobalFunc Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new GlobalFunc();
                return _Instance;
            }
        }
        public string NowString = "";
        public string HistoryString = "";
        public int Index = 1;
    }
}
