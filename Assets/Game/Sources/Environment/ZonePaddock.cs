using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ZonePaddock : Zone
{
    [SerializeField] private int _price;
    //private Factory _factory;

    //[Inject]
    //public void Constructor(Factory factory)
    //{
    //    _factory = factory;
    //}

    public void AddHuman(Human human)
    {
        AddUnit(human);
        //_factory.CreatePaddock();
    }

    public void AddHumans(List<Human> humans)
    {
        AddUnits(humans);
    }
}