using System.Text;
using System.Security.Cryptography;
using System.Linq;
using System;

namespace Crypto
{
    static class Constants
    {
        public const string EncrypTable = "CDEFG12345abzyxwvut";
        public const int    EncodeOffset = 2;
    }

    class MyCrypto
    {
        public static string Encrypt(string str)
        {
            string result = "";
            byte[] Byte_Str =Encoding.Unicode.GetBytes(str);
            for(int i = 0; i < Byte_Str.Count(); i++)
            {
                int tmp = (short)Byte_Str[i];
                for(int k = 1; k <= 8; k++)
                {
                    if(k  % Constants.EncodeOffset == 0)
                    {
                        int bitchg = 0x0001 << (k - 1);
                        tmp ^= bitchg;
                    }
                }
                Byte_Str[i] = (byte)tmp;
                int indexH = ((Byte_Str[i] & 0xf0) >> 4);
                result += Constants.EncrypTable[indexH];
                int indexL = ((Byte_Str[i] & 0x0f));
                result += Constants.EncrypTable[indexL];
            }
            return result;
        }

        public static string Decrypt(string str)
        {
            string result = "";
            for(int i = 0; i < str.Count(); i += 4)
            {
                int indexH1 = 0, indexL1 = 0, indexH2 = 0, indexL2 = 0;
                for(int j = 0; j < Constants.EncrypTable.Length; j++)
                {
                    if(str[i] == Constants.EncrypTable[j])
                    {
                       indexH1 = j;
                    }
                    if(str[i + 1] == Constants.EncrypTable[j])
                    {
                        indexL1 = j;
                    }
                    if(str[i + 2] == Constants.EncrypTable[j])
                    {
                        indexH2 = j;
                    }
                    if(str[i + 3] == Constants.EncrypTable[j])
                    {
                        indexL2 = j;
                    }
                }
                byte[] originByte = new byte[2];
                originByte[0] = (byte)Convert.ToInt32((indexH1 << 4) | (indexL1));
                int tmp = (short)originByte[0];
                for(int j = 1; j <= 8; j++)
                {
                    if(j % Constants.EncodeOffset == 0)
                    {
                        int bitchg = 0x0001 << (j - 1);
                        tmp ^= bitchg;
                    }
                }
                originByte[0] = (byte)tmp;

                originByte[1] = (byte)Convert.ToInt32((indexH2 << 4) | (indexL2));
                tmp = (short)originByte[1];
                for(int j = 1; j <= 8; j++)
                {
                    if(j % Constants.EncodeOffset == 0)
                    {
                        int bitchg = 0x0001 << (j - 1);
                        tmp ^= bitchg;
                    }
                }
                originByte[1] = (byte)tmp;
                result += Convert.ToString(System.Text.Encoding.Unicode.GetString(originByte));
            }
            return result;
        }
    }
}