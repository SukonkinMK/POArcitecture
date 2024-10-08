using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class WipingStation : IWiping
    {
        public void WipMirrors()
        {
            Console.WriteLine("Мойка зеркал");
        }

        public void WipWindshield()
        {
            Console.WriteLine("Мойка стекол");
        }

        public void WipHeadLights()
        {
            Console.WriteLine("Мойка фар");
        }
    }
}
