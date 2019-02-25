using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace XML
{
    class Program
    {
        public static void FU()
        {
            Datas LeaderInfo = new Datas();
            LeaderInfo.Age = 18;
            LeaderInfo.City = "Shymkent";
            LeaderInfo.Faculty = "FIT";
            LeaderInfo.Leader = "Dayana Orazbayeva";

            Datas LeaderInfo2 = new Datas();
            LeaderInfo2.Leader = "Linara Ualiyeva";
            LeaderInfo2.Age = 19;
            LeaderInfo2.City = "Atyrau";
            LeaderInfo2.Faculty = "FIT";

            Datas LeaderInfo3 = new Datas();
            LeaderInfo3.Leader = "Lidiya Karnaukhova";
            LeaderInfo3.Age = 18;
            LeaderInfo3.City = "Atyrau";
            LeaderInfo3.Faculty = "FIT";

            OrgInfo mem1 = new OrgInfo(LeaderInfo.Leader, "ProFIT", 13, 228, 200);
            OrgInfo mem2 = new OrgInfo(LeaderInfo2.Leader, "BigCityLights", 2, 312, 100);
            OrgInfo mem3 = new OrgInfo(LeaderInfo3.Leader, "Killers", 84, 200, 500);

            Organizations organizations = new Organizations(LeaderInfo, LeaderInfo2, LeaderInfo3);
            organizations.OrgInfos.Add(mem1);
            organizations.OrgInfos.Add(mem2);
            organizations.OrgInfos.Add(mem3);
            organizations.Save(organizations);
        }

        static void Main(string[] args)
        {
            FU();
        }
    }
}
