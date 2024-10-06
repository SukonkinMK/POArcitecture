using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    internal class PoligonalModel
    {
        private List<Poligon> poligons;
        private List<Texture> textures;

        public PoligonalModel(List<Poligon> poligons)
        {
            this.poligons = poligons;
        }

        public PoligonalModel(List<Poligon> poligons, List<Texture> textures) : this(poligons)
        {
            this.textures = textures;
        }
    }
}
