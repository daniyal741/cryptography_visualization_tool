﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP.Model
{
    class Sha512 : Hashing
    {

        // initial values of variables (a,b,c,d,e,f,g,h)

        public ulong[] iv = new ulong[8] 
            { 0x6a09e667f3bcc908, 0xbb67ae8584caa73b, 0x3c6ef372fe94f82b, 0xa54ff53a5f1d36f1,
              0x510e527fade682d1, 0x9b05688c2b3e6c1f, 0x1f83d9abfb41bd6b, 0x5be0cd19137e2179};
        //Constants[1-80] for each Round 
        public readonly ulong[] k = new ulong[80]
       
            { 0x428a2f98d728ae22, 0x7137449123ef65cd, 0xb5c0fbcfec4d3b2f, 0xe9b5dba58189dbbc, 0x3956c25bf348b538,
              0x59f111f1b605d019, 0x923f82a4af194f9b, 0xab1c5ed5da6d8118, 0xd807aa98a3030242, 0x12835b0145706fbe,
              0x243185be4ee4b28c, 0x550c7dc3d5ffb4e2, 0x72be5d74f27b896f, 0x80deb1fe3b1696b1, 0x9bdc06a725c71235,
              0xc19bf174cf692694, 0xe49b69c19ef14ad2, 0xefbe4786384f25e3, 0x0fc19dc68b8cd5b5, 0x240ca1cc77ac9c65,
              0x2de92c6f592b0275, 0x4a7484aa6ea6e483, 0x5cb0a9dcbd41fbd4, 0x76f988da831153b5, 0x983e5152ee66dfab,
              0xa831c66d2db43210, 0xb00327c898fb213f, 0xbf597fc7beef0ee4, 0xc6e00bf33da88fc2, 0xd5a79147930aa725,
              0x06ca6351e003826f, 0x142929670a0e6e70, 0x27b70a8546d22ffc, 0x2e1b21385c26c926, 0x4d2c6dfc5ac42aed,
              0x53380d139d95b3df, 0x650a73548baf63de, 0x766a0abb3c77b2a8, 0x81c2c92e47edaee6, 0x92722c851482353b,
              0xa2bfe8a14cf10364, 0xa81a664bbc423001, 0xc24b8b70d0f89791, 0xc76c51a30654be30, 0xd192e819d6ef5218,
              0xd69906245565a910, 0xf40e35855771202a, 0x106aa07032bbd1b8, 0x19a4c116b8d2d0c8, 0x1e376c085141ab53,
              0x2748774cdf8eeb99, 0x34b0bcb5e19b48a8, 0x391c0cb3c5c95a63, 0x4ed8aa4ae3418acb, 0x5b9cca4f7763e373,
              0x682e6ff3d6b2b8a3, 0x748f82ee5defb2fc, 0x78a5636f43172f60, 0x84c87814a1f0ab72, 0x8cc702081a6439ec,
              0x90befffa23631e28, 0xa4506cebde82bde9, 0xbef9a3f7b2c67915, 0xc67178f2e372532b, 0xca273eceea26619c,
              0xd186b8c721c0c207, 0xeada7dd6cde0eb1e, 0xf57d4f7fee6ed178, 0x06f067aa72176fba, 0x0a637dc5a2c898a6,
              0x113f9804bef90dae, 0x1b710b35131c471b, 0x28db77f523047d84, 0x32caab7b40c72493, 0x3c9ebe0a15c9bebc,
              0x431d67c49c100d4c, 0x4cc5d4becb3e42b6, 0x597f299cfc657e2a, 0x5fcb6fab3ad6faec, 0x6c44198c4a475817 };


        private ulong[] w = new ulong[80];
        public ulong s0;
        public ulong s1;
        public ulong S0;
        public ulong S1;

        public byte[] msgByteInput;
        public byte[] copyMsgBytes = new byte[128];
        public int nBlocks;
        public int currentBlock = 0;
        public int currentRound = 0;

        public string[,] messageWords;


        public string[,] value_A;
        public string[,] value_B;
        public string[,] value_C;
        public string[,] value_D;
        public string[,] value_E;
        public string[,] value_F;
        public string[,] value_G;
        public string[,] value_H;

        public string[,] value_A_RROT;
        public string[,] value_E_RROT;


        public string[,] value_Maj;
        public string[,] value_Con;


        public string[,] value_Mix1;
        public string[,] value_Mix2;



        /*
                begin with the original message of length L bits
                append a single '1' bit
                append K '0' bits, where K is the minimum number >= 0 such that L + 1 + K + 128 is a multiple of 1024
                append L as a 64-bit big-endian integer, making the total post-processed length a multiple of 1024 bits

                Process the message in successive 1024-bit chunks:
                break message into 1024-bit chunks
                for each chunk
                    create a 80-entry message schedule array w[0..80] of 64-bit words
                    (The initial values in w[0..80] don't matter, so many implementations zero them here)
                    copy chunk into first 16 words w[0..15] of the message schedule array

                    Extend the first 16 words into the remaining 64 words w[16..80] of the message schedule array:
                    for i from 16 to 80
                        s0 := (w[i-15] rightrotate  7) xor (w[i-15] rightrotate 18) xor (w[i-15] rightshift  3)
                        s1 := (w[i- 2] rightrotate 17) xor (w[i- 2] rightrotate 19) xor (w[i- 2] rightshift 10)
                        w[i] := w[i-16] + s0 + w[i-7] + s1

                    Initialize working variables to current hash value:
                    a := h0
                    b := h1
                    c := h2
                    d := h3
                    e := h4
                    f := h5
                    g := h6
                    h := h7

                    Compression function main loop:
                    for i from 0 to 80
                        S1 := (e rightrotate 6) xor (e rightrotate 11) xor (e rightrotate 25)
                        ch := (e and f) xor ((not e) and g)
                        temp1 := h + S1 + ch + k[i] + w[i]
                        S0 := (a rightrotate 2) xor (a rightrotate 13) xor (a rightrotate 22)
                        maj := (a and b) xor (a and c) xor (b and c)
                        temp2 := S0 + maj
 
                        h := g
                        g := f
                        f := e
                        e := d + temp1
                        d := c
                        c := b
                        b := a
                        a := temp1 + temp2

                    Add the compressed chunk to the current hash value:
                    h0 := h0 + a
                    h1 := h1 + b
                    h2 := h2 + c
                    h3 := h3 + d
                    h4 := h4 + e
                    h5 := h5 + f
                    h6 := h6 + g
                    h7 := h7 + h

                Produce the final hash value (big-endian):
                digest := hash := h0 append h1 append h2 append h3 append h4 append h5 append h6 append h7
            
            
            BUT ...............
            
            SHA-512 Sum & Sigma:

            S0 := (a rightrotate 28) xor (a rightrotate 34) xor (a rightrotate 39)
            S1 := (e rightrotate 14) xor (e rightrotate 18) xor (e rightrotate 41)

            s0 := (w[i-15] rightrotate 1) xor (w[i-15] rightrotate 8) xor (w[i-15] rightshift 7)
            s1 := (w[i-2] rightrotate 19) xor (w[i-2] rightrotate 61) xor (w[i-2] rightshift 6)
       */

        public byte[] getTotalBytes(string message)
        {

            /// Getting the Message String in a Array of Bytes
            byte[] msgByte = new Byte[message.Length];
            for (int i = 0; i < message.Length; i++)
                msgByte[i] = (byte)message[i];

            ulong sizeMsg = (ulong)(msgByte.Length * 8);  // Represents the Size of the Bits in the Input Message/String.
            uint pad;                                    //Represents the Number of Padding bits.
            uint sizeMsgTotal;                          // Represents the Total Message Length bits .
            byte[] totalBytes;


            // Finding the Padding Bits
            pad = (uint)(1024 - (sizeMsg + 128));
            pad = (pad + 1024) % 1024;
            if (pad == 0)
            {
                pad = 1024;
            }

            sizeMsgTotal = (uint)((sizeMsg / 8) + (pad / 8) + (128/8));
            totalBytes = new Byte[sizeMsgTotal];

            for (int i = 0; i < msgByte.Length; i++)
                totalBytes[i] = (byte)msgByte[i];

            totalBytes[msgByte.Length] |= 0x80;      // It will Pad '1' bit


            for (int i = 16; i > 0; i--)
                totalBytes[sizeMsgTotal - i] = (byte)(sizeMsg >> ((16-i) * 8) & 0x00000000000000ff);

            nBlocks = (int)Math.Round((decimal)(totalBytes.Length * 8 / 1024));

            value_A = new string[nBlocks , 80 + 1];
            value_B = new string[nBlocks , 80 + 1];
            value_C = new string[nBlocks , 80 + 1];
            value_D = new string[nBlocks , 80 + 1];
            value_E = new string[nBlocks , 80 + 1];
            value_F = new string[nBlocks , 80 + 1];
            value_G = new string[nBlocks , 80 + 1];
            value_H = new string[nBlocks , 80 + 1];

            messageWords = new string[nBlocks,80];

            value_A_RROT = new string[nBlocks,80];
            value_E_RROT = new string[nBlocks, 80];


            value_Maj = new string[nBlocks, 80];
            value_Con = new string[nBlocks, 80];


            value_Mix1 = new string[nBlocks, 80];
            value_Mix2 = new string[nBlocks, 80];

            return totalBytes;
        }
        public string Encrypt(string msg)
        {
            this.setPlaintext(msg);
            msgByteInput =  this.getTotalBytes(this.getPlaintext());
            string str = "";

            Digest dg = new Digest();

            currentBlock = 0;

            for (int i = 0; i < nBlocks; i++)
            {

                copyBlock(msgByteInput,copyMsgBytes,i);
                initializeWords(copyMsgBytes);
               
                compressionFunction(ref dg.A, ref dg.B, ref dg.C, ref dg.D, ref dg.E, ref dg.F, ref dg.G, ref dg.H);
                
                currentBlock++;
            }

            str = dg.ToString();

            return str;
        }

        public void copyBlock(byte[] source, byte[] dest,int t)
        {
            for (int i = 0; i < dest.Length; i++)
            {
                dest[i] = source[(t * 8) + i];
            }
        }
        public ulong CopyBlock(ulong word,byte[] bMsg, int i)
        {
            

         word = ((ulong)(bMsg)[(i)] << 56) | ((ulong)(bMsg)[(i) + 1] << 48) |     
              ((ulong)(bMsg)[(i) + 2] << 40) | ((ulong)(bMsg)[(i) + 3] << 32) | 
              ((ulong)(bMsg)[(i) + 4] << 24) | ((ulong)(bMsg)[(i) + 5] << 16) | 
              ((ulong)(bMsg)[(i) + 6] << 8) | ((ulong)(bMsg)[(i) + 7]);

            return word;
        }
        public void initializeWords(byte[] msgByte)
        {


            for (int i = 0; i < 16; i++)
            {
                w[i] = CopyBlock(w[i], msgByte, i << 3);
                messageWords[currentBlock, i] = w[i].ToString("x8"); ;

            }


            for (int i = 16; i < 80; i++)
            {


              //  s0 = (w[i - 15] >> 1) ^ (w[i - 15] >> 8) ^ (w[i - 15] >> 7);
                s0 = SHAHelper.RotateRight(w[i - 15], 1) ^ SHAHelper.RotateRight(w[i - 15], 8) ^ SHAHelper.RotateRight(w[i - 15], 7);

                //  s1 = (w[i - 2] >> 19) ^ (w[i - 2] >> 61) ^ (w[i - 2] >> 6);
                s1 = SHAHelper.RotateRight(w[i - 2],19) ^ SHAHelper.RotateRight(w[i - 2],61) ^ SHAHelper.RotateRight(w[i - 2],6);

                w[i] = w[i - 16] + s0 + w[i - 7] + s1;

                messageWords[currentBlock, i] = w[i].ToString("x8"); ;


            }



        }

        public void compressionFunction(ref ulong A, ref ulong B, ref ulong C, ref ulong D, ref ulong E, ref ulong F, ref ulong G, ref ulong H)
        {
            currentRound = 0;
            //Compression function main loop:


            ulong a = A;
            ulong b = B;
            ulong c = C;
            ulong d = D;
            ulong e = E;
            ulong f = F;
            ulong g = G;
            ulong h = H;


            ulong mix2;
            ulong mix1;
            ulong ch;
            ulong maj;

            for (int i = 0; i < 80; i++)
            {

             // S1 = (e >> 14) ^ (e >> 18) ^ (e >> 41);
                S1 = SHAHelper.RotateRight(e, 14) ^ SHAHelper.RotateRight(e, 18) ^ SHAHelper.RotateRight(e, 41);

                ch = (e & f) ^ ((~e) & g);


                mix2 = h + S1 + ch + k[i] + w[i];

              //  S0 = (a >> 28) ^ (a >> 34) ^ (a >> 39);
                S0 = SHAHelper.RotateRight(a, 28) ^ SHAHelper.RotateRight(a, 34) ^ SHAHelper.RotateRight(a, 39);

                string str = S0.ToString("x8");

                maj = (a & b) ^ (a & c) ^ (b & c);

                mix1 = S0 + maj;

                copyAllValues(maj,S0,mix1,ch,S1,mix2);

                h = g;
                g = f;
                f = e;
                e = d + mix2;      // Y
                d = c;
                c = b;
                b = a;
                a = mix2 + mix1;  // X

                copyValuesAtoH(a, b, c, d, e, f, g, h);

                currentRound++;


            }


            //  Add the compressed chunk to the current hash value:
            A = A + a;
            B = B + b;
            C = C + c;
            D = D + d;
            E = E + e;
            F = F + f;
            G = G + g;
            H = H + h;

            copyValuesAtoH(A, B, C, D, E, F, G, H);

            // Produce the final hash value(big - endian): 
          
            
          

        }

        public void copyValuesAtoH(ulong A, ulong B, ulong C, ulong D, ulong E, ulong F, ulong G, ulong H)
        {
            value_A[(currentBlock), currentRound] = SHAHelper.ReverseByte(A).ToString("X8").ToLower();
            value_B[(currentBlock), currentRound] = SHAHelper.ReverseByte(B).ToString("X8").ToLower();
            value_C[(currentBlock), currentRound] = SHAHelper.ReverseByte(C).ToString("X8").ToLower();
            value_D[(currentBlock), currentRound] = SHAHelper.ReverseByte(D).ToString("X8").ToLower();
            value_E[(currentBlock), currentRound] = SHAHelper.ReverseByte(E).ToString("X8").ToLower();
            value_F[(currentBlock), currentRound] = SHAHelper.ReverseByte(F).ToString("X8").ToLower();
            value_G[(currentBlock), currentRound] = SHAHelper.ReverseByte(G).ToString("X8").ToLower();
            value_H[(currentBlock), currentRound] = SHAHelper.ReverseByte(H).ToString("X8").ToLower();

        }

        public void copyAllValues(ulong majority, ulong Rot_A, ulong mixer1, ulong conditional, ulong Rot_E, ulong mixer2)
        {
            value_Maj[(currentBlock), currentRound] = SHAHelper.ReverseByte(majority).ToString("X8").ToLower();
            value_A_RROT[(currentBlock), currentRound] = SHAHelper.ReverseByte(Rot_A).ToString("X8").ToLower();
            value_Mix1[(currentBlock), currentRound] = SHAHelper.ReverseByte(mixer1).ToString("X8").ToLower();
            value_Con[(currentBlock), currentRound] = SHAHelper.ReverseByte(conditional).ToString("X8").ToLower();
            value_E_RROT[(currentBlock), currentRound] = SHAHelper.ReverseByte(Rot_E).ToString("X8").ToLower();
            value_Mix2[(currentBlock), currentRound] = SHAHelper.ReverseByte(mixer2).ToString("X8").ToLower();
  

        }

        public enum MD5InitializerConstant : ulong
        {
            A = 0x6a09e667f3bcc908,
            B = 0xbb67ae8584caa73b,
            C = 0x3c6ef372fe94f82b,
            D = 0xa54ff53a5f1d36f1,
            E = 0x510e527fade682d1,
            F = 0x9b05688c2b3e6c1f,
            G = 0x1f83d9abfb41bd6b,
            H = 0x5be0cd19137e2179



        }

        /// Represent digest with ABCD
        sealed public class Digest
        {
            public ulong A;
            public ulong B;
            public ulong C;
            public ulong D;
            public ulong E;
            public ulong F;
            public ulong G;
            public ulong H;

            public Digest()
            {
                A = (ulong)SHAHelper.ReverseByte((ulong)MD5InitializerConstant.A);
                B = (ulong)SHAHelper.ReverseByte((ulong)MD5InitializerConstant.B);
                C = (ulong)SHAHelper.ReverseByte((ulong)MD5InitializerConstant.C);
                D = (ulong)SHAHelper.ReverseByte((ulong)MD5InitializerConstant.D);
                E = (ulong)SHAHelper.ReverseByte((ulong)MD5InitializerConstant.E);
                F = (ulong)SHAHelper.ReverseByte((ulong)MD5InitializerConstant.F);
                G = (ulong)SHAHelper.ReverseByte((ulong)MD5InitializerConstant.G);
                H = (ulong)SHAHelper.ReverseByte((ulong)MD5InitializerConstant.H);
            }
            public override string ToString()
            {
                string st;
                st = SHAHelper.ReverseByte(A).ToString("X16").ToLower() +
                     SHAHelper.ReverseByte(B).ToString("X16").ToLower() +
                     SHAHelper.ReverseByte(C).ToString("X16").ToLower() +
                     SHAHelper.ReverseByte(D).ToString("X16").ToLower() +
                     SHAHelper.ReverseByte(E).ToString("X16").ToLower() +
                     SHAHelper.ReverseByte(F).ToString("X16").ToLower() +
                     SHAHelper.ReverseByte(G).ToString("X16").ToLower() +
                     SHAHelper.ReverseByte(H).ToString("X16").ToLower();
                return st;

            }

        }


        /// helper class providing suporting function
        sealed public class SHAHelper
        {

            private SHAHelper() { }

            /// Left rotates the input word
            /// 'uiNumber' = a value to be rotated</param>
            /// 'shift' = no of bits to be rotated</param>
            public static ulong RotateRight(ulong uiNumber, ushort shift)
            {
               
                return ((uiNumber >>  shift) | (uiNumber << (64-shift)));

            }


            /// perform a ByteReversal on a number
            public static ulong ReverseByte(ulong uiNumber)
            {
               

             return (uiNumber & 0x00000000000000FF) << 56 | (uiNumber & 0x000000000000FF00) << 40 |
                     (uiNumber & 0x0000000000FF0000) << 24 | (uiNumber & 0x00000000FF000000) << 8 |
                     (uiNumber & 0x000000FF00000000) >> 8 | (uiNumber & 0x0000FF0000000000) >> 24 |
                     (uiNumber & 0x00FF000000000000) >> 40 | (uiNumber & 0xFF00000000000000) >> 56;
            }
        }


    
}
}
