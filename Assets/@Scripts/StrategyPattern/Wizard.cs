using UnityEngine;

public class Wizard : MonoBehaviour, ICharacterJob
{
    public void Attack()
    {
        Debug.Log("마법사 공격!");
    }
}