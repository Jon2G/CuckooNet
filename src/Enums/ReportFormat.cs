using System.ComponentModel;

namespace Cuckoo.Net.Enums
{
    public enum ReportFormat
    {
        JSON, HTML, ALL, DROPPED, PACKAGE_FILES
    }

    public static class _ReportFormat
    {
        public static string GetString(this ReportFormat format)
        {
            switch (format)
            {
                case ReportFormat.JSON:
                    return "json";
                case ReportFormat.HTML:
                    return "";
                case ReportFormat.ALL:
                    return "all";
                case ReportFormat.DROPPED:
                    return "dropped";
                case ReportFormat.PACKAGE_FILES:
                    return "package_files";
            }
            throw new InvalidEnumArgumentException(nameof(format));
        }
    }
}
