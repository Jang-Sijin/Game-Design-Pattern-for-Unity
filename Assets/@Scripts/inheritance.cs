using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// [부모 클래스]
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

// [부모를 상속받은 자식 클래스]
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

        // sub = super > 컴파일 에러 발생 (암시적 형변환 불가)
        // sub = (Sub)super > 런타임 에러 발생, 부모 클래스를 자식 클래스로 형변환하여 사용할 수 없다.
        super = sub;
        super.Execute1();   // result: Super Execute1
        super.Execute2();   // result: Sub Execute2
        //super.Execute3(); > 컴파일 에러 발생(부모 클래스는 자식 클래스를 사용할 수 없다.)
    }
}