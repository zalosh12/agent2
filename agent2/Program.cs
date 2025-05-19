using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Agent myAgent = new Agent("wow", 3);
            Mission yourt = new Mission("barzel", "gaza", myAgent);
            Report r = new Report("nothing",3,myAgent);
            MissionControl.AnalyzeReport(r);
            IntelTools.LogTransmission(myAgent.CodeName, IntelTools.EncryptMessage(r.summary));
        }
    }
}
