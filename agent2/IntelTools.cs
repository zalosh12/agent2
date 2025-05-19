using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent2
{
    internal class IntelTools
    {
        public static string EncryptMessage(string msg)
        {
            string res = "";
            for (int i = msg.Length - 1; i >= 0; i--)
            {
                res += msg[i];
            }
            return res;
        }

        public static void LogTransmission(string AgentName, string msg) { 
            Console.WriteLine($"Agent: {AgentName} sent encrypted message: {msg}");
        }
    }
}
