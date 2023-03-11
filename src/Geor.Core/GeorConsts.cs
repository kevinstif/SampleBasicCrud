using Geor.Debugging;

namespace Geor
{
    public class GeorConsts
    {
        public const string LocalizationSourceName = "Geor";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a3b6cff18397446a90ea144e19580f7d";
    }
}
