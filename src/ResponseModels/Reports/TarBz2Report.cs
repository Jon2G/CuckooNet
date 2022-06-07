using Cuckoo.Net.Enums;

namespace Cuckoo.Net.ResponseModels.Reports
{
    public class TarBz2Report : CuckooReport
    {
        public override ReportFormat Format => ReportFormat.ALL;
        private readonly Stream Stream;
        public TarBz2Report(Stream stream) : base()
        {
            Stream = stream;
        }

        public override async Task Save(string path, string name)
        {
            using (FileStream file = new FileStream(Path.Combine(path, $"{name}.tar.bz2"), FileMode.OpenOrCreate))
            {
                await this.Stream.CopyToAsync(file);
            }
#if NETSTANDARD
            Stream.Dispose();
#else
            await Stream.DisposeAsync();
#endif
        }
    }
}
