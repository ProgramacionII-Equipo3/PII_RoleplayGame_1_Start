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
            return r < 0 ? (int) 0 : (int) r;
        }
    }
}