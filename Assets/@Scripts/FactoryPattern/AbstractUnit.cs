using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum UnitType
{
    Marine,
    Firebat
}

abstract class AbstractUnit
{
    protected UnitType type;
    protected string name;
    protected int hp;
    protected int exp;
    public abstract void Attack();
}
