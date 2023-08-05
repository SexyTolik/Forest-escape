using System.Collections;
using UnityEngine;

public abstract class BreakableObject : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private float _breakDelay = 1f;

    private bool _canBreak = true;
    protected AttackType _attackType;

    public void Interact(AttackType attackType)
    {
        _attackType = attackType;

        if (_canBreak == true)
        {
            Break();

            _particle.Play();

            StartCoroutine(BreakDelay());
        }
    }

    protected abstract void Break();

    private IEnumerator BreakDelay()
    {
        _canBreak = false;

        yield return new WaitForSeconds(_breakDelay);

        _canBreak = true;
    }
}



