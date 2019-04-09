using Scanner.Domain.Common;
using Scanner.Domain.Facebook;
using Scanner.Domain.PryzmSocial;
using Scanner.Infrastructure;
using SimpleInjector;

namespace Scanner.DependencyResolution
{
    internal class Bootstrapper
    {
        private static readonly Container Container;
        static Bootstrapper()
        {
            Container = new Container();
            GlobalContainer.Container = new MyContainer(Container);
            Container.Register<IFacebookService, FacebookService>(Lifestyle.Singleton);
            Container.Register<IPryzmSocialService, PryzmSocialService>(Lifestyle.Singleton);
            Container.Verify();
        }

        public static void Main(string[] args)
        {
            var handler = Container.GetInstance<MainWindowOpener>();
            handler.StartApplication();
        }
    }
}
