using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperTest
{
    public class EntityA
    {
        public DateTime CreateTime { get; set; }
        public int PropertyA { get; set; }
        public int PropertyB { get; set; }
    }


    public class EntityB
    {
        public DateTime CreateTime { get; set; }
        public string PropertyAA { get; set; }

        public string PropertyBB { get; set; }

    }


    public abstract class BaseViewModel
    {
        public DateTime CreateTimeFromB { get; set; }
        public DateTime CreateTime { get; set; }
    }

    public class ViewModelA : BaseViewModel
    {
        public int PropertyA { get; set; }

        public string PropertyAA { get; set; }

    }

    public class ViewModelB : BaseViewModel
    {
        public int PropertyB { get; set; }

        public string PropertyBB { get; set; }

    }
}
