using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_lab3
{
    /// <summary>
    /// Интерфейс контроллера базы данных
    /// </summary>
    /// <param name="Date"></param> - дата события
    /// <param name="EventName"></param> - название праздника
    /// <param name="PersonName"></param> - имя празднующего
    public interface IDBController
    {
        public bool TrySaveEventData(String Date, String EventName, String PersonName);
    }

    /// <summary>
    /// Попытка сохранения данных, проверка на возможность сохранения
    /// </summary>
    public class MockTrySaveEventData : IDBController
    {
        public bool TrySaveEventData(String Date, String EventName, String PersonName)
        {
            if (Date == null || Date.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyDate);
            }

            if (EventName == null || EventName.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyEventName);
            }

            if (PersonName == null || PersonName.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyPersonName);
            }

            return true;
        }
    }
}
