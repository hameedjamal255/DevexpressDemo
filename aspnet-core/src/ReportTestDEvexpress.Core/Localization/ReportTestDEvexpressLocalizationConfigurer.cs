using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ReportTestDEvexpress.Localization
{
    public static class ReportTestDEvexpressLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ReportTestDEvexpressConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ReportTestDEvexpressLocalizationConfigurer).GetAssembly(),
                        "ReportTestDEvexpress.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
