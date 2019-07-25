using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
namespace NUnit.InsightsRetail
{
    public static class UnityContainerFactory
    {
        private static IUnityContainer unityConatiner;
        static UnityContainerFactory()
        {
            unityConatiner = new UnityContainer();

        }

        public static IUnityContainer GetContainer()
        {
            return unityConatiner;
        }
    }
}
