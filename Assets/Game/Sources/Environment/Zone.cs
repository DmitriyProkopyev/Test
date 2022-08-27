using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Zone : MonoBehaviour
{
    
}

public abstract class Zone<TUnit> : Zone where TUnit : Unit
{
    private List<TUnit> _units = new List<TUnit>();

    public void Add(TUnit unit)
    {
        _units.Add(unit);
    }

    public void Add(IEnumerable<TUnit> units)
    {
        _units.AddRange(units);
    }

    public IEnumerable<TUnit> TakeAllUnits()
    {
        if (_units.Count == 0)
            return null;

        IEnumerable<TUnit> units = new List<TUnit>(_units);
        _units.Clear();

        return units;
    }
}
