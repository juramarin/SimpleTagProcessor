using System;
using System.Text;

namespace SimpleTagProcessor.Common
{
    public static class HexBinaryConverter
    {
        public static string HexToBinary(string hex)
        {
            int length = hex.Length;

            StringBuilder binary = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int integer = Convert.ToInt16(hex.Substring(i, 1), 16);
                binary.Append(Convert.ToString(integer, 2).PadLeft(4, '0'));
            }

            return binary.ToString();
        }

        public static string BinaryToHex(string binary)
        {
            int length = binary.Length;
            if (length % 16 != 0)
            {
                int toPad = 16 - length % 16;
                binary = binary.PadRight(length + toPad, '0');
                length = binary.Length;
            }

            StringBuilder hex = new StringBuilder();
            for (int i = 0; i < length; i += 4)
            {
                int integer = Convert.ToInt16(binary.Substring(i, 4), 2);
                hex.Append(Convert.ToString(integer, 16));
            }

            return hex.ToString();
        }
    }
}