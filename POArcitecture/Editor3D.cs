using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public class Editor3D : IUILayer
    {
        private ProjectFile _projectFile;
        private  IBusinessLogicalLayer _logicalLayer;
        private IDatabaseAccess _databaseAccess;
        private IDatabase _database;
        

        private void Initialize()
        {
            _database = new EditorDatabase(_projectFile);
            _databaseAccess = new EditorDatabaseAccess(_database);
            _logicalLayer = new EditorBusinessLogicalLayer(_databaseAccess);
        }

        public void OpenProject(string fileName)
        {
            _projectFile = new ProjectFile(fileName);
            Initialize();
            Console.WriteLine("Проект успешно открыт");
        }

        public void PrintAllModels()
        {
            CheckProjectFile();

            List<Model3D> models = _logicalLayer.GetModels();
            foreach (Model3D model in models)
            {
                Console.WriteLine(model);
                foreach (var item in model.Textures)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void PrintAllTextures()
        {
            CheckProjectFile();

            List<Texture> textures = _logicalLayer.GetTextures();
            foreach (Texture texture in textures)
            {
                Console.WriteLine(texture);                
            }
        }

        public void RenderAll()
        {
            CheckProjectFile();
            
            Console.WriteLine("Подождите...");
            DateTime startTime = DateTime.Now;
            _logicalLayer.RenderAllModels();
            double time = (DateTime.Now - startTime).TotalMilliseconds;
            Console.WriteLine($"Операция выполнени за {time} мс");
        }

        public void RenderModel(int i)
        {
            CheckProjectFile();

            List<Model3D> models = _logicalLayer.GetModels();
            if(i < 0 || i > models.Count)
            {
                throw new Exception("номер модели указан некорректно");
            }
            Console.WriteLine("Подождите...");
            DateTime startTime = DateTime.Now;
            _logicalLayer.RenderModel(models[i]);
            double time = (DateTime.Now - startTime).TotalMilliseconds;
            Console.WriteLine($"Операция выполнени за {time} мс");

        }

        public void SaveProject()
        {
            _database.Save();
            Console.WriteLine("Изменения успешно сохранены");
        }

        public void ShowProjectSettings()
        {
            CheckProjectFile();

            Console.WriteLine("*** Project v1 ***");
            Console.WriteLine("*****************************");
            Console.WriteLine($"fileName: {_projectFile.FileName}");
            Console.WriteLine($"setting1: {_projectFile.Setting1}");
            Console.WriteLine($"setting2: {_projectFile.Setting2}");
            Console.WriteLine($"setting3: {_projectFile.Setting3}");
            Console.WriteLine("*****************************");
        }

        private void CheckProjectFile()
        {
            if (_projectFile == null)
            {
                throw new InvalidOperationException("Файйл проекта не определен");
            }
        }
    }
}
