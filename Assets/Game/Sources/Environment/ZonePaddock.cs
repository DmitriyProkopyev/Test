using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ZonePaddock : Zone<Zombie>
{
    [SerializeField] private int _price;

    public int Price => _price;

    public void Recycle(List<Human> humans)
    {
    
    }
}