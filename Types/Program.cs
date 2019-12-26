using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            NullableType nullableType = new NullableType();
            nullableType.AMethod();

            //ValueTupleType valueTupleType = new ValueTupleType();
            //valueTupleType.ValueTupleTypeMethod();
            //Console.WriteLine(valueTupleType.ValueTupleReturnType().Item1);

            //TupleType tupleType = new TupleType();
            //tupleType.TupleTypeMethod();
            //tupleType.MaximumElementsTuple();
            //tupleType.NestedTuple();
            //tupleType.ParameterTuple(Tuple.Create(1, "Steve", "Jobs"));
            //Console.WriteLine(tupleType.ReturnTypeTuple().Item1);

            //Indexer indexer = new Indexer();
            //indexer.IndexerMethod();

            //AnonymousType anonymousType = new AnonymousType();
            //anonymousType.AMethod();
            //anonymousType.BMethod();

            //DynamicType dynamicType = new DynamicType();
            //dynamicType.AMethod();

            //StructType structType = new StructType();
            //structType.StructTypeMethod();

            //RefKeyWord refKeyWord = new RefKeyWord();
            //refKeyWord.AMethod();

            //OutKeyWord outKeyWord = new OutKeyWord();
            //outKeyWord.AMethod();

            //StringBuild sbobj = new StringBuild();
            //sbobj.StringBuildMethod();

            //TypeConversion tcobj = new TypeConversion();
            //tcobj.ExplicitMethod();
            //tcobj.ImplictMethod();

            //EnumType enobj = new EnumType();
            //enobj.EnumTypeMethod();

            //ArrayType arrayType = new ArrayType();
            //arrayType.ArraysMethod();

            //Parsing paobj = new Parsing();
            //paobj.ParsingMethod();

            //DataType pdobj = new DataType();
            //pdobj.DataTypeMethod();

            Console.ReadLine();
        }
    }
}
