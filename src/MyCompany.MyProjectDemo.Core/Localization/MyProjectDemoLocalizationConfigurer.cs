using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyCompany.MyProjectDemo.Localization
{
    public static class MyProjectDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MyProjectDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MyProjectDemoLocalizationConfigurer).GetAssembly(),
                        "MyCompany.MyProjectDemo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
