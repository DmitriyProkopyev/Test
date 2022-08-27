using System;
using Cinemachine;
using UnityEngine;
using Zenject;

namespace Game.Sources
{
    public class CameraFollower : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera _virtualCamera;
        
        public void Follow(Transform target)
        {
            _virtualCamera.Follow = target;
            _virtualCamera.LookAt = target;
        }
    }
}