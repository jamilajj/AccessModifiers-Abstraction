using System;
using System.Collections.Generic;
using System.Text;

namespace _14._02._23
{
    internal class Student
    {
        public string FullName;
        public string GroupNo;
        public byte Age;

        public bool CheckNo(string no)
        {
            {
                if ((!string.IsNullOrWhiteSpace(no)) && no.Length == 4 && char.IsUpper(no[0]) && char.IsDigit(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]))
                    return true;
            }
            return false;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            
            
            
            if (CheckNo(groupNo))
            {
                return true;
            }
            if (groupNo == null) { return false; }
            
        }

    }
}
