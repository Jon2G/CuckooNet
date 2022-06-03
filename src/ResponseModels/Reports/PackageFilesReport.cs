using Cuckoo.Net.Enums;

namespace Cuckoo.Net.ResponseModels.Reports
{
    public class PackageFilesReport : CuckooReport
    {
        public override ReportFormat Format => ReportFormat.PACKAGE_FILES;
        private readonly Stream Stream;
        public PackageFilesReport(Stream stream) : base()
        {
            Stream = stream;
        }
        public override async Task Save(string path, string name)
        {
            using (FileStream file = new FileStream(Path.Combine(path, $"{name}.tar.bz2"), FileMode.OpenOrCreate))
            {
                await this.Stream.CopyToAsync(file);
            }
            await Stream.DisposeAsync();
        }
    }
}
