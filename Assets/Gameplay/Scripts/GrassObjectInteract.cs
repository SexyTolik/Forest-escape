using UnityEngine;

public class GrassObjectInteract : BreakableObject
{
    [SerializeField] private float _health = 3f;

    protected override bool Break()
    {
        if (_attackType != AttackType.BreakingGrass) return false;

        //_animator.Play()

        _health--;
        if (_health <= 0)
        {
            _isBreaked = true;
            gameObject.SetActive(false);
        }

        return true;
    }
}