using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FYP.Model
{
    class NonKeyBased : Hashing
    {
        //Constants =  (2 power 32) * abs(sin(i))  where 'i' is in Radians

        public readonly uint[] T = new uint[64]
            {   0xd76aa478,0xe8c7b756,0x242070db,0xc1bdceee,
                0xf57c0faf,0x4787c62a,0xa8304613,0xfd469501,
                0x698098d8,0x8b44f7af,0xffff5bb1,0x895cd7be,
                0x6b901122,0xfd987193,0xa679438e,0x49b40821,
                0xf61e2562,0xc040b340,0x265e5a51,0xe9b6c7aa,
                0xd62f105d,0x2441453,0xd8a1e681,0xe7d3fbc8,
                0x21e1cde6,0xc33707d6,0xf4d50d87,0x455a14ed,
                0xa9e3e905,0xfcefa3f8,0x676f02d9,0x8d2a4c8a,
                0xfffa3942,0x8771f681,0x6d9d6122,0xfde5380c,
                0xa4beea44,0x4bdecfa9,0xf6bb4b60,0xbebfbc70,
                0x289b7ec6,0xeaa127fa,0xd4ef3085,0x4881d05,
                0xd9d4d039,0xe6db99e5,0x1fa27cf8,0xc4ac5665,
                0xf4292244,0x432aff97,0xab9423a7,0xfc93a039,
                0x655b59c3,0x8f0ccc92,0xffeff47d,0x85845dd1,
                0x6fa87e4f,0xfe2ce6e0,0xa3014314,0x4e0811a1,
                0xf7537e82,0xbd3af235,0x2ad7d2bb,0xeb86d391};

        //Number of Blocks
        private int nBlocks;

        //CurrentBlock Counter
        private int counter;

        ///	X = 512 bits chunks as 16 x 32 bit word
        private uint[] X = new uint[16];


        /// the Message Bytes of the Input String
        private byte[] msgByteInput;


        //N * 2 * 64 = 128-N
        public string[,] OutputRounds;

        //N * 16 * 32 = 512-N
        public string[,] InputBlocks;

        //N * 2 * 64 = 128-N
        public string[,] ChainingVariables;

        public string[,] Value_A;
        public string[,] Value_B;
        public string[,] Value_C;
        public string[,] Value_D;

        public string[,] Value_plus1;
        public string[,] Value_plus2;
        public string[,] Value_plus3;
        public string[,] Value_plus4;
        public string[,] Value_shift;


        int round;



        public string MD5()
        {
            return CalculateMD5Value().ToString();

        }

        public Digest CalculateMD5Value()
        {
            msgByteInput = this.getTotalBytes();
            uint N;         //N is the size of msg as  word (32 bit) 
            Digest dg = new Digest();
            N = (uint)(msgByteInput.Length * 8) / 512;       //no of 512-bit blocks
            nBlocks = (int)N;
            counter = 0;

            InputBlocks = new string[nBlocks, 16];
            ChainingVariables = new string[nBlocks + 1, 4];
            OutputRounds = new string[nBlocks, 4 * nBlocks];

            Value_A = new string[nBlocks * 4, 16];
            Value_B = new string[nBlocks * 4, 16];
            Value_C = new string[nBlocks * 4, 16];
            Value_D = new string[nBlocks * 4, 16];


            Value_plus1 = new string[nBlocks * 4, 16];
            Value_plus2 = new string[nBlocks * 4, 16];
            Value_plus3 = new string[nBlocks * 4, 16];
            Value_plus4 = new string[nBlocks * 4, 16];
            Value_shift = new string[nBlocks * 4, 16];


            ChainingVariables[0, 0] = MD5Helper.ReverseByte(dg.A).ToString("X8").ToLower();
            ChainingVariables[0, 1] = MD5Helper.ReverseByte(dg.B).ToString("X8").ToLower();
            ChainingVariables[0, 2] = MD5Helper.ReverseByte(dg.C).ToString("X8").ToLower();
            ChainingVariables[0, 3] = MD5Helper.ReverseByte(dg.D).ToString("X8").ToLower();





            for (uint i = 0; i < N; i++)
            {
                CopyBlock(msgByteInput, i);
                for (int j = 0; j < 16; j++)
                {
                    InputBlocks[i, j] = X[j].ToString("X8").ToLower();

                }
                PerformFFormation(ref dg.A, ref dg.B, ref dg.C, ref dg.D);

                if (i < nBlocks)
                {
                    ChainingVariables[i + 1, 0] = MD5Helper.ReverseByte(dg.A).ToString("X8").ToLower();
                    ChainingVariables[i + 1, 1] = MD5Helper.ReverseByte(dg.B).ToString("X8").ToLower();
                    ChainingVariables[i + 1, 2] = MD5Helper.ReverseByte(dg.C).ToString("X8").ToLower();
                    ChainingVariables[i + 1, 3] = MD5Helper.ReverseByte(dg.D).ToString("X8").ToLower();
                }
                counter++;
            }


            char[] tempCharArray = new Char[msgByteInput.Length];

            for (int i = 0; i < msgByteInput.Length; i++)
                tempCharArray[i] = (char)msgByteInput[i];

            return dg;
        }



        public byte[] getTotalBytes()
        {

            string message = this.getPlaintext();
            /// Getting the Message String in a Array of Bytes
            byte[] msgByte = new Byte[message.Length];
            for (int i = 0; i < message.Length; i++)
                msgByte[i] = (byte)message[i];

            ulong sizeMsg = (ulong)(msgByte.Length * 8);  // Represents the Size of the Bits in the Input Message/String.
            uint pad;                                    //Represents the Number of Padding bits.
            uint sizeMsgTotal;                          // Represents the Total Message Length bits .
            byte[] totalBytes;


            // Finding the Padding Bits
            pad = (uint)(512 - (sizeMsg + 64));
            pad = (pad + 512) % 512;
            if (pad == 0)
            {
                pad = 512;
            }

            sizeMsgTotal = (uint)((sizeMsg / 8) + (pad / 8) + 8);
            totalBytes = new Byte[sizeMsgTotal];

            for (int i = 0; i < msgByte.Length; i++)
                totalBytes[i] = (byte)msgByte[i];

            totalBytes[msgByte.Length] |= 0x80;      // It will Pad '1' bit


            for (int i = 8; i > 0; i--)
              totalBytes[sizeMsgTotal - i] = (byte)(sizeMsg >> ((8 - i) * 8) & 0x00000000000000ff);


            return totalBytes;
        }

        public void CopyBlock(byte[] bMsg, uint block)
        {

            block = block << 6;
            for (uint j = 0; j < 61; j += 4)
            {
                X[j >> 2] = (((uint)bMsg[block + (j + 3)]) << 24) |
                        (((uint)bMsg[block + (j + 2)]) << 16) |
                        (((uint)bMsg[block + (j + 1)]) << 8) |
                        (((uint)bMsg[block + (j)]));

            }
        }

        public void PerformFFormation(ref uint A, ref uint B, ref uint C, ref uint D)
        {

            uint a, b, c, d;

            a = A;
            b = B;
            c = C;
            d = D;

            // Round 1 :

            Round1(ref A, ref B, ref C, ref D);

            string str = "";
            str = "A = 0x" + MD5Helper.ReverseByte(A).ToString("X8").ToLower() + "\n" +
                  "B = 0x" + MD5Helper.ReverseByte(B).ToString("X8").ToLower() + "\n" +
                  "C = 0x" + MD5Helper.ReverseByte(C).ToString("X8").ToLower() + "\n" +
                  "D = 0x" + MD5Helper.ReverseByte(D).ToString("X8").ToLower() + "\n";

            OutputRounds[counter, 0 + (counter * 4)] = str;

            // ROUND 2 :

            Round2(ref A, ref B, ref C, ref D);

            str = "";
            str = "A = 0x" + MD5Helper.ReverseByte(A).ToString("X8").ToLower() + "\n" +
                  "B = 0x" + MD5Helper.ReverseByte(B).ToString("X8").ToLower() + "\n" +
                  "C = 0x" + MD5Helper.ReverseByte(C).ToString("X8").ToLower() + "\n" +
                  "D = 0x" + MD5Helper.ReverseByte(D).ToString("X8").ToLower() + "\n";

            OutputRounds[counter, 1 + (counter * 4)] = str;

            // ROUND 3 :

            Round3(ref A, ref B, ref C, ref D);

            str = "";
            str = "A = 0x" + MD5Helper.ReverseByte(A).ToString("X8").ToLower() + "\n" +
                  "B = 0x" + MD5Helper.ReverseByte(B).ToString("X8").ToLower() + "\n" +
                  "C = 0x" + MD5Helper.ReverseByte(C).ToString("X8").ToLower() + "\n" +
                  "D = 0x" + MD5Helper.ReverseByte(D).ToString("X8").ToLower() + "\n";

            OutputRounds[counter, 2 + (counter * 4)] = str;

            // ROUND 4  :

            Round4(ref A, ref B, ref C, ref D);

            str = "";
            str = "A = 0x" + MD5Helper.ReverseByte(A).ToString("X8").ToLower() + "\n" +
                  "B = 0x" + MD5Helper.ReverseByte(B).ToString("X8").ToLower() + "\n" +
                  "C = 0x" + MD5Helper.ReverseByte(C).ToString("X8").ToLower() + "\n" +
                  "D = 0x" + MD5Helper.ReverseByte(D).ToString("X8").ToLower() + "\n";

            OutputRounds[counter, 3 + (counter * 4)] = str;

            //Adding previous values in the new ones

            A = (A + a);
            B = (B + b);
            C = (C + c);
            D = (D + d);



        }

        public void Round1(ref uint A, ref uint B, ref uint C, ref uint D)
        {
            round = 1;
            int iteration = 0;

            FF(ref A, B, C, D, 0, 7, 1);
            CopyValuesABCD(ref D, A, B, C, round, iteration);
            iteration++;

            FF(ref D, A, B, C, 1, 12, 2);
            CopyValuesABCD(ref C, D, A, B, round, iteration);
            iteration++;

            FF(ref C, D, A, B, 2, 17, 3);
            CopyValuesABCD(ref B, C, D, A, round, iteration);
            iteration++;

            FF(ref B, C, D, A, 3, 22, 4);
            CopyValuesABCD(ref A, B, C, D, round, iteration);
            iteration++;


            FF(ref A, B, C, D, 4, 7, 5);
            CopyValuesABCD(ref D, A, B, C, round, iteration);
            iteration++;

            FF(ref D, A, B, C, 5, 12, 6);
            CopyValuesABCD(ref C, D, A, B, round, iteration);
            iteration++;

            FF(ref C, D, A, B, 6, 17, 7);
            CopyValuesABCD(ref B, C, D, A, round, iteration);
            iteration++;

            FF(ref B, C, D, A, 7, 22, 8);
            CopyValuesABCD(ref A, B, C, D, round, iteration);
            iteration++;

            FF(ref A, B, C, D, 8, 7, 9);
            CopyValuesABCD(ref D, A, B, C, round, iteration);
            iteration++;

            FF(ref D, A, B, C, 9, 12, 10);
            CopyValuesABCD(ref C, D, A, B, round, iteration);
            iteration++;

            FF(ref C, D, A, B, 10, 17, 11);
            CopyValuesABCD(ref B, C, D, A, round, iteration);
            iteration++;

            FF(ref B, C, D, A, 11, 22, 12);
            CopyValuesABCD(ref A, B, C, D, round, iteration);
            iteration++;

            FF(ref A, B, C, D, 12, 7, 13);
            CopyValuesABCD(ref D, A, B, C, round, iteration);
            iteration++;

            FF(ref D, A, B, C, 13, 12, 14);
            CopyValuesABCD(ref C, D, A, B, round, iteration);
            iteration++;

            FF(ref C, D, A, B, 14, 17, 15);
            CopyValuesABCD(ref B, C, D, A, round, iteration);
            iteration++;

            FF(ref B, C, D, A, 15, 22, 16);
            CopyValuesABCD(ref A, B, C, D, round, iteration);
            iteration = 0;
        }

        public void CopyValuesABCD(ref uint A, uint B, uint C, uint D, int r, int iteration)
        {
            Value_A[(counter + r - 1), iteration] = MD5Helper.ReverseByte(A).ToString("X8").ToLower();
            Value_B[(counter + r - 1), iteration] = MD5Helper.ReverseByte(B).ToString("X8").ToLower();
            Value_C[(counter + r - 1), iteration] = MD5Helper.ReverseByte(C).ToString("X8").ToLower();
            Value_D[(counter + r - 1), iteration] = MD5Helper.ReverseByte(D).ToString("X8").ToLower();

        }

        public void Round2(ref uint A, ref uint B, ref uint C, ref uint D)
        {

            GG(ref A, B, C, D, 1, 5, 17);
            GG(ref D, A, B, C, 6, 9, 18);
            GG(ref C, D, A, B, 11, 14, 19);
            GG(ref B, C, D, A, 0, 20, 20);
            GG(ref A, B, C, D, 5, 5, 21);
            GG(ref D, A, B, C, 10, 9, 22);
            GG(ref C, D, A, B, 15, 14, 23);
            GG(ref B, C, D, A, 4, 20, 24);
            GG(ref A, B, C, D, 9, 5, 25);
            GG(ref D, A, B, C, 14, 9, 26);
            GG(ref C, D, A, B, 3, 14, 27);
            GG(ref B, C, D, A, 8, 20, 28);
            GG(ref A, B, C, D, 13, 5, 29);
            GG(ref D, A, B, C, 2, 9, 30);
            GG(ref C, D, A, B, 7, 14, 31);
            GG(ref B, C, D, A, 12, 20, 32);

        }

        public void Round3(ref uint A, ref uint B, ref uint C, ref uint D)
        {
            HH(ref A, B, C, D, 5, 4, 33);
            HH(ref D, A, B, C, 8, 11, 34);
            HH(ref C, D, A, B, 11, 16, 35);
            HH(ref B, C, D, A, 14, 23, 36);
            HH(ref A, B, C, D, 1, 4, 37);
            HH(ref D, A, B, C, 4, 11, 38);
            HH(ref C, D, A, B, 7, 16, 39);
            HH(ref B, C, D, A, 10, 23, 40);
            HH(ref A, B, C, D, 13, 4, 41);
            HH(ref D, A, B, C, 0, 11, 42);
            HH(ref C, D, A, B, 3, 16, 43);
            HH(ref B, C, D, A, 6, 23, 44);
            HH(ref A, B, C, D, 9, 4, 45);
            HH(ref D, A, B, C, 12, 11, 46);
            HH(ref C, D, A, B, 15, 16, 47);
            HH(ref B, C, D, A, 2, 23, 48);

        }

        public void Round4(ref uint A, ref uint B, ref uint C, ref uint D)
        {
            II(ref A, B, C, D, 0, 6, 49);
            II(ref D, A, B, C, 7, 10, 50);
            II(ref C, D, A, B, 14, 15, 51);
            II(ref B, C, D, A, 5, 21, 52);
            II(ref A, B, C, D, 12, 6, 53);
            II(ref D, A, B, C, 3, 10, 54);
            II(ref C, D, A, B, 10, 15, 55);
            II(ref B, C, D, A, 1, 21, 56);
            II(ref A, B, C, D, 8, 6, 57);
            II(ref D, A, B, C, 15, 10, 58);
            II(ref C, D, A, B, 6, 15, 59);
            II(ref B, C, D, A, 13, 21, 60);
            II(ref A, B, C, D, 4, 6, 61);
            II(ref D, A, B, C, 11, 10, 62);
            II(ref C, D, A, B, 2, 15, 63);
            II(ref B, C, D, A, 9, 21, 64);

        }

        protected void FF(ref uint a, uint b, uint c, uint d, uint k, ushort s, uint i)
        {

            a = b + MD5Helper.RotateLeft((a + ((b & c) | (~(b) & d)) + X[k] + T[i - 1]), s);

        }


        protected void GG(ref uint a, uint b, uint c, uint d, uint k, ushort s, uint i)
        {
            a = b + MD5Helper.RotateLeft((a + ((b & d) | (c & ~d)) + X[k] + T[i - 1]), s);
        }


        protected void HH(ref uint a, uint b, uint c, uint d, uint k, ushort s, uint i)
        {
            a = b + MD5Helper.RotateLeft((a + (b ^ c ^ d) + X[k] + T[i - 1]), s);
        }


        protected void II(ref uint a, uint b, uint c, uint d, uint k, ushort s, uint i)
        {
            a = b + MD5Helper.RotateLeft((a + (c ^ (b | ~d)) + X[k] + T[i - 1]), s);
        }


        public enum MD5InitializerConstant : uint
        {
            A = 0x01234567,
            B = 0x89abcdef,
            C = 0xfedcba98,
            D = 0x76543210


            // A = 0x67452301,
            // B = 0xEFCDAB89,
            // C = 0x98BADCFE,
            // D = 0X10325476

        }

        /// Represent digest with ABCD
        sealed public class Digest
        {
            public uint A;
            public uint B;
            public uint C;
            public uint D;

            public Digest()
            {
                A = (uint)MD5Helper.ReverseByte((uint)MD5InitializerConstant.A);
                B = (uint)MD5Helper.ReverseByte((uint)MD5InitializerConstant.B);
                C = (uint)MD5Helper.ReverseByte((uint)MD5InitializerConstant.C);
                D = (uint)MD5Helper.ReverseByte((uint)MD5InitializerConstant.D);
            }
            public override string ToString()
            {
                string st;
                st = MD5Helper.ReverseByte(A).ToString("X8").ToLower() +
                     MD5Helper.ReverseByte(B).ToString("X8").ToLower() +
                     MD5Helper.ReverseByte(C).ToString("X8").ToLower() +
                     MD5Helper.ReverseByte(D).ToString("X8").ToLower();
                return st;

            }

        }


        /// helper class providing suporting function
        sealed public class MD5Helper
        {

            private MD5Helper() { }

            /// Left rotates the input word
            /// 'uiNumber' = a value to be rotated</param>
            /// 'shift' = no of bits to be rotated</param>
            public static uint RotateLeft(uint uiNumber, ushort shift)
            {
                return ((uiNumber >> 32 - shift) | (uiNumber << shift));
            }


            /// perform a ByteReversal on a number
            public static uint ReverseByte(uint uiNumber)
            {
                return (((uiNumber & 0x000000ff) << 24) |
                            (uiNumber >> 24) |
                        ((uiNumber & 0x00ff0000) >> 8) |
                        ((uiNumber & 0x0000ff00) << 8));
            }
        }


    }

}
