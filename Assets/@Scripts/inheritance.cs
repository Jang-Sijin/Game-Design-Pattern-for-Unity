using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// [�θ� Ŭ����]
public class Super
{
    public void Execute1()
    {
        Debug.Log($"Super Execute1");
    }

    public virtual void Execute2()
    {
        Debug.Log($"Super Execute2");
    }
}

// [�θ� ��ӹ��� �ڽ� Ŭ����]
public class Sub : Super
{
    public void Execute1()
    {
        Debug.Log($"Sub Execute1");
    }

    public override void Execute2()
    {
        Debug.Log($"Sub Execute2");
    }

    public void Execute3()
    {
        base.Execute1();
        Debug.Log($"Sub Execute3");
    }
}

public class inheritance : MonoBehaviour
{   
    private void Start()
    {
        Super super = new Super();
        Sub sub = new Sub();

        super.Execute1();   // result: Super Execute1
        super.Execute2();   // result: Super Execute2

        sub.Execute1();     // result: Sub Execute1
        sub.Execute2();     // result: Sub Execute2
        sub.Execute3();     // result: Super Execute1 + Sub Execute3

        // sub = super > ������ ���� �߻� (�Ͻ��� ����ȯ �Ұ�)
        // sub = (Sub)super > ��Ÿ�� ���� �߻�, �θ� Ŭ������ �ڽ� Ŭ������ ����ȯ�Ͽ� ����� �� ����.
        super = sub;
        super.Execute1();   // result: Super Execute1
        super.Execute2();   // result: Sub Execute2
        //super.Execute3(); > ������ ���� �߻�(�θ� Ŭ������ �ڽ� Ŭ������ ����� �� ����.)
    }
}