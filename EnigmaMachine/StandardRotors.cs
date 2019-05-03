using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    public partial class Rotor
    {
        #region Comercial Enigma
        public static Rotor IC =>
            new Rotor("DMTWSILRUYQNKFEJCAZBPGXOHV");

        public static Rotor IIC =>
            new Rotor("HQZGPJTMOBLNCIFDYAWVEUSRKX");

        public static Rotor IIIC =>
            new Rotor("UQNTLSZFMREHDPXKIBVYGJCWOA");
        #endregion
        #region German Railway (Rocket)
        public static Rotor ROCKET_I =>
            new Rotor("JGDQOXUSCAMIFRVTPNEWKBLZYH");

        public static Rotor ROCKET_II =>
            new Rotor("NTZPSFBOKMWRCJDIVLAEYUXHGQ");

        public static Rotor ROCKET_III =>
            new Rotor("JVIUBHTCDYAKEQZPOSGXNRMWFL");

        public static Rotor ROCKET_UKW =>
            new Rotor("QYHOGNECVPUZTFDJAXWMKISRBL");

        public static Rotor ROCKET_ETW =>
            new Rotor("QWERTZUIOASDFGHJKPYXCVBNML");
        #endregion

        #region WWII German Military
        public static Rotor I =>
            new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ");

        public static Rotor II =>
            new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE");

        public static Rotor III =>
            new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO");

        public static Rotor IV =>
            new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB");

        public static Rotor V =>
            new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK");

        public static Rotor VI =>
            new Rotor("JPGVOUMFYQBENHZRDKASXLICTW");

        public static Rotor VII =>
            new Rotor("NZJHGRCXMYSWBOUFAIVLPEKQDT");

        public static Rotor VIII =>
            new Rotor("FKQHTLXOCBJSPDZRAMEWNIUYGV");

        #endregion

    }

}
