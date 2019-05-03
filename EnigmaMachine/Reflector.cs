using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{

    /// <summary>
    /// A reflector is (logically speaking) a rotor that does not rotate.
    /// </summary>
    public class Reflector
    {
        private Dictionary<char, char> Mapping;
        protected Dictionary<char, char> ReverseMapping;
        protected static string CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public Reflector(string mapping)
        {
            Mapping = new Dictionary<char, char>();
            ReverseMapping = new Dictionary<char, char>();
            if (mapping.Length != CHARACTERS.Length)
                throw new EnigmaRulesException("Invalid mapping for Rotor.");
            foreach (char ch in CHARACTERS)
            {
                if (mapping.Where(mc => mc == ch).Count() != 1)
                    throw new EnigmaRulesException("Invalid mapping for Rotor.");
            }

            for (int i = 0; i < 26; i++)
            {
                int j = CHARACTERS.IndexOf(mapping[i]);
                Mapping.Add(CHARACTERS[i], CHARACTERS[j]);
                ReverseMapping.Add(CHARACTERS[j], CHARACTERS[i]);
            }
        }
    }
}
