using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Text.RegularExpressions;

namespace Cuckoo.Net.Interfaces.Json
{
    internal class JsonDateTimeConverter : DateTimeConverterBase
    {
        private readonly static Regex DateRegex = new Regex(@"(?<year>\d\d\d\d)-(?<month>\d\d)-(?<day>\d\d) ?(?<hour>\d\d):(?<minute>\d\d):(?<second>\d\d)");
        private static readonly Regex DateGMT = new Regex(@"\w+, (?<day>\d\d) (?<month>\w+) (?<year>\d\d\d\d) (?<hour>\d\d):(?<minute>\d\d):(?<seconds>\d\d) GMT");
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            string json = reader.Value?.ToString();
            if (string.IsNullOrEmpty(json))
                return null;
            Match match = DateRegex.Match(json);
            if (match.Success)
            {
                GroupCollection groups = match.Groups;
                int year = Convert.ToInt32(groups["year"].Value);
                int month = Convert.ToInt32(groups["month"].Value);
                int day = Convert.ToInt32(groups["day"].Value);
                int hours = Convert.ToInt32(groups["hour"].Value);
                int minutes = Convert.ToInt32(groups["minute"].Value);
                int seconds = Convert.ToInt32(groups["second"].Value);

                return new DateTime(year, month, day, hours, minutes, seconds);
            }
            match = DateGMT.Match(json);
            if (match.Success)
            {
                GroupCollection groups = match.Groups;
                int year = Convert.ToInt32(groups["year"].Value);
                int month = 1;
                string monthName = groups["month"].Value;
                switch (monthName)
                {
                    case "January":
                        month = 1;
                        break;
                    case "Frebuary":
                        month = 2;
                        break;
                    case "March":
                        month = 3;
                        break;
                    case "April":
                        month = 4;
                        break;
                    case "May":
                        month = 5;
                        break;
                    case "June":
                        month = 6;
                        break;
                    case "July":
                        month = 7;
                        break;
                    case "August":
                        month = 8;
                        break;
                    case "September":
                        month = 9;
                        break;
                    case "October":
                        month = 10;
                        break;
                    case "November":
                        month = 11;
                        break;
                    case "December":
                        month = 12;
                        break;
                }
                int day = Convert.ToInt32(groups["day"].Value);
                int hours = Convert.ToInt32(groups["hour"].Value);
                int minutes = Convert.ToInt32(groups["minute"].Value);
                int seconds = Convert.ToInt32(groups["seconds"].Value);
                return new DateTime(year, month, day, hours, minutes, seconds);
            }

            return null;
        }
    }
}
