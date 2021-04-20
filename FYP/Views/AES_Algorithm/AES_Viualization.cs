using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;
using FYP.Model;

namespace FYP
{
    public partial class AES_Viualization : UserControl
    {
        int count = 0;
        public string[,] s_Box_Matrx;
        public string[,] s_Box_dum = new string[4,4];
        public string[,] shiftRow;
        public string[,] state = new string[4, 4];
        public string input_Plaintext;
        public string input_Key;
        public string character_plainext;
        public byte[] byte_plaintext;
        public byte[] byte_Key;
        public byte[] return_matrix_plaintext;
        public char[,] plain_Text_matrix = new char[4, 4];
        public char[,] key_Text_matrix = new char[4, 4];
        public string[,] plaintext_matrix_first;
        public string[,] key_matrix_first;
        public string[,] x = new string[4, 4];

        private AES aes = new AES();

        int[,] matrixE = new int[4, 4]{
        {2, 3, 1, 1} ,
        {1, 2, 3, 1} ,
        {1, 1, 2, 3} ,
        {3, 1, 1, 2} };

        public string A = "00", B = "01", C = "02", D = "03", E = "04", F = "05", G = "06", H = "07", I = "08", J = "09", K = "0A", L = "0B", M = "0C", N = "0D", O = "0E",
            P = "0F", Q = "10", R = "11", S = "12", T = "13", U = "14", V = "15", W = "16", X = "17", Y = "18", Z = "19";

        private void btnDemo_Click(object sender, EventArgs e)
        {
            validatePlaintext();
            Aes.message = messageText.Text;
            Aes.key = keyValue.Text;


            AES_VISUALIZATION_1 aES_Algorithm = new AES_VISUALIZATION_1(this);
            aES_Algorithm.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(aES_Algorithm);
            MainForm.Instance.panelContain.Controls["AES_VISUALIZATION_1"].BringToFront();
        }

        byte[] sboxVal = new byte[256]{
            //0     1    2      3     4    5     6     7      8    9     A      B    C     D     E     F
            0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76, //0
            0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0, //1
            0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15, //2
            0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75, //3
            0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84, //4
            0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf, //5
            0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8, //6
            0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2, //7
            0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73, //8
            0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb, //9
            0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79, //A
            0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08, //B
            0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a, //C
            0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e, //D
            0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf, //E
            0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16 };//F

        string[,] sring_sboxxVal = new string[16, 16]{
            //  0     1    2      3     4    5     6     7      8    9     A      B    C     D     E     F
            { "63", "7c", "77", "7b", "f2", "6b", "6f", "c5", "30", "01", "67", "2b", "fe", "d7", "ab", "76"}, //0
            { "ca", "82", "c9", "7d", "fa", "59", "47", "f0", "ad", "d4", "a2", "af", "9c", "a4", "72", "c0"}, //1
            { "b7", "fd", "93", "26", "36", "3f", "f7", "cc", "34", "a5", "e5", "f1", "71", "d8", "31", "15"}, //2
            { "04", "c7", "23", "c3", "18", "96", "05", "9a", "07", "12", "80", "e2", "eb", "27", "b2", "75"}, //3
            { "09", "83", "2c", "1a", "1b", "6e", "5a", "a0", "52", "3b", "d6", "b3", "29", "e3", "2f", "84"}, //4
            { "53", "d1", "00", "ed", "20", "fc", "b1", "5b", "6a", "cb", "be", "39", "4a", "4c", "58", "cf"}, //5
            { "d0", "ef", "aa", "fb", "43", "4d", "33", "85", "45", "f9", "02", "7f", "50", "3c", "9f", "a8"}, //6
            { "51", "a3", "40", "8f", "92", "9d", "38", "f5", "bc", "b6", "da", "21", "10", "ff", "f3", "d2"}, //7
            { "cd", "0c", "13", "ec", "5f", "97", "44", "17", "c4", "a7", "7e", "3d", "64", "5d", "19", "73"}, //8
            { "60", "81", "4f", "dc", "22", "2a", "90", "88", "46", "ee", "b8", "14", "de", "5e", "0b", "db"}, //9
            { "e0", "32", "3a", "0a", "49", "06", "24", "5c", "c2", "d3", "ac", "62", "91", "95", "e4", "79"}, //A
            { "e7", "c8", "37", "6d", "8d", "d5", "4e", "a9", "6c", "56", "f4", "ea", "65", "7a", "ae", "08"}, //B
            { "ba", "78", "25", "2e", "1c", "a6", "b4", "c6", "e8", "dd", "74", "1f", "4b", "bd", "8b", "8a"}, //C
            { "70", "3e", "b5", "66", "48", "03", "f6", "0e", "61", "35", "57", "b9", "86", "c1", "1d", "9e"}, //D
            { "e1", "f8", "98", "11", "69", "d9", "8e", "94", "9b", "1e", "87", "e9", "ce", "55", "28", "df"}, //E
            { "8c", "a1", "89", "0d", "bf", "e6", "42", "68", "41", "99", "2d", "0f", "b0", "54", "bb", "16"} };//F

        public AES_Viualization()
        {
            InitializeComponent();
            Aes = new AES();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SymmetricCategory uc_symmetricCategory = new SymmetricCategory();
            uc_symmetricCategory.Dock = DockStyle.Fill;


            MainForm.Instance.LoadView(uc_symmetricCategory);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void messageText_TextChanged(object sender, EventArgs e)
        {

        }
        public string[,] xor = new string[4,4];

        private  void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        public string[,] subMatrix = new string[4, 4];
        public string[,] shiftMatrix = new string[4, 4];
        public string[,] mixMatrix = new string[4, 4];
        public string[,] finalMatrix = new string[4, 4];

        public AES Aes { get => aes; set => aes = value; }

        private void EncryptAES_Click(object sender,EventArgs e)
        {

            cipherText.Text = "";
            if (messageText.Text.Length < 16 || messageText.Text.Length > 16 || keyValue.Text.Length < 16 || keyValue.Text.Length > 16)
            {
                try
                {
                    throw new ApplicationException("Please Enter Plaintext Correctly");
                }
                catch (ApplicationException a)
                {

                    MessageBox.Show("Please Enter 16 character for Key and Plaintext");

                }
            }
            else
            {


                Aes.message = messageText.Text;
                Aes.key = keyValue.Text;


                string[,] str1 = Aes.CalculatePreRound(Aes.message, aes.key);
                string[,] str2 = Aes.keyStateArray;

                for (int i = 0; i < 9; i++)
                {
                    finalMatrix = Aes.CalculateRoundValues(str1, str2);
                    str1 = finalMatrix;
                }
                finalMatrix = Aes.CalculateLastRound(str1, str2);
                /*
                Aes.xorMatrix = Aes.plaintext_XOR_key(Aes.plaintextStateArray, Aes.keyStateArray);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        xor[i, j] = Aes.xorMatrix[i, j];
                    }
                }
                Aes.subBytesMatrix = Aes.byteSubstitution(Aes.xorMatrix);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        subMatrix[i, j] = Aes.subBytesMatrix[i, j];
                    }
                }
                Aes.shiftRowsMatrix = Aes.byteShift(Aes.subBytesMatrix);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        shiftMatrix[i, j] = Aes.shiftRowsMatrix[i, j];
                    }
                }


                Aes.mixcolumnMatrix = Aes.MixColumn(Aes.shiftRowsMatrix);

                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        mixMatrix[i, j] = Aes.mixcolumnMatrix[i, j];
                    }
                }

                Aes.finalMatrix = Aes.plaintext_XOR_key(Aes.mixcolumnMatrix, Aes.keyStateArray);


                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        finalMatrix[i, j] = Aes.finalMatrix[i, j];
                    }
                }

        */

                // Display 2D Arrays on the Screen like a Matrix
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        cipherText.Text += String.Concat(finalMatrix[i, j], " ");
                    }
                    cipherText.Text += String.Concat("\n");
                }

            }
            
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {

        }

        private void AES_Viualization_Load(object sender, EventArgs e)
        {

            
        }
        //Converting into 4*4 Matrics
        public byte[] subWord(byte[] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                arr[i] = sboxVal[arr[i]];
            }
            return arr;
        }
        

        private void validatePlaintext()
        {
            input_Plaintext = messageText.Text.ToString();

            try
            {
                if (String.IsNullOrEmpty(input_Plaintext) || input_Plaintext.Length<16)
                {

                    throw new ApplicationException("Please Enter Plaintext");

                }
                else
                {
                    foreach (var c in input_Plaintext)
                    {
                        if (!Regex.IsMatch(c.ToString(), "[a-zA-Z]"))
                            input_Plaintext = input_Plaintext.Replace(c.ToString(), string.Empty);
                    }

                    input_Plaintext = input_Plaintext.ToUpper();
                }
            }
            catch (ApplicationException e)
            {

                MessageBox.Show(e.Message);

            }

        }
        private void ValidateKey()
        {
            input_Key = keyValue.Text.ToString();

            try
            {
                if (String.IsNullOrEmpty(input_Key) || input_Key.Length<16)
                {

                    throw new ApplicationException("Please Enter 16 character  key");

                }
                else
                {
                    foreach (var c in input_Key)
                    {
                        if (!Regex.IsMatch(c.ToString(), "[a-zA-Z]"))
                            input_Key = input_Key.Replace(c.ToString(), string.Empty);
                    }

                    input_Key = input_Key.ToUpper();
                }
            }
            catch (ApplicationException e)
            {

                MessageBox.Show(e.Message);

            }

        }
        //4*4 matric changing Hexa CODE
        public string[,] four_into_four(char[,] arr)
        {
              string[,] twoD_four_four = new string[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= 3; j++)
                {

                    if (arr[i, j] == 'A')
                    {
                        twoD_four_four[j, i] = A.ToString();
                    }
                    if (arr[i, j] == 'B')
                    {
                        twoD_four_four[j, i] = B.ToString();

                    }
                    if (arr[i, j] == 'C')
                    {
                        twoD_four_four[j, i] = C.ToString();

                    }
                    if (arr[i, j] == 'D')
                    {
                        twoD_four_four[j, i] = D.ToString();
                    }
                    if (arr[i, j] == 'E')
                    {
                        twoD_four_four[j, i] = E.ToString();
                    }
                    if (arr[i, j] == 'F')
                    {
                        twoD_four_four[j, i] = F.ToString();

                    }
                    if (arr[i, j] == 'G')
                    {
                        twoD_four_four[j, i] = G.ToString();

                    }
                    if (arr[i, j] == 'H')
                    {
                        twoD_four_four[j, i] = H.ToString();

                    }
                    if (arr[i, j] == 'I')
                    {
                        twoD_four_four[j, i] = I.ToString();

                    }
                    if (arr[i, j] == 'J')
                    {
                        twoD_four_four[j, i] = J.ToString();

                    }
                    if (arr[i, j] == 'K')
                    {
                        twoD_four_four[j, i] = K.ToString();

                    }
                    if (arr[i, j] == 'L')
                    {
                        twoD_four_four[j, i] = L.ToString();

                    }
                    if (arr[i, j] == 'M')
                    {
                        twoD_four_four[j, i] = M.ToString();

                    }
                    if (arr[i, j] == 'N')
                    {
                        twoD_four_four[j, i] = N.ToString();

                    }
                    if (arr[i, j] == 'O')
                    {
                        twoD_four_four[j, i] = O.ToString();

                    }
                    if (arr[i, j] == 'P')
                    {
                        twoD_four_four[j, i] = P.ToString();

                    }
                    if (arr[i, j] == 'Q')
                    {
                        twoD_four_four[j, i] = Q.ToString();

                    }
                    if (arr[i, j] == 'R')
                    {
                        twoD_four_four[j, i] = R.ToString();

                    }
                    if (arr[i, j] == 'S')
                    {
                        twoD_four_four[j, i] = S.ToString();

                    }
                    if (arr[i, j] == 'T')
                    {
                        twoD_four_four[j, i] = T.ToString();

                    }
                    if (arr[i, j] == 'U')
                    {
                        twoD_four_four[j, i] = U.ToString();

                    }
                    if (arr[i, j] == 'V')
                    {
                        twoD_four_four[j, i] = V.ToString();

                    }
                    if (arr[i, j] == 'W')
                    {
                        twoD_four_four[j, i] = W.ToString();

                    }
                    if (arr[i, j] == 'X')
                    {
                        twoD_four_four[j, i] = X.ToString();

                    }
                    if (arr[i, j] == 'Y')
                    {
                        twoD_four_four[j, i] = Y.ToString();

                    }
                    if (arr[i, j] == 'Z')
                    {
                        twoD_four_four[j, i] = Z.ToString();

                    }
                }
            }
            return twoD_four_four;
        }


        public string[,] exclusive_OR_key_and_state_array(string[,] plain_array, string[,] key_state_array)
        {
            string[,] xor = new string[4, 4];
            string a, b;
            int w, x, y, z;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a = plain_array[i, j];

                    b = key_state_array[i, j];

                    w = Convert.ToInt32(a[0]);//d
                    w = check(w.ToString());


                    x = Convert.ToInt32(a[1]);//4
                    x = check(x.ToString());


                    y = Convert.ToInt32(b[0]);//f
                    y = check(y.ToString());


                    z = Convert.ToInt32(b[1]);//f
                    z = check(z.ToString());


                    int dum = myXOR(w, y);
                    int dum2 = (x ^ z);

                    char cc = Alphabet_or_Number(dum);
                    char v = Alphabet_or_Number(dum2);

                    // Console.WriteLine(Convert.ToChar(dum2));
                    // Console.WriteLine("\n","\n");

                    string xx = string.Concat(cc, v);
                    xor[i, j] = xx;
                }
            }
            return xor;
        }
        // Returns XOR of x and y
        public int myXOR(int x, int y)
        {
            // Initialize result
            int res = 0;

            // Assuming 32-bit int 
            for (int i = 31; i >= 0; i--)
            {
                // Find current bits in x and y
                int b1 = ((x & (1 << i)) == 0) ?
                           0 : 1;
                int b2 = ((y & (1 << i)) == 0) ?
                           0 : 1;

                // If both are 1 then 0 else 
                // xor is same as OR
                int xoredBit = ((b1 & b2) != 0) ?
                                 0 : (b1 | b2);

                // Update result
                res <<= 1;
                res |= xoredBit;
            }
            return res;
        }

        public int check(string x)
        {
            int j = Convert.ToInt32(x);
            if (j >= 65)
            {
                if (!Regex.IsMatch(x.ToString(), "[a-zA-Z]"))
                {
                    j = j - 55;
                }
            }
            else
            {
                j = j - 48;
            }

            return j;
        }

        public char Alphabet_or_Number(int x)
        {
            char c = '0';
            if (x == 1)
            {
                c = '1';
            }
            if (x == 2)
            {
                c = '2';
            }
            if (x == 3)
            {
                c = '3';
            }
            if (x == 4)
            {
                c = '5';
            }
            if (x == 6)
            {
                c = '6';
            }
            if (x == 7)
            {
                c = '7';
            }
            if (x == 8)
            {
                c = '8';
            }
            if (x == 9)
            {
                c = '9';
            }
            if (x == 10)
            {
                c = 'A';
            }
            if (x == 11)
            {
                c = 'B';
            }
            if (x == 12)
            {
                c = 'C';
            }
            if (x == 13)
            {
                c = 'D';
            }
            if (x == 14)
            {
                c = 'E';
            }
            if (x == 15)
            {
                c = 'F';
            }

            return c;
        }


        //S_box function
        private string[,] byteSub(string[,] state_array)
        {
            int i, j;

            string a, b;
            int w, x, y, z;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    a = state_array[i, j];


                    w = Convert.ToInt32(a[0]);//d
                    w = check(w.ToString());


                    x = Convert.ToInt32(a[1]);//4
                    x = check(x.ToString());


                    state_array[i, j] = sring_sboxxVal[w, x];
                }
            }
            return state_array;
        }

        //2. ShiftRow
        public string[,] byteShift(string[,] state)
        {
            string tmp;
            tmp = state[1, 0];
            state[1, 0] = state[1, 1];
            state[1, 1] = state[1, 2];
            state[1, 2] = state[1, 3];
            state[1, 3] = tmp;

            tmp = state[2, 0];
            state[2, 0] = state[2, 2];
            state[2, 2] = tmp;
            tmp = state[2, 1];
            state[2, 1] = state[2, 3];
            state[2, 3] = tmp;

            tmp = state[3, 0];
            state[3, 0] = state[3, 3];
            state[3, 3] = state[3, 2];
            state[3, 2] = state[3, 1];
            state[3, 1] = tmp;

            return state;
        }

      

        public int ConvertTextToBits(char[] chararray, int[] savedarray)
        {
            int j = 0;
            for (int i = 0; i < chararray.Length; ++i)
            {
                int[] ba = ToBits(GetASCII(chararray[i]), 8);
                j = i * 8;
                AssignArray1ToArray2b(ba, savedarray, j);
            }

            return (j + 8);
        }
        private int GetASCII(char ch)
        {
            int n = ch;
            return n;
        }
        public static int[] ToBits(int decimalnumber, int numberofbits)
        {
            int[] bitarray = new int[numberofbits];
            int k = numberofbits - 1;
            char[] bd = Convert.ToString(decimalnumber, 2).ToCharArray();

            for (int i = bd.Length - 1; i >= 0; --i, --k)
            {
                if (bd[i] == '1')
                    bitarray[k] = 1;
                else
                    bitarray[k] = 0;
            }

            while (k >= 0)
            {
                bitarray[k] = 0;
                --k;
            }

            return bitarray;
        }

        public static int ToDecimal(int[] bitsarray)
        {
            string stringvalue = "";
            for (int i = 0; i < bitsarray.Length; i++)
            {
                stringvalue += bitsarray[i].ToString();
            }
            int DecimalValue = Convert.ToInt32(stringvalue, 2);

            return DecimalValue;
        }
        private void AssignArray1ToArray2b(int[] array1, int[] array2, int fromIndex)
        {
            int x, y;
            for (x = 0, y = fromIndex; x < array1.Length; ++x, ++y)
                array2[y] = array1[x];
        }

       
        //mix columns
        public string[,] MixCols(string[,] st,int [,] mE)
        {
            int i, j;
            string bin_9 ="000000000";
            string bin_8 = "00000000";
            int[] counter = new int[8];
            string a, b;
            string w, x, y, z;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    a = st[i, j];
                    w = checkForMatch(a[0]);
                    x = checkForMatch(a[1]);

                    string bin = String.Concat(w,x);
                    counter = new int[8];
                    for (int k = 7; k >= 0; k--)
                    {
                        if (bin[k] == '1') //   000000010
                        {
                            counter[7-k] = 7-k+1;
                            if (counter[k]==8)
                            {
                                for (int l = 0; l < counter.Length; l++)
                                {
                              //      bin_9[counter[7-l]] = '';
                                }
                            }
                        }
                    }

                    //                    state[i, j] = sring_sboxxVal[w, x];

                }



            }
            return state;

        }

        public string checkForMatch(char ch)
        {
            string w = "";
            switch (ch)
            {
                case '0': w = "0000"; break;
                case '1': w = "0001"; break;
                case '2': w = "0010"; break;
                case '3': w = "0011"; break;
                case '4': w = "0100"; break;
                case '5': w = "0101"; break;
                case '6': w = "0110"; break;
                case '7': w = "0111"; break;
                case '8': w = "1000"; break;
                case '9': w = "1001"; break;
                case 'A':
                case 'a': w = "1010"; break;
                case 'B':
                case 'b': w = "1011"; break;
                case 'C':
                case 'c': w = "1100"; break;
                case 'D':
                case 'd': w = "1101"; break;
                case 'E':
                case 'e': w = "1110"; break;
                case 'F':
                case 'f': w = "1111"; break;

            }

            return w;
        }
    }
}
