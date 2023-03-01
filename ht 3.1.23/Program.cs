using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ht_3._1._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("Write yoy polindrom");
            string sentence = Console.ReadLine();

            bool polindrom = true;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ') sentence.Remove(i, 1);
            }
            sentence = sentence.ToUpper();
            if (sentence.Length % 2 == 0)
            {
                sentence = sentence.Insert(sentence.Length / 2, " ");

            }

            int midS = sentence.Length / 2;
            for (int i = 1; (i <= midS) && (polindrom == true); i++)
            {
                if (sentence[midS - i] != sentence[midS + i])
                {
                    polindrom = false;
                    Console.WriteLine("This is not polindrom!");
                }
            }
            if (polindrom) Console.WriteLine("This is really polindrom");
            #endregion

            #region 2
            Console.WriteLine("Write str in engilsh. ENGLISH! DO! YOU! SPEEK! IT!?:");
            string str = Console.ReadLine();
            int wordCount = 0;
            int vowelCount = 0;
            int NEvowelCount = 0;
            int punctuationCount = 0;
            int digitCount = 0;
            int otherCount = 0;
            bool IsVowel(char c)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
                    return true;
                else { return false; }
            }
            foreach (char c in str)
            {
                if (Char.IsWhiteSpace(c))
                {
                    wordCount++;
                }
                else if (Char.IsPunctuation(c))
                {
                    punctuationCount++;
                }
                else if (Char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (IsVowel(c))
                {
                    vowelCount++;
                }
                else if (!IsVowel(c))
                {
                    NEvowelCount++;
                }
                else
                {
                    otherCount++;
                }


            }
            Console.WriteLine($"We've got:\n{wordCount} words;\n{vowelCount} Vowels;\n{NEvowelCount} NE vowels;\n{punctuationCount} Punctuation marks;\n{digitCount} Digitov;\n{otherCount} Otherov;");
            #endregion
            //#region 3
            //Console.WriteLine("Norm string");
            //string norm = Console.ReadLine(); Console.WriteLine("Hard spelling string");
            //string bred = Console.ReadLine();

            //for (int i = 0; i < norm.Length; i++)
            //{
            //    if (Char.IsLetter(norm[i]))
            //    {

            //    }
            //    else { norm = norm.Remove(i, 1); }
            //}
            //for (int i = 0; i < bred.Length; i++)
            //{
            //    if (Char.IsLetter(bred[i]))
            //    {

            //    }
            //    else { bred = bred.Remove(i, 1); }
            //}
            //norm.ToUpper();
            //bred.ToUpper();
            //#endregion

            //    #region 5
            //    int precision = 1000000; // Ограничить точность до одного миллиона знаков после запятой
            //    BigInteger pi = GetPi(precision);
            //    int maxDigitCount = 0;
            //    int digitCount = 0;
            //    bool firstNineFound = false;

            //    while (pi > 0)
            //    {
            //        int digit = (int)(pi % 10);

            //        if (digit == 9)
            //        {
            //            if (firstNineFound)
            //            {
            //                if (digitCount > maxDigitCount)
            //                {
            //                    maxDigitCount = digitCount;
            //                }
            //                digitCount = 0;
            //            }
            //            else
            //            {
            //                firstNineFound = true;
            //            }
            //        }
            //        else if (firstNineFound)
            //        {
            //            digitCount++;
            //        }

            //        pi /= 10;
            //    }

            //    Console.WriteLine($"The highest amount of numbers betwen two '9' is: {maxDigitCount}");
            //}

            //static BigInteger GetPi(int precision)
            //{
            //    return BigInteger.Divide(BigInteger.Multiply(BigInteger.Pow(10, precision + 1), 22), 7);
            //}

#endregion
        }

    }

