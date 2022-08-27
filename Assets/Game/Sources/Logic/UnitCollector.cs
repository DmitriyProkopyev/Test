using System;
using System.Collections.Generic;
using ModestTree;
using UnityEngine;

namespace Game.Sources
{
    public class UnitCollector : MonoBehaviour
    {
        [SerializeField] private TriggerObserver _trigger;
        [SerializeField] private PlayerMove _playerMove;

        private readonly List<Human> _humans = new List<Human>();
        private readonly List<Zombie> _zombie = new List<Zombie>();

        private void Start() => _trigger.Enter += OnTriggerEnter;

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.TryGetComponent(out Zone zone))
            {
                switch (zone)
                {
                    case ZoneMarket zoneMarket:
                        OnZoneEnter(zoneMarket);
                        break;
                    case ZonePaddock zonePaddock:
                        OnZoneEnter(zonePaddock);
                        break;
                    case ZonePrison zonePrison:
                        OnZoneEnter(zonePrison);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(zone));
                }
            }
        }


        private void OnZoneEnter(ZonePrison prison)
        {
            if (_zombie.IsEmpty())
            {
                _humans.AddRange(prison.TakeAllUnits());
                Follow(_humans, to: _playerMove.transform);
            }
        }

        private void OnZoneEnter(ZonePaddock paddock)
        {
            if (_humans.IsEmpty())
            {
                _zombie.AddRange(paddock.TakeAllUnits());
                Follow(_zombie, to: _playerMove.transform);
            }
            else
            {
                paddock.Recycle(_humans);
                Follow(_humans, to: paddock.transform);
                _humans.Clear();
            }
        }

        private void OnZoneEnter(ZoneMarket market)
        {
            _zombie.ForEach(market.Sold);
            Follow(_zombie, to: market.transform);
            _zombie.Clear();
        }

        public void Follow(IEnumerable<Unit> units, Transform to)
        {
            foreach (Unit unit in units) 
                unit.Follow(to);
        }
    }
}