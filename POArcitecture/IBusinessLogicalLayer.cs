using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public interface IBusinessLogicalLayer
    {
        List<Model3D> GetModels();
        List<Texture> GetTextures();
        void RenderModel(Model3D model);
        void RenderAllModels();
    }
}
