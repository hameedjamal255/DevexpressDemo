using System.Collections.Generic;

namespace ReportTestDEvexpress.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
