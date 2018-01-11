using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppCsharp
{
    public class Globals
    {
        private static WhatsAppDataSet _db;

        public static WhatsAppDataSet DB
        {
            get
            {
                if (_db == null)
                {
                    _db = new WhatsAppDataSet();
                }
                return _db;
            }

        }
    }
}
