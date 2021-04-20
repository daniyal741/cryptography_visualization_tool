using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP
{
    class SymmetricEncryptions
    {
        public String CaesarCipherEncryption(char[] plaintext, int key)
        {
            char temp = ' ';


            for (int i = 0; i < plaintext.Length; i++)
            {

                temp = (char)((((plaintext[i] - 97) + key) % 26) + 97);

                plaintext[i] = (char)(temp- 32);

            }

            return new string(plaintext);
        }
    }

   
}
