using UnityEngine;

public class WoodObjectInteract : BreakableObject
{
    [SerializeField] private float _health = 3f;

    protected override void Break()
    {
        if(_attackType == AttackType.BreakingWood)
        {
            Debug.Log("WoodHit");
        }
    }
}
