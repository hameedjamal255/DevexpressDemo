using Abp.AutoMapper;
using ReportTestDEvexpress.Authentication.External;

namespace ReportTestDEvexpress.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
