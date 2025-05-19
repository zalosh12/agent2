using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent2
{
    internal class Report
    {
        public string summary;
        public int urgencyLevel;
        public Agent submittedBy;

        public Report(string summary, int urgencyLevel, Agent submittedBy)
        {
            this.summary = summary;
            this.urgencyLevel = urgencyLevel;
            this.submittedBy = submittedBy;
        }
    }
}
