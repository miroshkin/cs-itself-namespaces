using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Itself.Namespaces
{
    class A
    {
        
    }

    namespace FirstNamespace
    {
        class B
        {
            public class C
            {

            }
        }

        namespace SecondNamespace
        {
           class D {} 
        }
    }

    namespace FirstNamespace.SecondNamespace
    {
        class E {}  
    }
}
