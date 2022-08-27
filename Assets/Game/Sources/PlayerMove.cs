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
            transform.position += new Vector3(_inputService.Delta.x, 0, _inputService.Delta.y);
        }
    }

    public interface IInputService
    {
        Vector2 Delta { get; }
    }

    public class InputService : IInputService, ITickable
    {
        public Vector2 Delta { get; private set; }
        
        public void Tick()
        {
            Vector2 delta = Vector2.zero;
            
            if (Input.GetKey(KeyCode.A)) 
                delta += Vector2.right;

            if (Input.GetKey(KeyCode.D)) 
                delta += Vector2.left;

            if (Input.GetKey(KeyCode.W)) 
                delta += Vector2.up;

            if (Input.GetKey(KeyCode.S))
                delta += Vector2.down;

            Delta = delta;
        }
    }
}