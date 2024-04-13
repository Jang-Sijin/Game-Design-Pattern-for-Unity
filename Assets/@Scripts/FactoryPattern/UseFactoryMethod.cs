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

    // Ÿ���� �� ���� �ִٴ� �͸� �ȴ�.
    public void DoMakeTypeA()
    {
        // ������ ��������� ���⼭�� �𸥴�.
        unitGenerators[0].CreateUnits();

        List<AbstractUnit> units = unitGenerators[0].getUnits();
        //foreach (Unit unit in units) 
        //{
        //    unit.Attack();
        //}
    }
}
