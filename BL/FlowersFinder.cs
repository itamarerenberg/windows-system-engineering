using BE;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FlowersFinder
    {
        private FlowersReader flowersReader;

        public FlowersFinder()
        {
            flowersReader = new FlowersReader();
        }

        public List<Flower> Search(string str)
        {
            return (from f in flowersReader.GetFlowers()
                   where f.Name.Contains(str)
                   select f).ToList();
        }
    }
}
