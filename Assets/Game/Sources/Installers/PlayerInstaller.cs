using UnityEngine;
using Zenject;

namespace Game.Sources.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerMove _player;

        public override void InstallBindings()
        {
            Container.BindInterfacesTo<KeybordInputService>().AsSingle();
            Container.Bind<PlayerMove>().FromInstance(_player).AsSingle();
        }
    }
}