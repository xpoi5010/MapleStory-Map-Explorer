using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MapExplorer
{

    public class MapList:Dictionary<string,List<Map>>
    {
        public MapList() : base()
        {
            string Infomation = "";
        }

        public List<Map> this[string Key]
        {
            get
            {
                if (this.ContainsKey(Key))
                {
                    return base[Key];
                }
                else
                {
                    this.Add(Key, new List<Map>());
                    return base[Key];
                }
            }
            
        }

        

        public void Add(Map map)
        {
            Add(map.StreetName, map);
        }

        public void Add(string StreetName,Map map)
        {
            if(StreetName is null)
            {
                StreetName = "(無街道名稱)";
            }
            this[StreetName].Add(map);
        }
    }

    public struct Map
    {
        public string StreetName { get; set; }
        public string MapName { get; set; }
        public string Id { get; set; }
    }
}
