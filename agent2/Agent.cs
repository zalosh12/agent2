using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent2
{
    internal class Agent
    {
        public string CodeName;
        private int ClearanceLevel;


        public int MyClearanceLevel
        {
            get { return ClearanceLevel; }
            set {
                if(1 <= value && value <= 5) ClearanceLevel = value; }
        }


        public Agent(string codeName, int clearanceLevel)
        {
            CodeName = codeName;
            ClearanceLevel = clearanceLevel;
        }


 

   


        public void Report()
        {
            Console.WriteLine($"Agent {CodeName} reporting clearance level: {ClearanceLevel}");
        }
    }
}
