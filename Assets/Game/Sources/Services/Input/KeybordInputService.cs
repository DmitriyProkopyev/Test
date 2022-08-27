using UnityEngine;
using Zenject;

namespace Game.Sources
{
    public class KeybordInputService : IInputService, ITickable
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