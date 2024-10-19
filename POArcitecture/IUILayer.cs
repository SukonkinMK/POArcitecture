using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public interface IUILayer
    {
        void OpenProject(string fileName);
        void ShowProjectSettings();
        void SaveProject();
        void PrintAllModels();
        void PrintAllTextures();
        void RenderAll();
        void RenderModel(int i);
    }
}
