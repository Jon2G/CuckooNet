namespace Cuckoo.Net.ResponseModels
{
    public class ZipResponse
    {
        private readonly Stream Stream;

        public ZipResponse(Stream stream) : base()
        {
            Stream = stream;
        }
        public Task Save(string name) => Save(Environment.CurrentDirectory, name);
        public async Task Save(string path, string name)
        {
            using (FileStream file = new FileStream(Path.Combine(path, $"{name}.zip"), FileMode.OpenOrCreate))
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
