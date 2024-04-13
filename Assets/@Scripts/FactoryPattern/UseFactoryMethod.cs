using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFactoryMethod : MonoBehaviour
{
    UnitGenerator[] unitGenerators = null;

    private void Start()
    {
        unitGenerators = new UnitGenerator[2];

        unitGenerators[0] = new PatternAGenerator();
        unitGenerators[1] = new PatternBGenerator();
    }

    // 타입이 두 가지 있다는 것만 안다.
    public void DoMakeTypeA()
    {
        // 무엇이 만들어질지 여기서는 모른다.
        unitGenerators[0].CreateUnits();

        List<AbstractUnit> units = unitGenerators[0].getUnits();
        //foreach (Unit unit in units) 
        //{
        //    unit.Attack();
        //}
    }
}
