using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public class EditorBusinessLogicalLayer : IBusinessLogicalLayer
    {
        private readonly IDatabaseAccess _databaseAccess;
        private readonly Random _random = new();

        public EditorBusinessLogicalLayer(IDatabaseAccess databaseAccess)
        {
            _databaseAccess = databaseAccess;
        }

        public List<Model3D> GetModels()
        {
            return _databaseAccess.GetModels();
        }

        public List<Texture> GetTextures()
        {
            return _databaseAccess.GetTextures();
        }

        public void RenderAllModels()
        {
            foreach (var item in GetModels())
            {
                ProcessRender(item);
            }
        }

        public void RenderModel(Model3D model)
        {
            ProcessRender(model);
        }

        private void ProcessRender(Model3D model)
        {
            try
            {
                Thread.Sleep(2500 - _random.Next(2000));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
