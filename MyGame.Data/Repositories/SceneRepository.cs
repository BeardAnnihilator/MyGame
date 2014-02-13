using MyGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.Infrastructure;

namespace MyGame.Data.Repositories
{
    internal class SceneRepository : BaseRepository, IExtendedRepository<Scene>
    {
        private List<Scene> _scenes;
        
        public SceneRepository(IContext context) : base(context)
        {
            _scenes = context.Engine.Scenes;
        }

        public Scene Get()
        {
            return _scenes.SingleOrFallback( () => new Scene());
        }

        public Scene Get(string id)
        {
            return _scenes.Single(scene => scene.Id == id);
        }

        public IEnumerable<Scene> GetAll()
        {
            return _scenes;
        }

        public void Update(Scene entity)
        {
            throw new NotImplementedException();
        }

        public void Append(Scene entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Scene entity)
        {
            throw new NotImplementedException();
        }
    }
}
