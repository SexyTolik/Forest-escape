using UnityEngine;

public class GrassObjectInteract : BreakableObject
{
    [SerializeField] private float _health = 3f;

    protected override void Break()
    {
        if (_attackType == AttackType.BreakingGrass)
        {
            Debug.Log("GrassHit");
        }
    }
}