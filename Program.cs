using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace Nullables
{

    struct Book
    {
        int id;
        string title;
        string genre;
    }

    class Shapes
    {
        int id;
        static void function()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int? @int = null;
            // int @int = null; // Error, harus ada operator nullable (<type>? <variable>)

            short? @short = null;
            // short @short = null;  // Error, harus ada operator nullable (<type>? <variable>)

            long? @long = null;
            // long @long = null; // Error, harus ada operator nullable (<type>? <variable>)

            float? @float = null;
            // long @long = null; // Error, harus ada operator nullable (<type>? <variable>)

            double? @double = null;
            // long @long = null; // Error, harus ada operator nullable (<type>? <variable>)

            decimal? @decimal = null;
            // decimal @decimal = null; // Error, harus ada operator nullable (<type>? <variable>)

            bool? @bool = null;
            // bool @bool = null; // Error, harus ada operator nullable (<type>? <variable>)

            char? @char = null;
            // char @char = null; // Error, harus ada operator nullable (<type>? <variable>)

            byte? @byte = null;
            // byte? @byte = null; // Error, harus ada operator nullable (<type>? <variable>)

            Book? book = null;
            // Book book = null; // Error, harus ada operator nullable (<type>? <variable>)

            Shapes shape = null;

            string @string = null; // Tidak Error, 

            // Using null coalescing operator
            string str01 = null, str02 = null, str03 = null, str04 = "Have String", str05 = "Second string" ;
            string strFinal = str01 ?? str02 ?? str03 ?? str04 ?? str05;
            Console.WriteLine("String yang dicetak : " + strFinal);

            int? var01 = null;
            int? var02 = null;
            int? var03 = null;
            int? var04 = null;
            int? var05 = 100;
            int? var06 = 500;
            int? strF = var01 ?? var02 ?? var03 ?? var04 ?? var05 ?? var06;
            Console.WriteLine("String yang dicetak : {0}", strF);

            
            Console.ReadKey();

        }
    }
}
