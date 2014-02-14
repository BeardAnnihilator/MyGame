using MyGame.Data;
using StructureMap;

namespace MyGame
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(init =>
                            {
                                init.Scan(scan =>
                                        {
                                            scan.TheCallingAssembly();
                                            scan.LookForRegistries();
                                            scan.WithDefaultConventions();
                                        });
                                
                                init.For<IService>().Use<Service>();
                            });
        }
    }
}