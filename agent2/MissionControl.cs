using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent2
{
    internal class MissionControl
    {
        public static void AnalyzeReport(Report r)
        {
            int level = r.urgencyLevel;
            switch (level)
            {
                case int n when n >= 4:
                    Console.WriteLine("Immediate response required.");
                    break;
                case 3:
                    Console.WriteLine("High priority. Monitor closely.");
                    break;
                default:
                    Console.WriteLine("Routine analysis.");
                    break;
            }

        }
    }
}
