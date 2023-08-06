using UnityEngine;

public class WoodObjectInteract : BreakableObject
{
    [SerializeField] private float _health = 3f;

    protected override bool Break()
    {
        if (_attackType != AttackType.BreakingWood) return false;

        //_animator.Play()

        Debug.Log("hit");

        _health--;
        if (_health <= 0)
        {
            _isBreaked = true;
            gameObject.SetActive(false);
        }

        return true;
    }
}
