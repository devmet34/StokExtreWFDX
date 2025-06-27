using System;

namespace StokExtreWFDX;
public class ReportFactory : IReportFactory
{

    public IDxReport CreateReport()
    {
        var report = new Report2();
        //mc, Parameters being modified accordingly on report submit event.
        report.ParametersRequestSubmit += (s, args) =>
        {
            report.Parameters["baslangicInt"].Value = ((DateTime)report.Parameters["baslangic"].Value).ToOADate() - 2;
            report.Parameters["bitisInt"].Value = ((DateTime)report.Parameters["bitis"].Value).ToOADate() - 2;
        };
        return report;
    }
}
