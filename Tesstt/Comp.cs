using System;
using System.Collections.Generic;
using System.Text;

namespace Tesstt
{
    class Comp : Comparer<Compar>
    {

        public override int Compare(Compar x, Compar y)
        {
            if (x.salary.CompareTo(y.salary) != 0)
            {
                return x.salary.CompareTo(y.salary);
            }
            else if (x.experience.CompareTo(y.experience) != 0)
            {
                return x.experience.CompareTo(y.experience);
            }
            else if (x.age.CompareTo(y.age) != 0)
            {
                return x.age.CompareTo(y.age);
            }
            else
            {
                return 0;
            }
        }
    }

   
}
