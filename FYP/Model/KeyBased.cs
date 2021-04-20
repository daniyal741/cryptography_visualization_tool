using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP.Model
{
    class KeyBased : Hashing
    {
        private Sha512 sha512;
        public byte[] result1;
        public byte[] result2;
        public byte[] result3;


        public byte[] message;
        public byte[] key;
        public int blockSize = 1024; // Due to Block Size of Sha-512 
        public byte ipad = 0x36;
        public byte opad = 0x5c;
        public string append1;
        public string append2;

        public string hash1;
        public string hash2;



        public byte[] ikeypad;
        public byte[] okeypad;


        public KeyBased()
        {
            sha512 = new Sha512();
            message = new byte[blockSize / 8];
            key = new byte[blockSize/8];
            ikeypad = new byte[blockSize / 8];
            okeypad = new byte[blockSize / 8];


        }
        public string HMAC(string msg, string k)
        {
            checkKey(k);
            message = sha512.getTotalBytes(msg);
            iKeyPad();
            oKeyPad();
            result1 = CombineTwoByteArrays(ikeypad,message);
            append1 = HashEncode(result1);

            result2 = HexDecode(sha512.Encrypt(HashEncode(result1)));
            hash1 = HashEncode(result2);

            result3 = CombineTwoByteArrays(okeypad, result2);
            append2 = HashEncode(result3);

            result3 = HexDecode(sha512.Encrypt(HashEncode(result3)));
            hash2 = HashEncode(result3);

            return hash2;


        }
        public void iKeyPad()
        {
            for (int i = 0; i < key.Length; i++)
            {
                ikeypad[i] =  (byte)(ipad ^ key[i]);
            }
        }
        public void oKeyPad()
        {
            for (int i = 0; i < key.Length; i++)
            {
                okeypad[i] = (byte)(opad ^ key[i]);
            }
        }
        public void checkKey(string k)
        {
            int zeroes = 0;

           
            if (k.Length > (blockSize / 8))
            {
                do {

                    k = HashEncode(HexDecode(sha512.Encrypt(k)));

                }
                while (k.Length>blockSize/8);
                key = StringEncode(k);
            }
            if (k.Length < (blockSize / 8))
            {
                zeroes = blockSize - (k.Length * 8);
                key = ByteArrayLeftPad(StringEncode(k), 0x00, blockSize / 8);

            }

        }

       


        public  byte[] CombineTwoByteArrays(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        public  byte[] ByteArrayLeftPad(byte[] input, byte padValue, int len)
        {
            var temp = Enumerable.Repeat(padValue, len).ToArray(); ;
            var startAt = temp.Length - input.Length;
            Array.Copy(input, 0, temp, startAt, input.Length);
            return temp;
        }
        public  byte[] ByteArrayRightPad(byte[] input, byte padValue, int len)
        {
            var temp = Enumerable.Repeat(padValue, len).ToArray();
            for (var i = 0; i < input.Length; i++)
                temp[i] = input[i];
            return temp;

        }
        public  byte[] StringEncode(string text)
        {
            var encoding = new ASCIIEncoding();
            return encoding.GetBytes(text);
        }


        public  string HashEncode(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public  byte[] HexDecode(string hex)
        {
            var bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = byte.Parse(hex.Substring(i * 2, 2), NumberStyles.HexNumber);
            }
            return bytes;
        }

     

       


    }
}
