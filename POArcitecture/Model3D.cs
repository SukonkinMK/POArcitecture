using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public class Model3D : IEntity
    {
        private static int counter = 0;
        private int _id;
        public List<Texture> Textures {  get; }
        public int GetId()
        {
            return _id;
        }
        public Model3D() : this(new List<Texture>()){ }
        public Model3D(List<Texture> textures)
        {
            Textures = textures;
            _id = ++counter;
        }
        public override string ToString()
        {
            return $"3DModel #{_id}";
        }
    }
}
