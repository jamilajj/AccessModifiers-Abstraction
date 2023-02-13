using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Accessmodifiers_group_course_ICourse_
{
    internal class Group
    {
        string _no;
        byte _avgPoint;
       public string No
        {
            get => _no;
            set
            {
                if (CheckNo(value))
                {
                    _no = value;
                }
            }
        }
       

        public bool CheckNo(string no)
        {
            {
                if ((!string.IsNullOrWhiteSpace(no)) && no.Length == 4 && char.IsUpper(no[0]) && char.IsDigit(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]))
                    return true;
            }
                   return false;
        }
        

      public byte AvgPoint
        {
            get => _avgPoint;
            set
            {
                if (value >= 0 && value <= 100)
                    _avgPoint = value;
            }

        }
    }   
    
}
