using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent2
{
    internal class Mission
    {
        public string MissionName;
        public string TargetLocation;
        public Agent AssignedAgent;

        public Mission(string missionName, string targetLocation, Agent assignedAgent)
        {
            MissionName = missionName;
            TargetLocation = targetLocation;
            AssignedAgent = assignedAgent;
        }

        public void Brief()
        {
            Console.WriteLine($"Mission: {MissionName},target location{TargetLocation},Agent:{AssignedAgent.CodeName}");
            Console.WriteLine(AssignedAgent.MyClearanceLevel);
        }
    }
    


}
