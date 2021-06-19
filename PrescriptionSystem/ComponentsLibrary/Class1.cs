using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComponentsLibrary
{
    public class TimeSpanListToStringValueConverter : ValueConverter<ICollection<TimeSpan>, string>
    {
        public TimeSpanListToStringValueConverter() : base(le => ListToString(le), (s => StringToList(s)))
        {

        }
        public static string ListToString(ICollection<TimeSpan> value)
        {
            if (value == null || value.Any())
            {
                return null;
            }
            return string.Join(',', value);
        }

        public static ICollection<TimeSpan> StringToList(string value)
        {
            return string.IsNullOrEmpty(value) ? null : value.Split(',').Select(i => TimeSpan.Parse(i)).ToList();
        }
    }
}
