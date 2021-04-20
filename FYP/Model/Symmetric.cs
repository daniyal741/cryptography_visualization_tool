using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP.Model
{
    class Symmetric : SecurityAlgorithm
    {

        private String secretKey;
        

        public String getSecretKey()
        {
            return this.secretKey;
        }
        public void setSecretKey(String value)
        {
             this.secretKey = value;
        }
    }
}
