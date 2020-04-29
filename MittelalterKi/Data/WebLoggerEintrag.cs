namespace MittelalterKi.Data
{
    public class WebLoggerEintrag
    {
        private static ulong sNr = 0;
        public readonly ulong Nr;
        public readonly string LogLevel;
        public readonly string Msg;

        public WebLoggerEintrag(string logLevel, string msg)
        {
            Nr = sNr++;
            LogLevel = logLevel;
            Msg = msg;
        }
    }
}
