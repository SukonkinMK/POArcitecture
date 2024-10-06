using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    internal class Scene
    {
        public int Id {  get; }
        public List<PoligonalModel> Models { get; set; }
        public List<Flash> Flashes { get; set; }
        public Camera Camera { get; set; }

        public Scene(int id, List<PoligonalModel> models, List<Flash> flashes, Camera camera)
        {
            Id = id;
            Models = models;
            Flashes = flashes;
            Camera = camera;
        }
    }
}
