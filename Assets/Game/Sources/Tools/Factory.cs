using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Factory : MonoBehaviour
{
    [SerializeField] private ZonePaddock _paddock;
    private IInstantiator _instantiator;

    [Inject]
    public void Constructor(IInstantiator instantiator)
    {
        _instantiator = instantiator;
    }

    public void CreatePaddock(Vector3 position, Quaternion rotation)
    {
        _instantiator.InstantiatePrefab(_paddock, position, rotation, null);
    }
}
