using System;
using System.Collections.Generic;
using System.Text;

namespace Accessmodifiers_group_course_ICourse_
{
    internal interface ICourse
    {


             void AddGroup(Group group);
            Group[] GetGroupByPointRange(byte min, byte max);
            Group[] Search(String str);
    }
}
