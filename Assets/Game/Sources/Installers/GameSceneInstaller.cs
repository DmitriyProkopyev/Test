using UnityEngine;
using Zenject;

namespace Game.Sources.Installers
{
    public class GameSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<KeybordInputService>().AsSingle();
        }
    }
}