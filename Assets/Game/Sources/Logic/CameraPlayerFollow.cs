using System;
using UnityEngine;
using Zenject;

namespace Game.Sources
{
    public class CameraPlayerFollow : MonoBehaviour
    {
        [SerializeField] private CameraFollower _cameraFollower;

        private PlayerMove _playerMove;

        [Inject]
        public void Constructor(PlayerMove playerMove)
        {
            _playerMove = playerMove;
        }

        
        private void Start() => _cameraFollower.Follow(_playerMove.transform);
    }
}