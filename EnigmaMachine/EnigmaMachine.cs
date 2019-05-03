using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    /// <summary>
    /// Emulate a WW2 Era Enigma Machine
    /// https://en.wikipedia.org/wiki/Enigma_machine
    /// </summary>
    public class EnigmaMachine
    {
        public static readonly string CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public override string ToString()
        {
            string output = string.Format("Enigma Machine:{0}\t{1}{0}", Environment.NewLine, PlugBoard);
            foreach(Rotor rotor in Rotors)
            {
                output += string.Format("\t{0}{1}", rotor, Environment.NewLine);
            }

            output += string.Format("\t{0}", Reflector);

            return output;
        }

        /// <summary>
        /// PlugBoard may be modified by the User.
        /// </summary>
        public PlugBoard PlugBoard;

        /// <summary>
        /// Rotors may be swapped or tinkered with by the User.
        /// </summary>
        public List<Rotor> Rotors;

        /// <summary>
        /// The Reflector is not accessible to the user.
        /// </summary>
        private Reflector Reflector;

        public EnigmaMachine(Rotor rotor1, Rotor rotor2, Rotor rotor3, Rotor rotor4 = null, Rotor rotor5 = null, Reflector reflector = null)
        {
            Rotors = new List<Rotor>() { rotor1, rotor2, rotor3 };
            if(rotor4 != null)
            {
                Rotors.Add(rotor4);
                if (rotor5 == null)
                    throw new EnigmaRulesException("Enigma Machines only had 3 or 5 rotors.");

                Rotors.Add(rotor5);
            }

            PlugBoard = new PlugBoard();
            Reflector = reflector == null ? Reflector.ETW : reflector;
        }

        /// <summary>
        /// Emulate a key press on the Enigma Machine
        /// </summary>
        /// <param name="ch"></param>
        /// <returns>Encrypted character</returns>
        public char Process(char ch)
        {
            if (!CHARACTERS.Contains(ch)) return ch;

            //Console.Write("{0} => ", ch);
            // first step runs through the plugboard
            ch = PlugBoard[ch];

            //Console.Write("{0} => ", ch);
            // go IN through each rotor
            for (int i = 0; i < Rotors.Count; i++)
            {
                ch = Rotors[i].In(ch);

                //Console.Write("{0} => ", ch);
            }

            // feed through the reflector.
            ch = Reflector.Reflect(ch);

            //Console.Write("{0} => ", ch);
            // go OUT through each rotor in reverse order
            for (int i = Rotors.Count -1; i >= 0; i--)
            {
                ch = Rotors[i].Out(ch);
                //Console.Write("{0} => ", ch);
            }

            // back out through the plugboard again
            ch = PlugBoard[ch];
            //Console.WriteLine("{0}", ch);

            for (int i = 0; i < Rotors.Count; i++)
            {
                if (!Rotors[i].Increment())
                    break;
            }

            return ch;
        }

        public string Process(string message)
        {
            message = message.ToUpperInvariant();
            string output = "";
            foreach(char ch in message)
            {
                output += Process(ch);
            }

            return output;
        }
    }
}
