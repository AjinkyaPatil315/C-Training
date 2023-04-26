using Microsoft.VisualBasic;

namespace Training_C_.Exercise
{
    public class Consonants
    {
        public int[] alphabetsInTotal = new int[26];
        public void findConsonants(string findConsonantsInString)
        {
            for (int i = 0; i < findConsonantsInString.Length; i++)
            {
                char c = findConsonantsInString[i];
                if (c >= 'b' && c <= 'z' && c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
                {
                    alphabetsInTotal[c - 'b']++;
                }
            }

            for (int i = 0; i < alphabetsInTotal.Length; i++)
            {
                char consonant = (char)('b' + i);
                if (findConsonantsInString.Contains(consonant.ToString()))
                {
                    Console.WriteLine(consonant + ": " + alphabetsInTotal[i]);
                }
            }
            Console.WriteLine("\n");

        }
    }
}
