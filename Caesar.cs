using System;
using System.Linq;

namespace codecademy
{
    public static class Caesar
    {
        private static char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m',
        'n','o','p','q','r','s','t','u','v','w','x','y','z'};
        private static char[] special = {'?','!','.',',',':',';',' ',
        '1','2','3','4','5','6','7','8','9','0','%','"','\'','(',')'};
        
        public static string Cipher(this string msg)
        {
            char[] msgArray = msg.ToLower().ToCharArray();
            char[] cipherArray = new char[msgArray.Length];
            for (int i=0; i < msgArray.Length; i++)
            {
                if (special.Contains(msgArray[i])){cipherArray[i] = msgArray[i]; continue;}

                int newLetterIndex = (Array.IndexOf(alphabet, msgArray[i]) + 3) % alphabet.Length;
                cipherArray[i] = alphabet[newLetterIndex];
            }

            return String.Join("", cipherArray);
        }

        public static string Decipher(this string msg)
        {
            char[] msgArray = msg.ToLower().ToCharArray();
            char[] decipherArray = new char[msgArray.Length];
            for (int i=0; i < msgArray.Length; i++)
            {
                if (special.Contains(msgArray[i])){decipherArray[i] = msgArray[i]; continue;}

                int newLetterIndex = (Array.IndexOf(alphabet, msgArray[i]) - 3);
                if (newLetterIndex < 0)
                {
                    newLetterIndex += alphabet.Length;
                }
                decipherArray[i] = alphabet[newLetterIndex];
            }

            return String.Join("", decipherArray);
        }
    }
}