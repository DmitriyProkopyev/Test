using UnityEngine;
using Zenject;

public class MainSceneInstaller : Installer<MainSceneInstaller>
{
    [SerializeField] private Factory _factory;

    public override void InstallBindings()
    {
        Container.Bind<Factory>().FromComponentInNewPrefab(_factory);
    }
}