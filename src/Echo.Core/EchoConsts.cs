using Echo.Debugging;

namespace Echo
{
    public class EchoConsts
    {
        public const string LocalizationSourceName = "Echo";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ca5c9284c3c64ecb97b4315ecb521735";
    }
}
