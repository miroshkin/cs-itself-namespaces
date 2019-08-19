using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Itself.Namespaces
{
    public static class NamespaceDescriptor
    {
        /// <summary>
        /// Prints out namespace of a class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void PrintNamespace <T> ()
        {
            Type aType = typeof(T);
            Console.WriteLine("Namespace: {0}.", aType.Namespace);
        }
    }
}
