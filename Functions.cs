using System;

namespace ProjectSO
{
    public static class Functions
    {
        static Random random = new Random();
        public static T RandomEnumValue<T>(bool includeLast = true) where T : Enum
        {
            var val = Enum.GetValues(typeof(T));
            return (T)val.GetValue(random.Next(val.Length - (includeLast ? 0 : 1)));
        }
    }
}
