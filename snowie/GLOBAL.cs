using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowie
{
    public static class GLOBAL
    {
        public static string? PlayerName { get; set; }
        public class PartyMember0
        {
            public int Happiness = 20; // Happy ranges from 0SUICIDAL to 100ECSTATIC
            public int HP = 20; // physical HP 0DEAD - 20HEALTHY
            public int fear = 0; //emotionalfear 0-20
        }
    }
}
