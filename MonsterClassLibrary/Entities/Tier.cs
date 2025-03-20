using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassLibrary.Entities
{
    public class Tier
    {
        public string Name { get; set; }
        public double PowerAndHealthModifier { get; set; }

        public Tier(DataRow row)
        {
            Name = Convert.ToString(row[0]);
            PowerAndHealthModifier = Convert.ToDouble(row[1]);
        }
    }
}
