using System;
using UnityEngine;

namespace Game.Sources
{
    public class TriggerObserver : MonoBehaviour
    {
        public event Action<Collider> Enter;
        public event Action<Collider> Exit; 
        
        public event Action<Collider> Attached; 
        public event Action<Collider> Detached;

        private void OnTriggerEnter(Collider other) => Enter?.Invoke(other);
        private void OnTriggerExit(Collider other) => Exit?.Invoke(other);

        private void OnCollisionEnter(Collision collision) => Attached?.Invoke(collision.collider);
        private void OnCollisionExit(Collision collision) => Detached?.Invoke(collision.collider);
    }
}