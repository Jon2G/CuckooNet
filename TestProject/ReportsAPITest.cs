using Cuckoo.Net.Enums;
using Cuckoo.Net.Internal;
using Cuckoo.Net.ResponseModels.Reports;
using System.Net;

namespace TestProject
{
    public class ReportsAPITest : TestBase
    {
        [Test]
        public async Task JsonReportTest()
        {
            Response<CuckooReport> response = await this.API.Tasks.Report(7, ReportFormat.JSON);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response, Is.Not.Null);
            CuckooReport? report = response.Content;
            if (report is { })
                await report.Save("jsonReport");
        }

        [Test]
        public async Task HtmlReportTest()
        {
            Response<CuckooReport> response = await this.API.Tasks.Report(7, ReportFormat.HTML);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response, Is.Not.Null);
            CuckooReport? report = response.Content;
            if (report is { })
                await report.Save("htmlReport");
        }
        [Test]
        public async Task PackageFilesReportTest()
        {
            Response<CuckooReport> response = await this.API.Tasks.Report(7, ReportFormat.PACKAGE_FILES);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response, Is.Not.Null);
            CuckooReport? report = response.Content;
            if (report is { })
                await report.Save("sample");
        }
        [Test]
        public async Task TarBz2ReportTest()
        {
            Response<CuckooReport> response = await this.API.Tasks.Report(7, ReportFormat.DROPPED);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response, Is.Not.Null);
            CuckooReport? report = response.Content;
            if (report is { })
                await report.Save("TarBz2Report");
        }
    }
}
