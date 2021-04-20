using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP.Model
{
    class Advance : Symmetric
    {


        //Initial Permutation Table  
        private int[] ip = new int[] { 58,50,42,34,26,18,10,2,60,52,44,36,28,20,12,4,
                                       62,54,46,38,30,22,14,6,64,56,48,40,32,24,16,8,
                                       57,49,41,33,25,17,9,1,59,51,43,35,27,19,11,3,
                                       61,53,45,37,29,21,13,5,63,55,47,39,31,23,15,7 };

        //Circular Left shift Table (For Encryption)  
        private int[] clst = new int[] { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };

        //Circular Right shift Table (For Decryption)  
        private int[] crst = new int[] { 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1, 1 };

        //Compression Permutation Table  
        private int[] cpt = new int[] { 14,17,11,24,1,5,3,28,15,6,21,10,
                                        23,19,12,4,26,8,16,7,27,20,13,2,
                                        41,52,31,37,47,55,30,40,51,45,33,48,
                                        44,49,39,56,34,53,46,42,50,36,29,32 };

        //Expansion Permutation Table  
        private int[] ept = new int[] { 32,1,2,3,4,5,4,5,6,7,8,9,
                                        8,9,10,11,12,13,12,13,14,15,16,17,
                                        16,17,18,19,20,21,20,21,22,23,24,25,
                                        24,25,26,27,28,29,28,29,30,31,32,1 };

        //S Box Tables ( Actual 2D S Box Tables have been converted to 1D S Box Tables for easier computation )  
        private int[,] sbox = new int[8, 64] { { 14,4,13,1,2,15,11,8,3,10,6,12,5,9,0,7,
                                                0,15,7,4,14,2,13,1,10,6,12,11,9,5,3,8,
                                                4,1,14,8,13,6,2,11,15,12,9,7,3,10,5,0,
                                                15,12,8,2,4,9,1,7,5,11,3,14,10,0,6,13 },
                                              { 15,1,8,14,6,11,3,4,9,7,2,13,12,0,5,10,
                                                3,13,4,7,15,2,8,14,12,0,1,10,6,9,11,5,
                                                0,14,7,11,10,4,13,1,5,8,12,6,9,3,2,15,
                                                13,8,10,1,3,15,4,2,11,6,7,12,0,5,14,9 },
                                              { 10,0,9,14,6,3,15,5,1,13,12,7,11,4,2,8,
                                                13,7,0,9,3,4,6,10,2,8,5,14,12,11,15,1,
                                                13,6,4,9,8,15,3,0,11,1,2,12,5,10,14,7,
                                                1,10,13,0,6,9,8,7,4,15,14,3,11,5,2,12 },
                                              { 7,13,14,3,0,6,9,10,1,2,8,5,11,12,4,15,
                                                13,8,11,5,6,15,0,3,4,7,2,12,1,10,14,9,
                                                10,6,9,0,12,11,7,13,15,1,3,14,5,2,8,4,
                                                3,15,0,6,10,1,13,8,9,4,5,11,12,7,2,14 },
                                              { 2,12,4,1,7,10,11,6,8,5,3,15,13,0,14,9,
                                                14,11,2,12,4,7,13,1,5,0,15,10,3,9,8,6,
                                                4,2,1,11,10,13,7,8,15,9,12,5,6,3,0,14,
                                                11,8,12,7,1,14,2,13,6,15,0,9,10,4,5,3 },
                                              { 12,1,10,15,9,2,6,8,0,13,3,4,14,7,5,11,
                                                10,15,4,2,7,12,9,5,6,1,13,14,0,11,3,8,
                                                9,14,15,5,2,8,12,3,7,0,4,10,1,13,11,6,
                                                4,3,2,12,9,5,15,10,11,14,1,7,6,0,8,13 },
                                              { 4,11,2,14,15,0,8,13,3,12,9,7,5,10,6,1,
                                                13,0,11,7,4,9,1,10,14,3,5,12,2,15,8,6,
                                                1,4,11,13,12,3,7,14,10,15,6,8,0,5,9,2,
                                                6,11,13,8,1,4,10,7,9,5,0,15,14,2,3,12 },
                                              { 13,2,8,4,6,15,11,1,10,9,3,14,5,0,12,7,
                                                1,15,13,8,10,3,7,4,12,5,6,11,0,14,9,2,
                                                7,11,4,1,9,12,14,2,0,6,10,13,15,3,5,8,
                                                2,1,14,7,4,10,8,13,15,12,9,0,3,5,6,11 } };

        //P Box Table  
        private int[] pbox = new int[] { 16,7,20,21,29,12,28,17,1,15,23,26,5,18,31,10,
                                         2,8,24,14,32,27,3,9,19,13,30,6,22,11,4,25 };

        //Final Permutation Table  
        private int[] fp = new int[] { 40,8,48,16,56,24,64,32,39,7,47,15,55,23,63,31,
                                       38,6,46,14,54,22,62,30,37,5,45,13,53,21,61,29,
                                       36,4,44,12,52,20,60,28,35,3,43,11,51,19,59,27,
                                       34,2,42,10,50,18,58,26,33,1,41,9,49,17,57,25 };

        public int[] plaintextbin = new int[5000];
        char[] ptca;
        public int[] ciphertextbin = new int[5000];
        char[] ctca;
        int[] keybin = new int[64];
        char[] kca;
        public int[] ptextbitslice = new int[64];
        public int[] ctextbitslice = new int[64];
        int[] ippt = new int[64];
        int[] ipct = new int[64];
        int[] ptLPT = new int[32];
        int[] ptRPT = new int[32];
        int[] ctLPT = new int[32];
        int[] ctRPT = new int[32];
        int[] changedkey = new int[56];
        int[] shiftedkey = new int[56];
        int[] tempRPT = new int[32];
        int[] tempLPT = new int[32];
        int[] CKey = new int[28];
        int[] DKey = new int[28];
        int[] compressedkey = new int[48];
        int[] ctExpandedLPT = new int[48];
        int[] ptExpandedRPT = new int[48];
        int[] XoredRPT = new int[48];
        int[] XoredLPT = new int[48];
        int[] row = new int[2];
        int rowindex;
        int[] column = new int[4];
        int columnindex;
        int sboxvalue;
        int[] tempsboxarray = new int[4];
        int[] ptSBoxRPT = new int[32];
        int[] ctSBoxLPT = new int[32];
        int[] ctPBoxLPT = new int[32];
        int[] ptPBoxRPT = new int[32];
        int[] attachedpt = new int[64];
        int[] attachedct = new int[64];
        int[] fppt = new int[64];
        int[] fpct = new int[64];
        int block = 0;
        int round = 0;

        public int totalRounds = 0;
        public string[] plaintextBlocks;
        public string[] ciphertextBlocks;
        public string[] roundOutput;
        public string[] initialPermutationForRounds;
        public string[] finalPermutationForRounds;
        public string[] leftPlaintext;
        public string[] rightPlaintetxt;

        public string[] sBoxSubstitutionRounds;
        public string[] pBoxPermutationRounds;
        public string[] lptXORfunctionRounds;

        public string[] expandedRptValues;
        public string[] compressedKeyValues;
        public string[] expandedXORcompressedValues;




        public string[] cKey;
        public string[] dKey;
        public string[] cls_ckey;
        public string[] cls_dkey;



        public string orignalKeys = "";
        public string discardedKeys = "";
        public string[] shiftedKeys;

        private int GetASCII(char ch)
        {
            int n = ch;
            return n;
        }

        public int ConvertTextToBits(char[] chararray, int[] savedarray)
        {
            int j = 0;
            for (int i = 0; i < chararray.Length; ++i)
            {
                int[] ba = DESHelper.ToBits(GetASCII(chararray[i]), 8);
                j = i * 8;
                AssignArray1ToArray2b(ba, savedarray, j);
            }

            return (j + 8);
        }



        private void AssignArray1ToArray2b(int[] array1, int[] array2, int fromIndex)
        {
            int x, y;
            for (x = 0, y = fromIndex; x < array1.Length; ++x, ++y)
                array2[y] = array1[x];
        }

        public int AppendZeroes(int[] appendedarray, int len)
        {
            int zeroes;
            if (len % 64 != 0)
            {
                zeroes = (64 - (len % 64));

                for (int i = 0; i < zeroes; ++i)
                    appendedarray[len++] = 0;
            }
            return len;
        }

        private void Discard8thBitsFromKey()
        {
            for (int i = 0, j = 0; i < 64; i++)
            {
                if ((i + 1) % 8 == 0)
                    continue;
                changedkey[j++] = keybin[i];
            }

            discardedKeys = ConvertBitsToText(changedkey, changedkey.Length);
        }

        private void AssignChangedKeyToShiftedKey()
        {
            for (int i = 0; i < 56; i++)
            {
                shiftedkey[i] = changedkey[i];
            }
        }

        private void InitialPermutation(int[] sentarray, int[] savedarray)
        {
            int tmp;
            for (int i = 0; i < 64; i++)
            {
                tmp = ip[i];
                savedarray[i] = sentarray[tmp - 1];
            }

            storePermutation('i', savedarray);

        }

        private void DivideIntoLPTAndRPT(int[] sentarray, int[] savedLPT, int[] savedRPT)
        {
            for (int i = 0, k = 0; i < 32; i++, ++k)
            {
                savedLPT[k] = sentarray[i];
            }

            for (int i = 32, k = 0; i < 64; i++, ++k)
            {
                savedRPT[k] = sentarray[i];
            }

        }

        private void storeLPT(int[] lpt)
        {


            string str = "";
            int[] temp = new int[32];
            temp = lpt;
            str = ConvertBitsToText(temp, temp.Length);
            leftPlaintext[round] = str;


        }
        private void storeRPT(int[] rpt)
        {
            string str = "";
            int[] temp = new int[32];
            temp = rpt;
            str = ConvertBitsToText(temp, temp.Length);
            rightPlaintetxt[round] = str;

        }

        private void SaveTemporaryHPT(int[] fromHPT, int[] toHPT)
        {
            for (int i = 0; i < 32; i++)
            {
                toHPT[i] = fromHPT[i];
            }
        }

        private void DivideIntoCKeyAndDKey()
        {
            for (int i = 0, j = 0; i < 28; i++, ++j)
            {
                CKey[j] = shiftedkey[i];
                cKey[round] += CKey[j].ToString();

                if ((j + 1) % 8 == 0)
                {
                    cKey[round] += "\n";
                }
            }


            for (int i = 28, j = 0; i < 56; i++, ++j)
            {
                DKey[j] = shiftedkey[i];
                dKey[round] += DKey[j].ToString();
                if ((j + 1) % 8 == 0)
                {
                    dKey[round] += "\n";
                }

            }


        }

        private void CircularLeftShift(int[] HKey)
        {
            int i, FirstBit = HKey[0];
            for (i = 0; i < 27; i++)
            {
                HKey[i] = HKey[i + 1];
            }
            HKey[i] = FirstBit;
        }
        private string saveCLStoString(int[] cls)
        {
            string str = "";
            for (int i = 0; i < 28; i++)
            {
                str += cls[i].ToString();

                if ((i + 1) % 8 == 0)
                {
                    str += "\n";
                }
            }

            return str;

        }

        private void AttachCKeyAndDKey()
        {
            int j = 0;
            for (int i = 0; i < 28; i++)
            {
                shiftedkey[j++] = CKey[i];
            }

            for (int i = 0; i < 28; i++)
            {
                shiftedkey[j++] = DKey[i];
            }

            shiftedKeys[round] = ConvertBitsToText(shiftedkey, shiftedkey.Length);
        }

        private void CompressionPermutation()
        {
            int temp;
            for (int i = 0; i < 48; i++)
            {
                temp = cpt[i];
                compressedkey[i] = shiftedkey[temp - 1];
            }

            compressedKeyValues[round] = ConvertBitsToText(compressedkey, compressedkey.Length);

        }

        private void ExpansionPermutation(int[] HPT, int[] ExpandedHPT)
        {
            int temp;
            for (int i = 0; i < 48; i++)
            {
                temp = ept[i];
                ExpandedHPT[i] = HPT[temp - 1];
            }

            expandedRptValues[round] = ConvertBitsToText(ExpandedHPT, ExpandedHPT.Length);

        }

        private void XOROperation(int[] array1, int[] array2, int[] array3, int SizeOfTheArray)
        {
            for (int i = 0; i < SizeOfTheArray; i++)
            {
                array3[i] = array1[i] ^ array2[i];
            }

        }

        private void AssignSBoxHPT(int[] temparray, int[] SBoxHPTArray, int fromIndex)
        {
            int j = fromIndex;
            for (int i = 0; i < 4; i++)
            {
                SBoxHPTArray[j++] = tempsboxarray[i];
            }
        }

        private void SBoxSubstituion(int[] XoredHPT, int[] SBoxHPT)
        {
            int r, t, j = 0, q = 0;
            for (int i = 0; i < 48; i += 6)
            {
                row[0] = XoredHPT[i];
                row[1] = XoredHPT[i + 5];
                rowindex = DESHelper.ToDecimal(row);

                column[0] = XoredHPT[i + 1];
                column[1] = XoredHPT[i + 2];
                column[2] = XoredHPT[i + 3];
                column[3] = XoredHPT[i + 4];
                columnindex = DESHelper.ToDecimal(column);

                t = ((16 * (rowindex)) + (columnindex));

                sboxvalue = sbox[j++, t];

                tempsboxarray = DESHelper.ToBits(sboxvalue, 4);

                r = q * 4;

                AssignSBoxHPT(tempsboxarray, SBoxHPT, r);

                ++q;
            }
        }

        private void PBoxPermutation(int[] SBoxHPT, int[] PBoxHPT)
        {
            int temp;
            for (int i = 0; i < 32; i++)
            {
                temp = pbox[i];
                PBoxHPT[i] = SBoxHPT[temp - 1];
            }

            //  int[] t = { 0,1,1,0,0,0,0,1,0,1,1,0,0,0,1,0};
            //   string s = ConvertBitsToText(t, t.Length);

        }

        private void Swap(int[] tempHPT, int[] HPT)
        {
            for (int i = 0; i < 32; i++)
            {
                HPT[i] = tempHPT[i];
            }
        }

        //Heart of DES  
        private void SixteenRounds()
        {
            int n;

            for (int i = 0; i < 16; i++)
            {

                storeLPT(ptLPT);
                storeRPT(ptRPT);

                SaveTemporaryHPT(ptRPT, tempRPT);

                n = clst[i];

                DivideIntoCKeyAndDKey();

                for (int j = 0; j < n; j++)
                {
                    CircularLeftShift(CKey);
                    cls_ckey[round] = saveCLStoString(CKey); ////////// storing CKEY in string format
                    CircularLeftShift(DKey);
                    cls_dkey[round] = saveCLStoString(DKey); ////////// storing DKEY in string format

                }

                AttachCKeyAndDKey();

                //Function's Code Flow//

                CompressionPermutation();

                ExpansionPermutation(ptRPT, ptExpandedRPT);

                XOROperation(compressedkey, ptExpandedRPT, XoredRPT, 48);
                expandedXORcompressedValues[round] = ConvertBitsToText(XoredRPT, XoredRPT.Length); // Saving XOr of compressed key and expanded RPT

                SBoxSubstituion(XoredRPT, ptSBoxRPT);
                sBoxSubstitutionRounds[round] = ConvertBitsToText(ptSBoxRPT, ptSBoxRPT.Length);


                PBoxPermutation(ptSBoxRPT, ptPBoxRPT);
                pBoxPermutationRounds[round] = ConvertBitsToText(ptPBoxRPT, ptPBoxRPT.Length);

                // Round's Flow

                XOROperation(ptPBoxRPT, ptLPT, ptRPT, 32);
                lptXORfunctionRounds[round] = ConvertBitsToText(ptRPT, ptRPT.Length);  /// Saving XOr of RPT and Function's Output 

                Swap(tempRPT, ptLPT);

                storeRoundsOutput(round, ptLPT, ptRPT);  // Saving LPT + RPT

                round++;

            }
        }



        private void storeRoundsOutput(int counter, int[] leftside, int[] rightside)
        {
            string str = "";
            int[] temp = new int[64];
            AttachLPTAndRPT(leftside, rightside, temp);
            str = ConvertBitsToText(temp, temp.Length);
            roundOutput[counter] = str;
        }

        private void AttachLPTAndRPT(int[] savedLPT, int[] savedRPT, int[] AttachedPT)
        {
            int j = 0;
            for (int i = 0; i < 32; i++)
            {
                AttachedPT[j++] = savedLPT[i];
            }

            for (int i = 0; i < 32; i++)
            {
                AttachedPT[j++] = savedRPT[i];
            }
        }

        private void FinalPermutation(int[] fromPT, int[] toPT)
        {
            int temp;
            for (int i = 0; i < 64; i++)
            {
                temp = fp[i];
                toPT[i] = fromPT[temp - 1];
            }

            storePermutation('f', toPT);
        }

        private void storePermutation(char c, int[] perm)
        {

            string str = "";
            int[] temp = new int[64];
            temp = perm;
            str = ConvertBitsToText(temp, temp.Length);
            if (c == 'f')
                finalPermutationForRounds[block] = str;
            else
                initialPermutationForRounds[block] = str;
        }
        //DES Components  
        private void StartEncryption()
        {
            InitialPermutation(ptextbitslice, ippt);

            DivideIntoLPTAndRPT(ippt, ptLPT, ptRPT);

            AssignChangedKeyToShiftedKey();

            SixteenRounds();

            AttachLPTAndRPT(ptLPT, ptRPT, attachedpt);

            FinalPermutation(attachedpt, fppt);
        }

        public string ConvertBitsToText(int[] sentarray, int len)
        {
            string finaltext = "";
            int j, k, decimalvalue;
            int[] tempbitarray = new int[8];

            if (len % 8 == 4) /// for 28-bits
            {
                for (int i = 0; i < len; i += 8)
                {
                    for (k = 0, j = i; j < (i + 4); ++k, ++j)
                    {
                        tempbitarray[k] = sentarray[j];
                    }

                    decimalvalue = DESHelper.ToDecimal(tempbitarray);

                    if (decimalvalue == 0)
                        finaltext += ' ';
                    else
                        finaltext += (char)decimalvalue;
                }
            }
            else // for multiple of 8-bits
            {
                for (int i = 0; i < len; i += 8)
                {
                    for (k = 0, j = i; j < (i + 8); ++k, ++j)
                    {
                        tempbitarray[k] = sentarray[j];
                    }

                    decimalvalue = DESHelper.ToDecimal(tempbitarray);

                    if (decimalvalue == 0)
                        finaltext += ' ';
                    else
                        finaltext += (char)decimalvalue;
                }

            }


            return finaltext;
        }
        public string TripleDESEncrypt(string plaintext, string key1, string key2, string key3)
        {

            string result1 = Encrypt(plaintext, key1);
            string result2 = Encrypt(result1, key2);
            string result3 = Encrypt(result2, key3);

            return result3;

        }
        public string Encrypt(string plaintext, string key)   // Override
        {
            round = 0;
            string ciphertext = null;
            this.setPlaintext(plaintext);
            this.setSecretKey(key);

            ptca = plaintext.ToCharArray();
            kca = key.ToCharArray();
            int j, k;

            //Converting plain text characters into binary digits  
            int st = ConvertTextToBits(ptca, plaintextbin);

            int fst = AppendZeroes(plaintextbin, st);

            plaintextBlocks = new string[fst / 64];
            ciphertextBlocks = new string[fst / 64];
            initialPermutationForRounds = new string[fst / 64];
            finalPermutationForRounds = new string[fst / 64];
            totalRounds = (fst / 64) * 16;
            initializeStrings(totalRounds);

            //Converting key characters into binary digits  
            int sk = ConvertTextToBits(kca, keybin);

            int fsk = AppendZeroes(keybin, sk);

            Discard8thBitsFromKey();

            string str = "";

            for (int i = 0; i < fst; i += 64)
            {
                for (k = 0, j = i; j < (i + 64); ++j, ++k)
                {
                    ptextbitslice[k] = plaintextbin[j];

                }
                str = "";
                str = ConvertBitsToText(ptextbitslice, ptextbitslice.Length);
                plaintextBlocks[i / 64] = str;
                block = i / 64;
                StartEncryption();

                for (k = 0, j = i; j < (i + 64); ++j, ++k)
                {
                    ciphertextbin[j] = fppt[k];///j=k
                    ctextbitslice[k] = ciphertextbin[j]; ///k=j
                }
                str = "";
                str = ConvertBitsToText(ctextbitslice, ctextbitslice.Length);
                ciphertextBlocks[i / 64] = str;
            }

            ciphertext = ConvertBitsToText(ciphertextbin, fst);

            return ciphertext;
        }

        private void initializeStrings(int t)
        {


            roundOutput = new string[t];
            leftPlaintext = new string[t];
            rightPlaintetxt = new string[t];

            sBoxSubstitutionRounds = new string[t];
            pBoxPermutationRounds = new string[t];
            lptXORfunctionRounds = new string[t];

            expandedRptValues = new string[t];
            compressedKeyValues = new string[t];
            expandedXORcompressedValues = new string[t];

            cKey = new string[t];
            dKey = new string[t];
            cls_ckey = new string[t];
            cls_dkey = new string[t];
            shiftedKeys = new string[t];
        }

        private void CircularRightShift(int[] HKey)
        {
            int i, LastBit = HKey[27];
            for (i = 27; i >= 1; --i)
            {
                HKey[i] = HKey[i - 1];
            }
            HKey[i] = LastBit;
        }

        private void ReversedSixteenRounds()
        {
            int n;

            for (int i = 0; i < 16; i++)
            {
                SaveTemporaryHPT(ctLPT, tempLPT);

                CompressionPermutation();

                ExpansionPermutation(ctLPT, ctExpandedLPT);

                XOROperation(compressedkey, ctExpandedLPT, XoredLPT, 48);

                SBoxSubstituion(XoredLPT, ctSBoxLPT);

                PBoxPermutation(ctSBoxLPT, ctPBoxLPT);

                XOROperation(ctPBoxLPT, ctRPT, ctLPT, 32);

                Swap(tempLPT, ctRPT);

                n = crst[i];

                DivideIntoCKeyAndDKey();

                for (int j = 0; j < n; j++)
                {
                    CircularRightShift(CKey);
                    CircularRightShift(DKey);
                }

                AttachCKeyAndDKey();
            }
        }

        private void StartDecryption()
        {
            InitialPermutation(ctextbitslice, ipct);

            DivideIntoLPTAndRPT(ipct, ctLPT, ctRPT);

            AssignChangedKeyToShiftedKey();

            ReversedSixteenRounds();

            AttachLPTAndRPT(ctLPT, ctRPT, attachedct);

            FinalPermutation(attachedct, fpct);
        }

        public string Decrypt(string ciphertext, string key)  //Override
        {
            string plaintext = null;

            ctca = ciphertext.ToCharArray();
            kca = key.ToCharArray();
            int j, k;

            //Converting plain text characters into binary digits  
            int st = ConvertTextToBits(ctca, ciphertextbin);

            int fst = AppendZeroes(ciphertextbin, st);

            //Converting key characters into binary digits  
            int sk = ConvertTextToBits(kca, keybin);

            int fsk = AppendZeroes(keybin, sk);

            Discard8thBitsFromKey();

            for (int i = 0; i < fst; i += 64)
            {
                for (k = 0, j = i; j < (i + 64); ++j, ++k)
                {
                    ctextbitslice[k] = ciphertextbin[j];
                }

                StartDecryption();

                for (k = 0, j = i; j < (i + 64); ++j, ++k)
                {
                    plaintextbin[j] = fpct[k];
                }
            }

            plaintext = ConvertBitsToText(plaintextbin, fst);

            return plaintext;
        }

        sealed public class DESHelper
        {

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

        }

    }
}
