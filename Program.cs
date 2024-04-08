using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string hostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
            IPAddress[] addresses = ipEntry.AddressList;

            Console.WriteLine("Your IP addresses:");
            foreach (IPAddress address in addresses)
            {
                Console.WriteLine(address.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }
}
