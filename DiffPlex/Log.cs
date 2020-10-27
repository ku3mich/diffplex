using System.Diagnostics;

namespace DiffPlex
{
    public static class Log
    {
        [Conditional("LOG")]
        public static void WriteLine(string format, params object[] args)
        {
            Debug.WriteLine(string.Format(format, args));
        }

        [Conditional("LOG")]
        public static void Write(string format, params object[] args)
        {
#if !NETSTANDARD1_0
            Debug.Write(string.Format(format, args));
#else
            Debug.WriteLine(string.Format(format, args));
#endif
        }
    }
}