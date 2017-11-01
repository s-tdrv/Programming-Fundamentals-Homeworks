using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDebuggingAndTroubleshootingCodeLAB
{
    class Program
    {

        static void PrinReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        static void PrintReceipt()
        {
            PrinReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
        static void Main(string[] args)
        {
            PrintReceipt();
        }

     

    }
}
