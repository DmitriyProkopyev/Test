using System;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Zenject;

namespace Game.Sources
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;
        
        private IInputService _inputService;

        [Inject]
        public void Constructor(IInputService inputService)
        {
            _inputService = inputService;
        }

        public void Update()
        {
            var moveDirection = GetInput();
            
            transform.position += moveDirection * Time.deltaTime * _speed;
            
            if(moveDirection != Vector3.zero)
                transform.forward = moveDirection;
        }

        private Vector3 GetInput() => new Vector3(_inputService.Delta.x, 0, _inputService.Delta.y);
    }
}