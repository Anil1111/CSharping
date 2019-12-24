using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    //https://www.tutorialsteacher.com/csharp/constraints-in-generic-csharp
    class GenericConstraints<T> where T : class //struct, new(), <base class name>, <interface name>, U
    {
        private T genericMemberVariable;

        public GenericConstraints(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }

    class GenericConstraints2<T, U> where T : class where U : struct
    {
        private T genericClassMemberVariable;
        private U genericStructMemberVariable;
        public T genericMethod<U>(T genericParameter, U genericStructMemberVariable)
        {
            Console.WriteLine("Generic Parameter of type {0}, value {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return value of type {0}, value {1}", typeof(T).ToString(), genericClassMemberVariable);
            Console.WriteLine("Return value of type {0}, value {1}", typeof(T).ToString(), genericStructMemberVariable);

            return genericClassMemberVariable;
        }
    }

    class GenericConstraintMethod<T, U> where T : class where U : struct
    {
        private T genericClassMemberVariable;
        private U genericStructMemberVariable;
        public T genericMethod<W>(T genericParameter, U genericStructMemberVariable, W anotherGenericType) where W : struct
        {
            Console.WriteLine("Generic Parameter of type {0}, value {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return value of type {0}, value {1}", typeof(T).ToString(), genericClassMemberVariable);
            Console.WriteLine("Return value of type {0}, value {1}", typeof(T).ToString(), genericStructMemberVariable);

            return genericClassMemberVariable;
        }
    }
}
