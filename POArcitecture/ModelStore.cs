using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    internal class ModelStore : IModelChanger
    {
        public List<PoligonalModel> Models { get; }
        public List<Flash> Flashes { get; }
        public List<Scene> Scenes { get; }
        public List<Camera> Cameras { get; }

        private List<IModelChangedObserver> observers = new List<IModelChangedObserver>();

        public ModelStore(List<PoligonalModel> models, List<Flash> flashes, List<Scene> scenes, List<Camera> cameras)
        {
            Models = models;
            Flashes = flashes;
            Scenes = scenes;
            Cameras = cameras;
        }

        public void AddModel(PoligonalModel model)
        {
            Models.Add(model);
            NotifyChange();
        }
        public void RegisterObservers(IModelChangedObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IModelChangedObserver observer)
        {
            observers.Remove(observer);
        }
        public Scene GetScene(int id)
        {
            return Scenes.First(s => s.Id == id);
        }
        public void NotifyChange()
        {
            foreach(var observer in observers)
            {
                observer.ApplyUpdateModel();
            }
        }
    }
}
