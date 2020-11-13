using System;

namespace Inlamning1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Deklarerar tre operander och två operatorer
            double x, y, z;
            char op1, op2;

            //Ber om inmatning och läser in samt konvertarar inmatningen till respektive datatyper: double (högre precision och många svar lär inte vara heltal) och char

            Console.Write("> Input 1st operation (+,-,*,/): ");
            op1 = Convert.ToChar(Console.ReadLine());
            Console.Write("> Input 2nd operation (+,-,*,/): ");
            op2 = Convert.ToChar(Console.ReadLine());
            Console.Write("> Input first number: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("> Input second number: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("> Input third number: ");
            z = Convert.ToDouble(Console.ReadLine());

            // Skapar if loop med bereonde på operatortyp och dess positionering, ==> 16 st olika utfall

            if ((op1 == '+') && (op2 == '+'))
                Console.WriteLine("> {0} + {1} + {2} = {3}", x, y, z, x + y + z);
            else if ((op1 == '-') && (op2 == '-'))
                Console.WriteLine("> {0} - {1} - {2} = {3}", x, y, z, x - y - z);
            else if ((op1 == '+') && (op2 == '-'))
                Console.WriteLine("> {0} + {1} - {2} = {3}", x, y, z, x + y - z);
            else if ((op1 == '+') && (op2 == '*'))
                Console.WriteLine("> {0} + {1} * {2} = {3}", x, y, z, x + y * z);
            else if ((op1 == '+') && (op2 == '/'))
                Console.WriteLine("> {0} + {1} / {2} = {3}", x, y, z, x + y / z);
            else if ((op1 == '-') && (op2 == '+'))
                Console.WriteLine("> {0} - {1} ? {2} = {3}", x, y, z, x - y + z);
            else if ((op1 == '-') && (op2 == '*'))
                Console.WriteLine("> {0} - {1} * {2} = {3}", x, y, z, x - y * z);
            else if ((op1 == '-') && (op2 == '/'))
                Console.WriteLine("> {0} - {1} / {2} = {3}", x, y, z, x - y / z);
            else if ((op1 == '*') && (op2 == '+'))
                Console.WriteLine("> {0} * {1} + {2} = {3}", x, y, z, x * y + z);
            else if ((op1 == '*') && (op2 == '-'))
                Console.WriteLine("> {0} * {1} - {2} = {3}", x, y, z, x * y - z);
            else if ((op1 == '*') && (op2 == '*'))
                Console.WriteLine("> {0} * {1} * {2} = {3}", x, y, z, x * y * z);
            else if ((op1 == '*') && (op2 == '/'))
                Console.WriteLine("> {0} * {1} / {2} = {3}", x, y, z, x * y / z);
            else if ((op1 == '/') && (op2 == '+'))
                Console.WriteLine("> {0} / {1} + {2} = {3}", x, y, z, x / y + z);
            else if ((op1 == '/') && (op2 == '-'))
                Console.WriteLine("> {0} / {1} + {2} = {3}", x, y, z, x / y - z);
            else if ((op1 == '/') && (op2 == '*'))
                Console.WriteLine("> {0} / {1} * {2} = {3}", x, y, z, x / y * z);
            else if ((op1 == '/') && (op2 == '/'))
                Console.WriteLine("> {0} / {1} / {2} = {3}", x, y, z, x / y / z);
            else
                Console.WriteLine("> Wrong input");
        }
    }
}
