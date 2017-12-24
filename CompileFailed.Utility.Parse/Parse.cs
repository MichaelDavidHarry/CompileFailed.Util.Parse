using System;
using System.Collections.Generic;
using System.Text;

namespace CompileFailed.Utility
{
    public static class Parse
    {
        /// <summary>
        /// Parses a string to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to parse the string to.</typeparam>
        /// <param name="value">The string to parse.</param>
        /// <returns>T, which is the parsed value of the string.</returns>
        public static T ParseString<T>(String value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        /// Parses a string to the specified nullable type,
        /// returning null if a FormatException occurs during parsing.
        /// </summary>
        /// <typeparam name="T">The type to parse the string to.</typeparam>
        /// <param name="value">The string to parse.</param>
        /// <returns>Nullable<T>, which is the parsed value of the string,
        /// or null if a FormatException or InvalidCastException occurs
        /// during parsing.</returns>
        public static T? ParseStringNullable<T>(String value) where T : struct
        {
            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (FormatException)
            {
                return null;
            }
            catch (InvalidCastException)
            {
                return null;
            }
        }
    }
}
