using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    /// <summary>
    /// Represents a Rotor in the Enigma Machine.
    /// The exceptional flaw in the Enigma Machine was that no
    /// character could ever encipher to itself.
    /// </summary>
    public partial class Rotor
    {
        protected string CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        protected Dictionary<int, int> Mapping;
        protected Dictionary<int, int> ReverseMapping;

        protected int Offset;

        public Rotor(string mapping)
        {
            if (mapping.Length != CHARACTERS.Length)
                throw new EnigmaRulesException("Invalid mapping for Rotor.");
            foreach(char ch in CHARACTERS)
            {
                if (mapping.Where(mc => mc == ch).Count() != 1)
                    throw new EnigmaRulesException("Invalid mapping for Rotor.");
            }

            for(int i = 0; i < 26; i++)
            {
                int j = CHARACTERS.IndexOf(mapping[i]);
                Mapping.Add(i, j);
                ReverseMapping.Add(j, i);
            }
        }

        public Rotor(int offset = 0)
        {
            Mapping = new Dictionary<int, int>();
            ReverseMapping = new Dictionary<int, int>();
            for(int i = 0; i < 26; i++)
            {
                Mapping.Add(i, (i + 1) % 26);
                ReverseMapping.Add((i + 1) % 26, i);
            }

            Offset = offset % 26;
        }

        /// <summary>
        /// Get the Encyphered character from the input pass through this rotor.
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public char In(char ch)
        {
            int i = (CHARACTERS.IndexOf(ch) + Offset) % 26;
            return CHARACTERS[Mapping[i]];
        }

        /// <summary>
        /// Get the Encyphered character from the input pass through this rotor.
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public char Out(char ch)
        {
            int j = (CHARACTERS.IndexOf(ch) + Offset) % 26;
            return CHARACTERS[ReverseMapping[j]];
        }

        /// <summary>
        /// Increment this Rotor.
        /// </summary>
        /// <returns>True if this rotor rolled over</returns>
        public bool Increment()
        {
            if(++Offset >= 26)
            {
                Offset = 0;
                return true;
            }

            return false;
        }
    }
}
