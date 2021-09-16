using System;

namespace Library
{
    public static class Utils
    {
        /// <summary>
        /// Calculates the amount of damage inflicted during an attack.
        /// </summary>
        /// <param name="attack">The net attack of the active character.</param>
        /// <param name="defense">The net defense of the passive character.</param>
        /// <returns></returns>
        public static int CalcDamage(int attack, int defense)
        {
            int r = attack - defense;
            return r < 0 ? 0 : r;
        }

        /// <summary>
        /// Checks if the given argument value is null, and throws an exception if it is.
        /// </summary>
        /// <param name="value">The given value</param>
        /// <param name="paramName">The argument name, to pass it to the exception.</param>
        /// <typeparam name="T">The type of the given value</typeparam>
        /// <exception cref="ArgumentNullException">The given value is null</exception>
        public static void CheckNull<T>(T value, string paramName)
        {
            if(value == null) throw new ArgumentNullException(paramName);
        }
        
        /// <summary>
        /// Checks if the given argument string is null, empty, or only whitespace, and throws an exception if it is.
        /// </summary>
        /// <param name="str">The given value</param>
        /// <param name="paramName">The argument name, to pass it to the exception.</param>
        /// <exception cref="ArgumentNullException">The given value is null, empty, or only whitespace.</exception>
        public static void CheckString(string str, string paramName)
        {
            if(string.IsNullOrWhiteSpace(str)) throw new ArgumentNullException(paramName);
        }
    }
}