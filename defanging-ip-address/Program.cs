using System;

namespace defanging_ip_address
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DefangIPaddr("1.1.1.1"));
        }

        public static string DefangIPaddr(string address) {
            var addressSplittedByDot = address.Split('.');
            return string.Join("[.]", addressSplittedByDot);
        }   
    }
}
