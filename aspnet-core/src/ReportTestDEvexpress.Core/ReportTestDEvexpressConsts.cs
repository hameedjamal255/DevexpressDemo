using ReportTestDEvexpress.Debugging;

namespace ReportTestDEvexpress
{
    public class ReportTestDEvexpressConsts
    {
        public const string LocalizationSourceName = "ReportTestDEvexpress";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "bb74730a84f844eaba6601aecbcb5687";
    }
}
