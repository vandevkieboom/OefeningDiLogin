using Interfaces;
using LoginAdapters;
using Ninject;

namespace OefeningDiLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            //kernel.Bind<ILogin>().To<AlwaysLoginAdapter>();
            kernel.Bind<ILogin>().To<HardCodedLoginAdapter>();

            var app = kernel.Get<VerySecretApplication>();
            app.Start();
        }
    }
}
