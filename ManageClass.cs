using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_lab3
{
    public class ManageClass
    {
        public static int index = 3;
        public static IDBController GetDatabaseController()
        {
#if DEBUG
            switch (index)
            {
                case 0: throw new NotImplementedException(); break;
                case 1: return new MockTrySaveEventData(); break;
            }
            return null;
#else
throw new NotImplementedException();
#endif
        }
#if DEBUG
        public class MockEventEntry : CreateEventPopup
        {
            public string Date { get; set; }
            public string EventName { get; set; }
            public string PersonName { get; set; }
        }
       
#endif
    }
}
