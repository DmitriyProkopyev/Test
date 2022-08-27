using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePaddock : Zone<Zombie>
{
    [SerializeField] private int _price;

    public void Recycle(List<Human> humans)
    {
        
    }
}