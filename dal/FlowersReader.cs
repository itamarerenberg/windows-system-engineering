using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class FlowersReader
    {
        private List<Flower> flowers { get; set; }
        public FlowersReader()
        {
            flowers = new List<Flower> {
                new Flower
                {
                    Color = "red",
                    Description = "beutifull",
                    Location = "Israel",
                    Name="iris",
                    Image= @"https://ichef.bbci.co.uk/news/976/cpsprodpb/C448/production/_117684205_lotus.jpg"
                },
                new Flower
                {
                    Color = "green",
                    Description = "lovely",
                    Location = "USA",
                    Name="shosh",
                    Image= @"https://ichef.bbci.co.uk/news/976/cpsprodpb/C448/production/_117684205_lotus.jpg"
                }
            };
        }
        public IEnumerable<Flower> GetFlowers()
        {
            return flowers;
        }
    }
}
