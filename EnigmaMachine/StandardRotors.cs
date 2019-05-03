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
        /// <summary>
        /// Triggers turnover at Q
        /// </summary>
        public static Rotor I =>
            new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q");

        /// <summary>
        /// Triggers turnover at E
        /// </summary>
        public static Rotor II =>
            new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", "E");

        /// <summary>
        /// Triggers turnover at V
        /// </summary>
        public static Rotor III =>
            new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", "V");

        /// <summary>
        /// Triggers turnover at J
        /// </summary>
        public static Rotor IV =>
            new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", "J");

        /// <summary>
        /// Triggers turnover at Z
        /// </summary>
        public static Rotor V =>
            new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK");
        
        /// <summary>
        /// Triggers turnover at Z and M
        /// (Actually weakend the encryption!)
        /// </summary>
        public static Rotor VI =>
            new Rotor("JPGVOUMFYQBENHZRDKASXLICTW", "ZM");

        /// <summary>
        /// Triggers turnover at Z and M
        /// (Actually weakend the encryption!)
        /// </summary>
        public static Rotor VII =>
            new Rotor("NZJHGRCXMYSWBOUFAIVLPEKQDT", "ZM");

        /// <summary>
        /// Triggers turnover at Z and M
        /// (Actually weakend the encryption!)
        /// </summary>
        public static Rotor VIII =>
            new Rotor("FKQHTLXOCBJSPDZRAMEWNIUYGV", "ZM");

        #endregion

    }

}
