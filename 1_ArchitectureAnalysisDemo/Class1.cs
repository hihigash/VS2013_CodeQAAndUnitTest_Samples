using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ArchitectureAnalysisDemo
{
    class Class1
    {
        public Class1()
        {
            this.Class2 = new Class2(this);
        }

        public Class2 Class2 { get; set; }
    }
}
