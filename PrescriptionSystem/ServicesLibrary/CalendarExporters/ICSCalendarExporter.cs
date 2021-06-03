using System.Collections.Generic;

namespace ServicesLibrary.CalendarExporters
{
    public class ICSCalendarExporter:ICalendarExporter
    {
        private ICSCalendarExporter()
        {
        }

        public static ICalendarExporter Instance { get; } = new ICSCalendarExporter();

        public void ExportCalendar(IEnumerable<int> therapySessionIDs, IEnumerable<int> prescriptionIDs)
        {
            throw new System.NotImplementedException();
        }
    }
}