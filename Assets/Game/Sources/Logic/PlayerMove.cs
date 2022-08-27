using System;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Zenject;

namespace Game.Sources
{
    public class PlayerMove : MonoBehaviour
    {
        private IInputService _inputService;

        [Inject]
        public void Constructor(IInputService inputService)
        {
            _inputService = inputService;
        }

        public void Update()
        {
            transform.position += new Vector3(_inputService.Delta.x, 0, _inputService.Delta.y) * Time.deltaTime;
        }
    }
}