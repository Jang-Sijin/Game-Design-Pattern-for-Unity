using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    public abstract void move();
}

public class Marine : Unit
{
    public Marine()
    {
        Debug.Log("마린 생성 !!!");
    }

    public override void move()
    {
        Debug.Log("마린 이동 !!!");
    }
}

public class Firebat : Unit
{
    public Firebat()
    {
        Debug.Log("파이어벳 생성 !!!");
    }

    public override void move()
    {
        Debug.Log("파이어벳 이동 !!!");
    }
}

public class Medic : Unit
{
    public Medic()
    {
        Debug.Log("메딕 생성 !!!");
    }

    public override void move()
    {
        Debug.Log("메딕 이동 !!!");
    }
}