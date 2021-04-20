using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP.Model
{
    class SecurityAlgorithm
    {

        private string plainText;
        private string cipherText;
        private string categoryName;
        private string algoType;
        private string algorithmName;
        private int Key;


        static SecurityAlgorithm securityAlgorithm;

        public static SecurityAlgorithm Instance
        {
            get
            {
                if (securityAlgorithm == null)
                {
                    securityAlgorithm = new SecurityAlgorithm();


                }


                return securityAlgorithm;
            }
        }


        public void setPlaintext(String text)
        {
            plainText = text;

        }
        public void setCiphertext(String text)
        {
            cipherText = text;
        }

        public void setKey(int key)
        {
            this.Key = key;
        }

        public int getKey()
        {
            return Key;
        }
        public void setCategoryName(String text)
        {
            categoryName = text;

        }

        public void setAlgoType(String text)
        {
            algoType = text;
        }

        public void setAlgorithmName(String text)
        {
            algorithmName = text;
        }

        public string getPlaintext()
        {
            return this.plainText;

        }
        public string getCiphertext()
        {
            return this.cipherText;
        }


        public String getCategoryName()
        {
            return this.categoryName;

        }

        public String getAlgoType()
        {
            return this.algoType;
        }

        public String getAlgorithmName()
        {
            return this.algorithmName;
        }
    }


}
