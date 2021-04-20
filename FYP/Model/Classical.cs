using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP.Model
{
    class Classical : Symmetric
    {
        private char type; // d = decryption and e =  encryption


        public void setType(char t)
        {
            this.type = t;
        }

        public char getType(char t)
        {
            return this.type;
        }

        public String AdditiveCaesarCipher(char t)
        {


            if (t == 'e')
            {
                char temp = ' ';
                char[] plaintext = (this.getPlaintext()).ToCharArray();
                int key = Convert.ToInt32(this.getSecretKey());

                for (int i = 0; i < plaintext.Length; i++)
                {

                    temp = (char)((((plaintext[i] - 97) + key) % 26) + 97);

                    plaintext[i] = (char)(temp - 32);

                }

                this.setCiphertext(String.Concat(plaintext));
                return String.Concat(plaintext);

            }
            else
            {
                char temp = ' ';
                char[] ciphertext = (this.getCiphertext()).ToCharArray();
                int key = Convert.ToInt32(this.getSecretKey());

                for (int i = 0; i < ciphertext.Length; i++)
                {

                    temp = (char)((((ciphertext[i] - 97) + key) % 26) + 97);

                    ciphertext[i] = (char)(temp - 32);

                }

                this.setPlaintext(String.Concat(ciphertext));
                return this.getPlaintext();

            }
        }

        public String MultiplicativeCaesarCipher(char t)
        {


            if (t == 'e')
            {
                char temp = ' ';
                char[] plaintext = (this.getPlaintext()).ToCharArray();
                int key = Convert.ToInt32(this.getSecretKey());
                if (key == 1 || key == 3 || key == 5 || key == 7 || key == 9 || key == 11 || key == 15 || key == 17 || key == 19 || key == 21 || key == 23 || key == 25)
                {

                    for (int i = 0; i < plaintext.Length; i++)
                    {

                        int x = (int)(plaintext[i] - 97) * key;
                        x = (x % 26) + 65;
                        plaintext[i] = (char)x;

                    }
                    string encode = new string(plaintext);
                    this.setCiphertext(String.Concat(plaintext));
                    return encode;
                }
                else
                {
                    MessageBox.Show("Please Check the Key ");
                    return null;
                }





            }
            else
            {
                char temp = ' ';
                char[] ciphertext = (this.getCiphertext()).ToCharArray();
                int key = Convert.ToInt32(this.getSecretKey());

                for (int i = 0; i < ciphertext.Length; i++)
                {

                    temp = (char)((((ciphertext[i] - 97) + key) % 26) + 97);

                    ciphertext[i] = (char)(temp - 32);

                }

                this.setPlaintext(String.Concat(ciphertext));
                return this.getPlaintext();

            }


        }


        public String VigenereCipher(char t)
        {


            if (t == 'e')
            {
                char temp = ' ';
                char[] plaintext = (this.getPlaintext()).ToCharArray();
                char[] key = this.getSecretKey().ToCharArray();
                int j = 0;
                for (int i = 0; i < plaintext.Length; i++)
                {

                    if (j >= key.Length)
                    {

                        j = 0;

                    }

                    temp = (char)((((plaintext[i] - 97) + (key[j] - 97)) % 26) + 97);
                    j++;

                    plaintext[i] = (char)(temp - 32);

                }

                this.setCiphertext(String.Concat(plaintext));
                return String.Concat(plaintext);

            }
            else
            {

                return this.getPlaintext();

            }
        }

        public String OneTimePadCipher(char t)
        {


            if (t == 'e')
            {
                char temp = ' ';
                int[] keyarray = new int[1000];
                char[] plaintext = (this.getPlaintext()).ToCharArray();
                char[] key = (this.getSecretKey()).ToCharArray();

                for (int i = 0; i < plaintext.Length; i++)
                {

                    int x = (int)(plaintext[i] - 65);
                    x = (int)(key[i] - 97) + x;
                    x = (x % 26) + 97;
                    plaintext[i] = (char)x;

                }

                string encode = new string(plaintext);



                this.setCiphertext(String.Concat(plaintext));
                return encode;

            }
            else
            {
                char temp = ' ';
                char[] ciphertext = (this.getCiphertext()).ToCharArray();
                int key = Convert.ToInt32(this.getSecretKey());

                for (int i = 0; i < ciphertext.Length; i++)
                {

                    temp = (char)((((ciphertext[i] - 97) + key) % 26) + 97);

                    ciphertext[i] = (char)(temp - 32);

                }

                this.setPlaintext(String.Concat(ciphertext));
                return this.getPlaintext();

            }


        }

    }
}
