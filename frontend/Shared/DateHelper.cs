using System.Text.RegularExpressions;

namespace frontend.Shared
{

    public class DateHelper
    {
        public static DateTime ExtractDateFromFlyer(FlyerModel flyer)
        {
            var input = flyer.ActualDate;

            // Match pattern: 250710
            var match = Regex.Match(input, @"(\d{6})");
            if (match.Success)
            {
                var raw = match.Groups[1].Value;
                try
                {
                    var year = 2000 + int.Parse(raw.Substring(0, 2));
                    var month = int.Parse(raw.Substring(2, 2));
                    var day = int.Parse(raw.Substring(4, 2));
                    return new DateTime(year, month, day);
                }
                catch { }
            }

            // Match pattern: akcios-ujsag-29-het-2025
            match = Regex.Match(input, @"(\d{2})-het-(\d{4})");
            if (match.Success)
            {
                int week = int.Parse(match.Groups[1].Value);
                int year = int.Parse(match.Groups[2].Value);
                var jan1 = new DateTime(year, 1, 1);
                int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;
                var firstThursday = jan1.AddDays(daysOffset);
                var firstWeekStart = firstThursday.AddDays(-3);
                return firstWeekStart.AddDays((week - 1) * 7);
            }

            return DateTime.MinValue;

        }
    }
}
