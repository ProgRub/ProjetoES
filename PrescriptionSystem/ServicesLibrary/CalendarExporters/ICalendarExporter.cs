using System.Collections;
using System.Collections.Generic;

namespace ServicesLibrary.CalendarExporters
{
    public interface ICalendarExporter
    {
        public void ExportCalendar(IEnumerable<int> therapySessionIDs, IEnumerable<int> prescriptionIDs);
    }
}