using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace XML
{
    public class Organizations
    {
        public Datas LeaderInfo;
        public Datas LeaderInfo2;
        public Datas LeaderInfo3;
        [XmlArray("Organizations")]
        public List<OrgInfo> OrgInfos;
        public Organizations() { }
        public Organizations(Datas LeaderInfo, Datas LeaderInfo2, Datas LeaderInfo3)
        {
            this.LeaderInfo = LeaderInfo;
            this.LeaderInfo2 = LeaderInfo2;
            this.LeaderInfo3 = LeaderInfo3;
            OrgInfos = new List<OrgInfo>();
        }

        public void Save(Organizations organizations)
        {
            FileStream fs = new FileStream("organization.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Organizations));
            xs.Serialize(fs, organizations);
            fs.Close();
        }
    }

    public class Datas
    {
        public string Leader;
        public string Faculty;
        public int Age;
        public string City;
        public Datas() { }
        public Datas(string Leader, int Age, string Faculty, string City)
        {
            this.Leader = Leader;
            this.Age = Age;
            this.Faculty = Faculty;
            this.City = City;
        }
    }

    public class OrgInfo
    {
        public string Leader;
        public int MemCount;
        public string Name;
        public int Office;
        public int Price;
        public int Spend;

        public OrgInfo() { }
        public OrgInfo(string Leader, string Name, int MemCount, int Office, int Price)
        {
            this.Leader = Leader;
            this.MemCount = MemCount;
            this.Name = Name;
            this.Office = Office;
            this.Price = Price;
            this.Spending();
        }

        public void Spending()
        {
            Spend = MemCount * Price;
        }
    }

}