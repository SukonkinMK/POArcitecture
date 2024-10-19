using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public class EditorDatabaseAccess : IDatabaseAccess
    {
        private readonly IDatabase _database;

        public EditorDatabaseAccess(IDatabase database)
        {
            _database = database;
        }

        public void AddEntity(IEntity entity)
        {
            _database.GetAll().Add(entity);
        }

        public List<Model3D> GetModels()
        {
            List<Model3D> models = new List<Model3D>();
            foreach (var entity in _database.GetAll())
            {
                Model3D? item = entity as Model3D;
                if (item is not null )
                {                    
                    models.Add(item);
                }
            }
            return models;
        }

        public List<Texture> GetTextures()
        {
            List<Texture> models = new List<Texture>();
            foreach (var entity in _database.GetAll())
            {
                Texture? item = entity as Texture;
                if (item is not null)
                {
                    models.Add(item);
                }
            }
            return models;
        }

        public void RemoveEntity(IEntity entity)
        {
            _database.GetAll().Remove(entity);
        }
    }
}
