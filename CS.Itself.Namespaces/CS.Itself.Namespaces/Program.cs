using System;
using CS.Itself.Namespaces.FirstNamespace;
using CS.Itself.Namespaces.FirstNamespace.SecondNamespace;

namespace CS.Itself.Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespaceDescriptor.PrintNamespace<A>();
            NamespaceDescriptor.PrintNamespace<B>();
            NamespaceDescriptor.PrintNamespace<B.C>();
            NamespaceDescriptor.PrintNamespace<D>();
            NamespaceDescriptor.PrintNamespace<E>();
        }
    }
}
