using System.Collections;
using UnityEngine;

public abstract class BreakableObject : MonoBehaviour
{
    [SerializeField] private float _breakDelay = 1f;
    [SerializeField] protected Animator _animator;

    private bool _canBreak = true;

    protected AttackType _attackType;
    protected bool _isBreaked = false;

    public bool Interact(AttackType attackType)
    {
        _attackType = attackType;

        if (_canBreak == false) return false;

        bool isBreakSucces = Break();

        if (_isBreaked == false) StartCoroutine(BreakDelay());
        
        return isBreakSucces;
    }

    protected abstract bool Break();

    private IEnumerator BreakDelay()
    {
        _canBreak = false;

        yield return new WaitForSeconds(_breakDelay);
        _animator.SetInteger("Input", 0);
        _canBreak = true;
    }
}