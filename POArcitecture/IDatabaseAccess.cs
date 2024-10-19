using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public interface IDatabaseAccess
    {
        public List<Texture> GetTextures();
        public List<Model3D> GetModels();
        void AddEntity(IEntity entity);
        void RemoveEntity(IEntity entity);
    }
}
