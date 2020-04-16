using System;
using System.Collections.Generic;
using System.Text;

namespace IslamicAndArabic.Extensions
{
    public sealed class PreserveAttribute : System.Attribute
    {
        public bool AllMembers;
        public bool Conditional;
        //[Preserve(AllMembers = true)] Use before all classes to preserve
    }
}
