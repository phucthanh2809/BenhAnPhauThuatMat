// Decompiled with JetBrains decompiler
// Type: Library.Dichso
// Assembly: Library, Version=2.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 052E1FCA-8639-4163-9BA7-FB978B5C9021
// Assembly location: C:\Users\Quang Minh\Desktop\Library.dll

using System;

namespace PN_EMR
{
    public class Dichso
    {
        private string m_ngonngu;
        private string m_donvi;

        public string NgonNgu
        {
            get
            {
                return this.m_ngonngu;
            }
            set
            {
                this.m_ngonngu = value;
            }
        }

        public string DonVi
        {
            get
            {
                return this.m_donvi;
            }
            set
            {
                this.DonVi = this.m_donvi;
            }
        }

        public Dichso()
        {
            this.m_ngonngu = "VN";
            this.m_donvi = "đồng";
        }

        public Dichso(string NgonNgu, string DonVi)
        {
            this.m_ngonngu = NgonNgu;
            this.m_donvi = DonVi;
        }

        public string Dich(double socandoc)
        {
            string str1 = "";
            string str2 = !(this.m_donvi.ToUpper() == "USD") ? "Xu" : "Cents";
            string str3;
            string str4;
            string str5;
            if (this.m_ngonngu.ToUpper() == "VN")
            {
                str3 = " Âm";
                str4 = " Không";
                str5 = " chẳn";
            }
            else
            {
                str3 = " Minus";
                str4 = " Zero";
                str5 = " only";
            }
            if (socandoc < 0.0)
                str1 = str3;
            if (socandoc == 0.0)
                return str4 + this.m_donvi;
            string[] strArray = Math.Round(Math.Abs(socandoc), 2).ToString().Split(',', ' ');
            long int64 = Convert.ToInt64(strArray[0]);
            long so = strArray.Length != 2 ? 0L : Convert.ToInt64(strArray[1]);
            string str6;
            if (so == 0L)
                str6 = str1 + this.dichso2(int64, this.m_ngonngu) + " " + this.m_donvi + str5;
            else
                str6 = str1 + this.dichso2(int64, this.m_ngonngu) + " " + this.m_donvi + this.dichso2(so, this.m_ngonngu) + " " + str2;
            string str7 = str6.Trim();
            return str7.Substring(0, 1).ToUpper() + str7.Substring(1, str7.Length - 1);
        }

        private string dichso2(long so, string ngonngu)
        {
            string[] strArray1 = new string[4];
            string[] strArray2 = new string[11];
            string[] strArray3 = new string[11];
            string[] strArray4 = new string[11];
            long num1 = so;
            string str1;
            string str2;
            string str3;
            string str4;
            if (ngonngu.ToUpper() == "ENGLISH")
            {
                str1 = " and";
                str2 = " hundred";
                str3 = " and";
                str4 = " Five";
                strArray1[0] = "";
                strArray1[1] = " thousand";
                strArray1[2] = " million";
                strArray1[3] = " billion";
                strArray2[0] = "";
                strArray2[1] = " One";
                strArray2[2] = " Two";
                strArray2[3] = " Three";
                strArray2[4] = " Four";
                strArray2[5] = " Five";
                strArray2[6] = " Six";
                strArray2[7] = " Seven";
                strArray2[8] = " Eight";
                strArray2[9] = " Nine";
                strArray2[10] = " Ten";
                strArray3[0] = "";
                strArray3[1] = " Eleven";
                strArray3[2] = " Twelve";
                strArray3[3] = " Thirteen";
                strArray3[4] = " Fourteen";
                strArray3[5] = " Fifteen";
                strArray3[6] = " Sixteen";
                strArray3[7] = " Seventeen";
                strArray3[8] = " Eighteen";
                strArray3[9] = " Nineteen";
                strArray4[0] = "";
                strArray4[1] = " ";
                strArray4[2] = " Twenty";
                strArray4[3] = " Thirty";
                strArray4[4] = " Forty";
                strArray4[5] = " Fifty";
                strArray4[6] = " Sixty";
                strArray4[7] = " Seventy";
                strArray4[8] = " Eighty";
                strArray4[9] = " Ninety";
            }
            else
            {
                str1 = "";
                str2 = " trăm";
                str3 = " lẻ";
                str4 = " lăm";
                strArray1[0] = "";
                strArray1[1] = " nghìn";
                strArray1[2] = " triệu";
                strArray1[3] = " tỷ";
                strArray2[0] = "";
                strArray2[1] = " một";
                strArray2[2] = " hai";
                strArray2[3] = " ba";
                strArray2[4] = " bốn";
                strArray2[5] = " năm";
                strArray2[6] = " sáu";
                strArray2[7] = " bảy";
                strArray2[8] = " tám";
                strArray2[9] = " chín";
                strArray2[10] = " mười";
                strArray3[0] = "";
                strArray3[1] = " mười một";
                strArray3[2] = " mười hai";
                strArray3[3] = " mười ba";
                strArray3[4] = " mười bốn";
                strArray3[5] = " mười lăm";
                strArray3[6] = " mười sáu";
                strArray3[7] = " mười bảy";
                strArray3[8] = " mười tám";
                strArray3[9] = " mười chín";
                strArray4[0] = "";
                strArray4[1] = " ";
                strArray4[2] = " hai mươi";
                strArray4[3] = " ba mươi";
                strArray4[4] = " bốn mươi";
                strArray4[5] = " năm mươi";
                strArray4[6] = " sáu mươi";
                strArray4[7] = " bảy mươi";
                strArray4[8] = " tám mươi";
                strArray4[9] = " chín mươi";
            }
            string str5 = "";
            string str6 = "";
            string str7 = "";
            long length = (long)num1.ToString().Length;
            int index1 = 0;
            for (long index2 = 0; index2 < length; ++index2)
            {
                string str8 = "";
                str6 = "";
                string str9 = "";
                long num2 = num1;
                num1 /= 1000L;
                long num3 = num2 - num1 * 1000L;
                if (num3 != 0L)
                {
                    long index3 = num3 / 100L;
                    long index4 = (num3 - index3 * 100L) / 10L;
                    long index5 = num3 % 10L;
                    if (index3 != 0L)
                        str8 = strArray2[index3] + str2;
                    string str10;
                    switch (index4)
                    {
                        case 0:
                            if (index5 != 0L)
                            {
                                if (num3 > 9L)
                                {
                                    str10 = str3;
                                    str7 = strArray2[index5];
                                }
                                else
                                    str10 = "";
                                str9 = strArray2[index5];
                                goto label_22;
                            }
                            else
                            {
                                str10 = "";
                                str9 = "";
                                goto label_22;
                            }
                        case 1:
                            str10 = index5 == 0L ? (index3 != 0L ? str1 : "") + strArray2[10] : (index3 != 0L ? str1 : "") + strArray2[index4];
                            break;
                        default:
                            str10 = (index3 != 0L ? str1 : "") + strArray4[index4];
                            break;
                    }
                    if (index5 != 0L && index4 != 1L)
                        str9 = index5 == 5L ? str4 : strArray2[index5];
                    if (index5 != 0L && index4 == 1L)
                    {
                        str10 = Math.Abs(num2) <= 100L ? strArray3[index5] : str1 + strArray3[index5];
                        index5 = 0L;
                    }
                    if (index5 == 0L)
                        str9 = "";
                    label_22:
                    if (index1 == 0)
                        str5 = str8 + str10 + str9;
                    else
                        str5 = str8 + str10 + str9 + strArray1[index1] + str5;
                }
                if (index1 < 3)
                    ++index1;
                else
                    index1 = 1;
            }
            return str5;
        }
    }
}
