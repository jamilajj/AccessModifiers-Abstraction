using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace _14._02._23
{
    internal static class ExtentionMetod
    {
        public static bool IsOdd(int num)
        {
            if (num > 0) 
            {
                if (num % 2 == 1)
                {
                    return true;
                }
            }

            return false;       

        }


        public static bool IsEven(int num)
        {
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        } 


        public static bool IsContainsDigits(string str)
        {
            if (str != null)
            {
                if (str.Length > 0)
                {
                    foreach (char c in str)
                    {
                        if (char.IsDigit(str[c]))
                        {
                            return true;
                        }

                    }
                    
                }
            }
            return false;
        }
        
        public static string ToCapitalize(this string str)
        {
            do
            {
                if (str != null && str.Length > 0)
                {

                    foreach (char c in str)
                    {
                        if (char.IsLetter(str[c]))
                        {
                            string Newstr = char.ToUpper(str[0]) + str.Substring(1).ToLower();
                            return Newstr;

                        }
                    }

                }
            }
            while (true);
        }
        public static int CountChar(this string str, char wantedChar)
        {
            if (str == null) return 0;

            int[] count = { };
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == wantedChar) ;
                    
                   
            }

            return 
        }








    }
}
