using System.Collections.Generic;

namespace Dijkstra
{
    //All times in minutes
    public class TimesToArrival
    {
        public Dictionary<Company, int> ContactsTimes => new Dictionary<Company, int>
        {
            { Company.Hirevue, 10 },
            { Company.Pluralsight, 20 },
            { Company.Sofi, 20 },
            { Company.Adobe, 20 }
        };

        public Dictionary<Company, int> HirevueTimes => new Dictionary<Company, int>
        {
            { Company.Pluralsight, 5 },
            { Company.Contacts, 10 }
        };

        public Dictionary<Company, int> PluralsightTimes => new Dictionary<Company, int>
        {
            { Company.Hirevue, 5 },
            { Company.Contacts, 20 },
            { Company.Ihc, 15 },
            { Company.Sofi, 30 }
        };

        public Dictionary<Company, int> IhcTimes => new Dictionary<Company, int>
        {
            { Company.Pluralsight, 15 },
            { Company.OcTanner, 30 }
        };

        public Dictionary<Company, int> OcTannerTimes => new Dictionary<Company, int>
        {
            { Company.Ihc, 30 },
            { Company.Sofi, 15 }
        };

        public Dictionary<Company, int> SofiTimes => new Dictionary<Company, int>
        {
            { Company.OcTanner, 15 },
            { Company.Contacts, 20 },
            { Company.Pluralsight, 30 }
        };

        public Dictionary<Company, int> AdobeTimes => new Dictionary<Company, int>
        {
            { Company.Contacts, 20 },
            { Company.Vivint, 10 },
            { Company.Xactware, 10 }
        };

        public Dictionary<Company, int> XactwareTimes => new Dictionary<Company, int>
        {
            { Company.Adobe, 10 }
        };

        public Dictionary<Company, int> VivintTimes => new Dictionary<Company, int>
        {
            { Company.Adobe, 10 },
            { Company.Jane, 5 }
        };

        public Dictionary<Company, int> JaneTimes => new Dictionary<Company, int>
        {
            { Company.Vivint, 5 }
        };
    }
}