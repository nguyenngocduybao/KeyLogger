using System;

namespace KeyLogger
{
    internal class Keys
    {
        public static Keys K { get; internal set; }
        public static Keys LControlKey { get; internal set; }
        public static Keys RControlKey { get; internal set; }
        public static Keys Separator { get; internal set; }

        public static explicit operator Keys(int v)
        {
            throw new NotImplementedException();
        }
    }
}