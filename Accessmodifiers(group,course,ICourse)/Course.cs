using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Accessmodifiers_group_course_ICourse_
{
    internal class Course : ICourse
    {
        public Group[] Groups = new Group[0]; 
        public void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
           Groups[Groups.Length - 1] = group;
            throw new NotImplementedException();
        }

        public Group[] GetGroupByPointRange(byte min, byte max)
        {
            Group[] wantedGroups = new Group[0];
            foreach(var item in Groups)
            {
                if (item.AvgPoint >= min && item.AvgPoint < max)
                {
                    Array.Resize(ref wantedGroups, wantedGroups.Length + 1);
                    wantedGroups[wantedGroups.Length - 1] = item;
                }
                return wantedGroups;
            }

            throw new NotImplementedException();
        }



        public Group[] GetGroupByNo(string no)
        {
            Group[] wantedGroups = new Group[0];
            foreach (Group item in Groups)
              {
                if (item.No == no)
                
                    return wantedGroups;
              }
            return null;
        }

        public Group[] Search(string str)
        {
            Group[] wantedGroups = new Group[0];
            foreach (Group item in Groups)
            {
                if (item.No.Contains(str))
                {
                    Array.Resize(ref wantedGroups, wantedGroups.Length + 1);
                    wantedGroups[wantedGroups.Length - 1] = item;
                }
            }
            return wantedGroups;
            throw new NotImplementedException();
        }

        internal object GetGroupByPointRange(object min, object max)
        {
            throw new NotImplementedException();
        }
    }
}
