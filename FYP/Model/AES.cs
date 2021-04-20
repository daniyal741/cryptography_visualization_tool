using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FYP.Model
{

    public class AES

    {
        public string A = "00", B = "01", C = "02", D = "03", E = "04", F = "05", G = "06", H = "07", I = "08", J = "09", K = "0A", L = "0B", M = "0C", N = "0D", O = "0E",
           P = "0F", Q = "10", R = "11", S = "12", T = "13", U = "14", V = "15", W = "16", X = "17", Y = "18", Z = "19";

        string[,] sboxValuesMatrix = new string[16, 16]{
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

        int[,] matrixE = new int[4, 4]{
        {2, 3, 1, 1} ,
        {1, 2, 3, 1} ,
        {1, 1, 2, 3} ,
        {3, 1, 1, 2} };

        public string message;
        public string key;

        private string messageBytes;
        private string messageChar;

        private string keyBytes;
        private string keyChar;

        public byte[,] plaintextStateMatrix;
        public char[,] plaintextMatrix;
        public string[,] xorMatrix;
        public string[,] subBytesMatrix;
        public string[,] shiftRowsMatrix;
        public string[,] mixcolumnMatrix;
        public string[,] finalMatrix;
        public string[,] plaintextStateArray;
        public string[,] keyStateArray;

        public AES()
        {

            plaintextStateArray = new string[4, 4];
            keyStateArray = new string[4, 4];
            xorMatrix = new string[4,4];
            subBytesMatrix = new string[4, 4];
            shiftRowsMatrix = new string[4, 4];
            mixcolumnMatrix = new string[4, 4];
            finalMatrix = new string[4, 4];

        }

        public string[,] CalculateRoundValues(string[,] state_array,string[,] key_array)
        {



            string[,] xor = new string[4,4];
            xorMatrix = plaintext_XOR_key(state_array, key_array);

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    xor[i, j] = xorMatrix[i, j];
                }
            }


            string[,] sub = new string[4, 4];
             subBytesMatrix   = byteSubstitution(xor);

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    sub[i, j] = subBytesMatrix[i, j];
                }
            }


            string[,] shift = new string[4, 4]; 
            shiftRowsMatrix =  byteShift(sub);

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    shift[i, j] = shiftRowsMatrix[i, j];
                }
            }

            string[,] mix = new string[4, 4];
            mixcolumnMatrix = MixColumn(shift);
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    mix[i, j] = mixcolumnMatrix[i, j];
                }
            }
            finalMatrix = plaintext_XOR_key(mix, keyStateArray);
            return finalMatrix;
        }
        public string[,] initializeMatrix(string[,] source, string[,] dest)
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    dest[i, j] = source[i, j];
                }
            }

            return dest;

        }
        public string[,] CalculateLastRound(string[,] state_array, string[,] key_array)
        {
            xorMatrix = plaintext_XOR_key(state_array, key_array);
            subBytesMatrix = byteSubstitution(xorMatrix);
            shiftRowsMatrix = byteShift(subBytesMatrix);
            finalMatrix = plaintext_XOR_key(shiftRowsMatrix, keyStateArray);
            return finalMatrix;
        }
        public string[,] CalculatePreRound(string state_array, string key_array)
        {
            this.plaintextStateArray = encodeMatrix(state_array);
            this.keyStateArray = encodeMatrix(key_array);
            this.finalMatrix = plaintext_XOR_key(plaintextStateArray, keyStateArray);
            return finalMatrix;
        }
        public byte[] StringToByte(string str)
        {
            var encoding = new ASCIIEncoding();
            return encoding.GetBytes(str);
        }

        public char[,] StringToChar(string str)
        {
            char[,] ch;
            ch = new char[4,4];
            int r1,r2,r3,r4; r1 = r2 = r3 = r4 =0;

            str = str.ToUpper();

            for (int i = 0; i < 16; i++)
            {
                if (i < 4 && r1 < 4)
                {
                    ch[0, r1] = str[i];
                    r1++;
                }

                if (i >= 4 && i < 8)
                {
                    ch[1, r2] = str[i];
                    r2++;
                }
                if (i >= 8 && i < 12)
                {
                    ch[2, r3] = str[i];
                    r3++;
                }
                if (i >= 12 && i < 16)
                {
                    ch[3, r4] = str[i];
                    r4++;
                }
            }
            

                return ch;
        }
       

        public string HashEncodeArray(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public byte[] HexDecodeArray(string hex)
        {
            var bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = byte.Parse(hex.Substring(i * 2, 2), NumberStyles.HexNumber);
            }
            return bytes;
        }

        // Using Predefined Hexa vs Character Table for creating new Matrix

        public string[,] encodeMatrix(string s)
        {

            char[,] ch = StringToChar(s);

            string[,] str = new string[4, 4];
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (ch[i, j] == 'A')
                    {
                        str[j, i] = A.ToString();
                    }
                    if (ch[i, j] == 'B')
                    {
                        str[j, i] = B.ToString();

                    }
                    if (ch[i, j] == 'C')
                    {
                        str[j, i] = C.ToString();

                    }
                    if (ch[i, j] == 'D')
                    {
                        str[j, i] = D.ToString();
                    }
                    if (ch[i, j] == 'E')
                    {
                        str[j, i] = E.ToString();
                    }
                    if (ch[i, j] == 'F')
                    {
                        str[j, i] = F.ToString();

                    }
                    if (ch[i, j] == 'G')
                    {
                        str[j, i] = G.ToString();

                    }
                    if (ch[i, j] == 'H')
                    {
                        str[j, i] = H.ToString();

                    }
                    if (ch[i, j] == 'I')
                    {
                        str[j, i] = I.ToString();

                    }
                    if (ch[i, j] == 'J')
                    {
                        str[j, i] = J.ToString();

                    }
                    if (ch[i, j] == 'K')
                    {
                        str[j, i] = K.ToString();

                    }
                    if (ch[i, j] == 'L')
                    {
                        str[j, i] = L.ToString();

                    }
                    if (ch[i, j] == 'M')
                    {
                        str[j, i] = M.ToString();

                    }
                    if (ch[i, j] == 'N')
                    {
                        str[j, i] = N.ToString();

                    }
                    if (ch[i, j] == 'O')
                    {
                        str[j, i] = O.ToString();

                    }
                    if (ch[i, j] == 'P')
                    {
                        str[j, i] = P.ToString();

                    }
                    if (ch[i, j] == 'Q')
                    {
                        str[j, i] = Q.ToString();

                    }
                    if (ch[i, j] == 'R')
                    {
                        str[j, i] = R.ToString();

                    }
                    if (ch[i, j] == 'S')
                    {
                        str[j, i] = S.ToString();

                    }
                    if (ch[i, j] == 'T')
                    {
                        str[j, i] = T.ToString();

                    }
                    if (ch[i, j] == 'U')
                    {
                        str[j, i] = U.ToString();

                    }
                    if (ch[i, j] == 'V')
                    {
                        str[j, i] = V.ToString();

                    }
                    if (ch[i, j] == 'W')
                    {
                        str[j, i] = W.ToString();

                    }
                    if (ch[i, j] == 'X')
                    {
                        str[j, i] = X.ToString();

                    }
                    if (ch[i, j] == 'Y')
                    {
                        str[j, i] = Y.ToString();

                    }
                    if (ch[i, j] == 'Z')
                    {
                        str[j, i] = Z.ToString();

                    }
                }
            }
            return str;
        }

        //mix columns
        public string[,] MixColumn(string[,] state)
        {
            int i, j;
            string[,] latestState = new string[4,4];
            string str = "";
            string ch1 = "000" ;
            string ch2 = "000" ;
            int[] bin1,binLen8, binLen9, bin3;
            bin1 = new int[8]{0,0,0,0,0,0,0,0 };
            binLen8 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            binLen9 = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0};
            bin3 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] xorValue1 = new int[8];
            int[] xorValue = new int[8];

            int count = 0;
            string a;
            int b;
            string w, x, y, z;

            //////////
            for (i = 0; i < 4; i++)
            {
                count = 0;

                for (j = 0; j < 4; j++)
                {
                    a = state[j, count];
                    w = get4bitBinaryString(a[0]);
                    x = get4bitBinaryString(a[1]);
                    str = String.Concat(w, x);

                    b = matrixE[i,j];

                    xorValue1 = goloCalculations(str,b);

                    if (j == 0)
                    {
                        xorValue = xorValue1;
                    }
                    if (j > 0)
                    {

                        for (int k = 0; k < xorValue.Length; k++)
                        {
                            xorValue[k] = xorValue[k] ^ xorValue1[k];   //xorValue
                        }

                    }
                    if (j == 3)
                    {
                        string value = getStringofBits(xorValue);


                        char c1 = getStringFrom4Bits(value.Substring(0, 4));
                        char c2 = getStringFrom4Bits(value.Substring(4, 4));

                        string res = "";
                        res = String.Concat(c1, c2);
                        latestState[i, count] = res;
                    }
                }

                //int value = Convert.ToInt32("1101", 2);
                

               

            }

            //////////
            for (i = 0; i < 4; i++)
            {
                count = 1;

                for (j = 0; j < 4; j++)
                {
                    a = state[j, count];
                    w = get4bitBinaryString(a[0]);
                    x = get4bitBinaryString(a[1]);
                    str = String.Concat(w, x);

                    b = matrixE[i, j];

                    xorValue1 = goloCalculations(str, b);

                    if (j == 0)
                    {
                        xorValue = xorValue1;
                    }
                    if (j > 0)
                    {

                        for (int k = 0; k < xorValue.Length; k++)
                        {
                            xorValue[k] = xorValue[k] ^ xorValue1[k];   //xorValue
                        }

                    }
                    if (j == 3)
                    {
                        string value = getStringofBits(xorValue);


                        char c1 = getStringFrom4Bits(value.Substring(0, 4));
                        char c2 = getStringFrom4Bits(value.Substring(4, 4));

                        string res = "";
                        res = String.Concat(c1, c2);
                        latestState[i, count] = res;
                    }
                }


                //int value = Convert.ToInt32("1101", 2);

            }

            //////////
            for (i = 0; i < 4; i++)
            {
                count = 2;

                for (j = 0; j < 4; j++)
                {
                    a = state[j, count];
                    w = get4bitBinaryString(a[0]);
                    x = get4bitBinaryString(a[1]);
                    str = String.Concat(w, x);

                    b = matrixE[i, j];

                    xorValue1 = goloCalculations(str, b);

                    if (j == 0)
                    {
                        xorValue = xorValue1;
                    }
                    if (j > 0)
                    {

                        for (int k = 0; k < xorValue.Length; k++)
                        {
                            xorValue[k] = xorValue[k] ^ xorValue1[k];   //xorValue
                        }

                    }
                    if (j == 3)
                    {
                        string value = getStringofBits(xorValue);


                        char c1 = getStringFrom4Bits(value.Substring(0, 4));
                        char c2 = getStringFrom4Bits(value.Substring(4, 4));

                        string res = "";
                        res = String.Concat(c1, c2);
                        latestState[i, count] = res;
                    }
                }

                //int value = Convert.ToInt32("1101", 2);




            }

            //////////
            for (i = 0; i < 4; i++)
            {
                count = 3;

                for (j = 0; j < 4; j++)
                {
                    a = state[j, count];
                    w = get4bitBinaryString(a[0]);
                    x = get4bitBinaryString(a[1]);
                    str = String.Concat(w, x);

                    b = matrixE[i, j];

                    xorValue1 = goloCalculations(str, b);

                    if (j == 0)
                    {
                        xorValue = xorValue1;
                    }
                    if (j > 0)
                    {

                        for (int k = 0; k < xorValue.Length; k++)
                        {
                            xorValue[k] = xorValue[k] ^ xorValue1[k];   //xorValue
                        }

                    }
                    if (j == 3)
                    {
                        string value = getStringofBits(xorValue);


                        char c1 = getStringFrom4Bits(value.Substring(0, 4));
                        char c2 = getStringFrom4Bits(value.Substring(4, 4));

                        string res = "";
                        res = String.Concat(c1, c2);
                        latestState[i, count] = res;
                    }
                }

                //int value = Convert.ToInt32("1101", 2);




            }


            return latestState;

        }

        public string getStringofBits(int[] bitsarray)
        {
            string stringvalue = "";
            for (int i = 0; i < bitsarray.Length; i++)
            {
                stringvalue += bitsarray[i].ToString();
            }
      //      int DecimalValue = Convert.ToInt32(stringvalue, 2);

            return stringvalue;
        }
        public int[] goloCalculations(string str , int b)
        {


            int[] bin1, binLen8, binLen9, bin3;
            bin1 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            binLen8 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            binLen9 = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            bin3 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] xorConstant = new int[9] { 1, 0, 0, 0, 1, 1, 0, 1, 1 };

            bool bitFlag = false;

            int[] counter1 = new int[8];
            int[] counter2 = new int[8];



           
            if (b == 2)
            {
                for (int k = 7; k >= 0; k--)
                {
                    if (str[k] == '1') //     Right to Left 
                    {
                        int bitPlace = (7 - k);  //   Left to Right Bit Place 
                        counter1[7 - k] = bitPlace + 1;  // Adding +1 to move it to the Left by 1
                        if (bitPlace + 1 == 8)
                        {
                            bitFlag = true;
                        }


                    }
                }

                for (int k = 7; k >= 0; k--)
                {
                    if (bitFlag == true)
                    {

                        if (counter1[k] > 0)
                        {

                            bin1[7 - k] = 1;
                            binLen9[8 - k - 1] = 1;
                        }
                        else
                        {
                            bin1[k] = 0;
                            binLen9[8 - k] = 0;
                        }
                    }
                    else
                    {
                        if (counter1[k] > 0)
                        {

                            bin1[7 - k] = 1;
                            binLen8[7 - k - 1] = 1;
                        }
                        else
                        {
                            bin1[7 - k] = 0;
                            binLen8[7 - k] = 0;
                        }
                    }


                }

                if (bitFlag == true)
                {
                    for (int k = 0; k < xorConstant.Length; k++)
                    {
                        int res = binLen9[k] ^ xorConstant[k];
                        if (k == 0)
                        {
                            //skip
                        }
                        else
                        {

                            bin3[k - 1] = res;   //xor

                        }
                    }


                }

                else
                {

                    bin3 = binLen8;

                }

                return bin3;

            }

            if (b == 3)
            {

                for (int k = 7; k >= 0; k--)
                {
                    if (str[k] == '1') //     Right to Left 
                    {
                        int bitPlace = (7 - k);  //   Left to Right Bit Place 
                        counter2[7 - k] = bitPlace; // Simple bit position ,No addition 
                        counter1[7 - k] = bitPlace + 1; // Adding +1 to move it to the Left by 1

                        if (bitPlace + 1 == 8)
                        {
                            bitFlag = true;
                        }


                    }
                    else
                    {
                        counter1[7 - k] = -1;
                        counter2[7 - k] = -1;

                    }
                }

                /*       int[] counterCon = new int[counter2.Length + counter1.Length];
                       var byteIndex = counter2.Length * sizeof(int);
                       Buffer.BlockCopy(counter2, 0, counterCon, 0, byteIndex);
                       Buffer.BlockCopy(counter1, 0, counterCon, byteIndex, counter1.Length * sizeof(int));

                       //  counterCon = counter2.Concat(counter1).ToArray();

                       int[] newconcat = new int[16];
                */



                for (int m = 7; m >= 0; m--)
                {
                    int temp = counter2[m];

                    for (int n = 7; n >= 0; n--)
                    {
                        if (temp == counter1[n])
                        {
                            counter2[m] = -1;
                            counter1[n] = -1;
                        }
                    }
                }


                for (int k = 7; k >= 0; k--)
                {
                    if (bitFlag == true)
                    {

                        if (counter2[k] >= 0)
                        {

                            //bin1[7 - k] = 1;
                            binLen9[8 - counter2[k]] = 1;
                        }

                        if (counter1[k] >= 1)
                        {
                            binLen9[8 - counter1[k]] = 1;

                        }

                        if (counter2[k] < 0)
                        {
                            counter2[k] = 0;

                        }
                        if (counter1[k] < 1)
                        {
                            counter1[k] = 0;
                        }
                    }
                    else
                    {
                        if (counter2[k] >= 0)
                        {

                            //bin1[7 - k] = 1;
                            binLen8[7 - counter2[k]] = 1;
                        }

                        if (counter1[k] >= 1)
                        {
                            binLen9[7 - counter1[k]] = 1;

                        }
                        if (counter2[k] < 0 || counter1[k] < 1)
                        {
                            counter1[k] = 0;
                            counter2[k] = 0;

                        }
                    }


                }

                if (bitFlag == true)
                {
                    for (int k = 0; k < xorConstant.Length; k++)
                    {
                        int res = binLen9[k] ^ xorConstant[k];
                        if (k == 0)
                        {
                            //skip
                        }
                        else
                        {

                            bin3[k - 1] = res;   //xor

                        }
                    }

                }
                else
                {

                    bin3 = binLen8;

                }

                return bin3;

            }
            else
            {


                for (int k = 7; k >= 0; k--)
                {
                    if (str[k] == '1') //     Right to Left 
                    {
                        int bitPlace = (7 - k);  //   Left to Right Bit Place 
                        counter1[7 - k] = bitPlace;  
                        if (bitPlace + 1 == 8)
                        {
                            bitFlag = true;
                        }


                    }
                }

                for (int k = 7; k >= 0; k--)
                {
                    
                        if (counter1[k] > 0)
                        {

                          //  bin1[7 - k] = 1;
                            binLen8[7- k] = 1;
                        }
                        else
                        {
                           // bin1[k] = 0;
                            binLen8[7 - k] = 0;
                        }
                

                }

                bin3 = binLen8;

                return bin3;
            }






        }
        public string get4bitBinaryString(char ch)
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

        public char getStringFrom4Bits(string st)
        {
            char w = '0';
            if (st == "0000")
            {
                w = '0';
            }
            if (st == "00001")
            {
                w = '1';
            }
            if (st == "0010")
            {
                w = '2';
            }
            if (st == "0011")
            {
                w = '3';
            }
            if (st == "0100")
            {
                w = '4';
            }
            if (st == "0101")
            {
                w = '5';
            }
            if (st == "0110")
            {
                w = '6';
            }
            if (st == "0111")
            {
                w = '7';
            }
            if (st == "1000")
            {
                w = '8';
            }
            if (st == "1001")
            {
                w = '9';
            }
            if (st == "1010")
            {
                w = 'A';
            }
            if (st == "1011")
            {
                w = 'B';
            }
            if (st == "1100")
            {
                w = 'C';
            }
            if (st == "1101")
            {
                w = 'D';
            }
            if (st == "1110")
            {
                w = 'E';
            }
            if (st == "1111")
            {
                w = 'F';
            }

            return w;
        }

        public string[,] sta;

        //S_box function
        public string[,] byteSubstitution(string[,] state_array)
        {

            sta = state_array; 

            int i, j;
            string a, b;
            int w, x, y, z;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    a = sta[i, j];


                    w = Convert.ToInt32(a[0]);//d
                    w = check(w.ToString());


                    x = Convert.ToInt32(a[1]);//4
                    x = check(x.ToString());


                    sta[i, j] = sboxValuesMatrix[w, x];
                }
            }
            return sta;
        }

        string tmp = "";

        //2. ShiftRow
        public string[,] byteShift(string[,] state)
        {
         

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

        public string[,] plaintext_XOR_key(string[,] plain_state_array, string[,] key_state_array)
        {
            string[,] xor = new string[4, 4];
            string a, b;
            int w, x, y, z;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //byte t = byte.Parse(plain_state_array[i,j].Substring(0 , 2), NumberStyles.HexNumber); ;
                    a = plain_state_array[i, j];

                    b = key_state_array[i, j];

                    w = Convert.ToInt32(a[0]);//d
                    w = check(w.ToString());


                    x = Convert.ToInt32(a[1]);//4
                    x = check(x.ToString());


                    y = Convert.ToInt32(b[0]);//f
                    y = check(y.ToString());


                    z = Convert.ToInt32(b[1]);//f
                    z = check(z.ToString());


                    int dum = (w ^ y);
                    int dum2 = (x ^ z);

                    char c1 = Alphabet_or_Number(dum);
                    char c2 = Alphabet_or_Number(dum2);

                    // Console.WriteLine(Convert.ToChar(dum2));
                    // Console.WriteLine("\n","\n");

                    string xx = string.Concat(c1, c2);
                    xor[i, j] = xx;
                }

            }
            return xor;
        }
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
    }
}
