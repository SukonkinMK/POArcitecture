using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    internal class EditorDatabase : IDatabase
    {
        private readonly ProjectFile _projectFile;
        private readonly Random _random = new Random();
        private List<IEntity> _entities;

        public EditorDatabase(ProjectFile projectFile)
        {
            _projectFile = projectFile;
            Load();
        }

        public List<IEntity> GetAll()
        {
            if(_entities == null)
            {
                _entities = new List<IEntity>();
                int quantity = _random.Next(5,11);
                for(int i = 0; i < quantity; i++)
                {
                    GenerateModelAndTextures();
                }
            }
            return _entities;
        }

        public void Load()
        {
            //загрузка сущностей проекта
        }

        public void Save()
        {
            //сохранить сущностей проекта
        }

        private void GenerateModelAndTextures()
        {
            Model3D model3D = new Model3D();
            int txCount = _random.Next(3);
            for(int i = 0;i < txCount;i++)
            {
                Texture texture = new Texture();
                model3D.Textures.Add(texture);
                _entities.Add(texture);
            }
            _entities.Add(model3D);
        }
    }
}
