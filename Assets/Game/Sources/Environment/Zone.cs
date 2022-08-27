using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Zone : MonoBehaviour
{
    private List<Unit> _units = new List<Unit>();

    protected void AddUnit(Unit unit)
    {
        _units.Add(unit);
    }

    protected void AddUnits(IEnumerable<Unit> units)
    {
        _units.AddRange(units);
    }

    public IEnumerable<Unit> TakeAllUnits()
    {
        if (_units.Count == 0)
            return null;

        IEnumerable<Unit> units = new List<Unit>(_units);
        _units.Clear();

        return units;
    }
}
