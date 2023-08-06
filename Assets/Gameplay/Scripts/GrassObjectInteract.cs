using UnityEngine;

public class GrassObjectInteract : BreakableObject
{
    [SerializeField] private float _health = 3f;

    private float _currentHealth; 

    private void OnEnable()
    {
        _currentHealth = _health;
        _isBreaked = false;
    }

    protected override bool Break()
    {
        if (_attackType != AttackType.BreakingGrass) return false;

        _animator.SetInteger("Input", 1);

        _currentHealth--;
        if (_currentHealth <= 0)
        {
            _isBreaked = true;
            gameObject.SetActive(false);
        }

        return true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>()._speed -= 5;
            other.GetComponent<CharacterController>().Move(new Vector3(0,0,0));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>()._speed += 5;
        }
    }
}