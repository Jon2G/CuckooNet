using Cuckoo.Net.Enums;

namespace Cuckoo.Net.ResponseModels
{
    public class HtmlReport : CuckooReport
    {
        public override ReportFormat Format => ReportFormat.HTML;
        public HtmlReport() : base()
        {

        }
        public override async Task Save(string path, string name)
        {
            using (FileStream file = new FileStream(Path.Combine(path, $"{name}.html"), FileMode.OpenOrCreate))
            {
                using (StreamWriter writter = new StreamWriter(file))
                {
                    await writter.WriteAsync(TextData);
                }
            }
        }
    }
}
