using UnityEngine;
using Zenject;

namespace Game.Sources.Installers
{
    public class MainSceneInstaller : MonoInstaller
    {
        [SerializeField] private Factory _factory;

        public override void InstallBindings()
        {
            Container.Bind<Factory>().FromComponentInNewPrefab(_factory).AsSingle();
        }
    }
}