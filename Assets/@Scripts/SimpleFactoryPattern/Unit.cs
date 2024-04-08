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
        Debug.Log("���� ���� !!!");
    }

    public override void move()
    {
        Debug.Log("���� �̵� !!!");
    }
}

public class Firebat : Unit
{
    public Firebat()
    {
        Debug.Log("���̾ ���� !!!");
    }

    public override void move()
    {
        Debug.Log("���̾ �̵� !!!");
    }
}

public class Medic : Unit
{
    public Medic()
    {
        Debug.Log("�޵� ���� !!!");
    }

    public override void move()
    {
        Debug.Log("�޵� �̵� !!!");
    }
}