using UnityEngine;
using Zenject;

namespace Game.Sources.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<KeybordInputService>().AsSingle();
        }
    }
}