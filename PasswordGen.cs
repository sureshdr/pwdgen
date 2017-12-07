using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pwdgen
{
    public class PasswordGen
    {
        public static bool useLower;
        public static bool useUpper;
        public static bool useNumeric;
        public static bool useSpecial;
        public static bool useBracket;
        public static bool useSpace;

        public static string Generate(int length = 21)
        {
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeric = "0123456789";
            const string special = "!'@#^$+½%&{/[(])}=\\?|_-*:";
            const string bracket = "(){}[]<>";
            const string space = " ";

            var sb = new StringBuilder();
            if (useBracket)
                sb.Append(bracket);
            if (useLower)
                sb.Append(lowerChars);
            if (useNumeric)
                sb.Append(numeric);
            if (useSpace)
                sb.Append(space);
            if (useSpecial)
                sb.Append(special);
            if (useUpper)
                sb.Append(upperChars);

            return GetRandomString(length, sb.ToString());
        }

        private static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length <= 0)
                throw new ArgumentException("Length must be larger than zero", nameof(length));
            if (length > int.MaxValue / 8)
                throw new ArgumentException("Length is too big", nameof(length));
            if (characterSet == null)
                throw new ArgumentNullException(nameof(characterSet));
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("Set of characters must not be empty", nameof(characterSet));

            var bytes = new byte[length * 8];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetNonZeroBytes(bytes);

            var sb = new StringBuilder(length);
            for (var i = 0; i < length; i++)
            {
                var index = BitConverter.ToUInt64(bytes, i * 8) % (ulong)characterArray.Length;
                sb.Append(characterArray[index]);
            }

            return sb.ToString();
        }
    }
}
