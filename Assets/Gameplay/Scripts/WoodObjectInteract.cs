using UnityEngine;

public class WoodObjectInteract : BreakableObject
{
    [SerializeField] private float _health = 3f;

    private float _currentHealth;

    private void OnEnable()
    {
        _currentHealth = _health;
    }

    protected override bool Break()
    {
        if (_attackType != AttackType.BreakingWood) return false;

        //_animator.Play()

        Debug.Log("hit");

        _currentHealth--;
        if (_currentHealth <= 0)
        {
            _isBreaked = true;
            gameObject.SetActive(false);
        }

        return true;
    }
}
