using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClassLibrary1
{
    namespace TestLib1
    {
        public class Class
        {
            public Class()
            { }
            public string Version
            {
                get
                {
                    Assembly assembly = Assembly.GetAssembly(GetType());
                    return assembly.GetName().Version.ToString();
                }
            }
        }
    }

}
