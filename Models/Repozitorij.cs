using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models
{
    public class Repozitorij
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string description { get; set; }

        public int maxpoint { get; set; }
        public int minpointsgr { get; set; }
        public int minpointsig { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
