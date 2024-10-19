using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public class Texture : IEntity
    {
        private static int counter = 20000;
        private int _id;
        public Texture()
        {
            _id = ++counter;
        }
        public int GetId()
        {
            return _id;
        }
        public override string ToString()
        {
            return $"Texture #{_id}";
        }
    }
}
