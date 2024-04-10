using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class UnitGenerator : MonoBehaviour
{
    public List<AbstractUnit> units = new List<AbstractUnit>();

    public List<AbstractUnit> getUnits()
    {
        return units;
    }

    // Factory Method
    public abstract void CreateUnits();
}
