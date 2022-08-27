using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePaddock : Zone
{
    [SerializeField] private int _price;

    public void AddHuman(Human human)
    {
        AddUnit(human);
    }

    public void AddHumans(List<Human> humans)
    {
        AddUnits(humans);
    }
}